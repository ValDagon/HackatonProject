using System;
using System.Collections.ObjectModel;
using HackatonProject.Models;

namespace HackatonProject.ViewModel
{
    public class RequestViewModel
    {
        public ObservableCollection<RequestModel> RequestList { get; set; }
        public RequestViewModel()
        {
            RequestList = new ObservableCollection<RequestModel>
            {
                new RequestModel { Name = "Номер заявки: 12", Image = "alert.png", Detail = "Прорвало трубу", 
                    MoreDetail = "10 минут назад прорвало трубу с горячей водой в ванной комнате", MoreDetailImage = "water_problem.jpg", Status = "Рассматривается", BackgroundColor = "#00CCFF", TextColor = "Black", 
                    CommentTitle = "Комментарий ведомства:", CommentDetail = "Ваша заявка рассматривается, пожалуйста подождите"},

                new RequestModel { Name = "Номер заявки: 13", Image = "in_working.png", Detail = "В подъезде не работает свет", 
                    MoreDetail = "Уже два дня в подъезде не работает свет", MoreDetailImage = "light_off.jpg", Status = "В работе", BackgroundColor = "Black", TextColor = "White", 
                    CommentTitle = "Комментарий ведомства:", CommentDetail = "Наш специалист выехал к вам для устранения проблем"},

                new RequestModel { Name = "Номер заявки: 14", Image = "ready.png", Detail = "Батареи плохо греют", 
                    MoreDetail = "В двух комната батареи не горячее комнатной температуры", MoreDetailImage = "", Status = "Выполнена", BackgroundColor = "#00FF66", TextColor = "Black", 
                    CommentTitle = "Комментарий ведомства:", CommentDetail = "Все работы завершены"},
            };
        }
    }
}