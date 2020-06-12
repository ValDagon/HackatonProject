using System;
using System.Collections.ObjectModel;
using HackatonProject.Models;

namespace HackatonProject.ViewModel
{
    public class RequestViewModel
    {
        public ObservableCollection<RequestModel> FoodList { get; set; }

        public RequestViewModel()
        {
            FoodList = new ObservableCollection<RequestModel>
            {
                new RequestModel { Name = "Прорвало трубу", Image = "alert.png", Detail = "10 минут назад прорвало трубу в ванной комнате", MoreDetail = "10 минут назад прорвало трубу в ванной комнате", Status = "Рассматривается", BackgroundColor = "#0099FF", TextColor = "Black" },
                new RequestModel { Name = "Нет света в подъезде", Image = "in_working.png", Detail = "В подъезде уже два дня не работает свет", MoreDetail = "10 минут назад прорвало трубу в ванной комнате", Status = "В работе", BackgroundColor = "Black", TextColor = "White" },
                new RequestModel { Name = "Отопление", Image = "ready.png", Detail = "Батареи плохо греют", MoreDetail = "10 минут назад прорвало трубу в ванной комнате", Status = "Выполнена", BackgroundColor = "#00FF66", TextColor = "Black"}
            };
        }
    }
}