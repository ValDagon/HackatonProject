using System;
using System.Collections.ObjectModel;
using HackatonProject.Models;

namespace HackatonProject.ViewModel
{
    public class FinanceViewModel
    {
        public ObservableCollection<FinanceModel> FinanceList { get; set; }
        public FinanceViewModel()
        {
            FinanceList = new ObservableCollection<FinanceModel>
            {
                new FinanceModel {Image = "DarkBlue.png", Detail = "Отопление"},

                new FinanceModel {Image = "DarkGreen.png", Detail = "Электричество"},

                new FinanceModel {Image = "LightGreen.png", Detail = "Горячая вода"},

                new FinanceModel {Image = "VeryDarkGreen.png", Detail = "Холодная вода"},
                
                new FinanceModel {Image = "Yellow.png", Detail = "Другие платежи"},
            };
        }
    }
}