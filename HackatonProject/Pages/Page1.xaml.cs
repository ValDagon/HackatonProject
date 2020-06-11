using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HackatonProject.Pages
{
    [DesignTimeVisible(false)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
//            Shell.SetNavBarIsVisible(this, false);
            InitializeComponent();
            MyEvents = GetEvents();
            this.BindingContext = this;
        }

        public ObservableCollection<Event> MyEvents { get; set; }

        private ObservableCollection<Event> GetEvents()
        {
            return new ObservableCollection<Event>
            {
                new Event { Title = "Отключение горячей воды", Image = "banner.png", Venue = "Важно", Duration = "07:30 - 09:30", Date = new DateTime(2020, 6, 8), Description = "В связи с проведением работ по замене узла на ПНС «Ростоши-2». Пос. Ростоши-2. В районе отключения ЦТП и котельные отсутствуют. Подвоз воды по заявкам потребителей.  "},
                new Event { Title = "Отключение холодной воды", Image = "onlinetraining.jpg", Venue = "Важно", Duration = "07:30 - 09:30", Date = new DateTime(2020, 6, 9), Description = "В связи с проведением работ по замене узла на ПНС «Ростоши-2». Пос. Ростоши-2. В районе отключения ЦТП и котельные отсутствуют. Подвоз воды по заявкам потребителей.  "},
                new Event { Title = "Отключение электричества", Image = "dogs.jpg", Venue = "Не важно", Duration = "07:30 - 09:30", Date = new DateTime(2020, 6, 10), Description = "В связи с плановыми ремонтными работами ожидается прекращение подачи электроэнергии в Пос.Ростоши"},
                new Event { Title = "Плановые ремонтные работы", Image = "bookclub.jpg", Venue = "Важно", Duration = "07:30 - 09:30", Date = new DateTime(2020, 6, 11), Description = "Ул. Салмышская, 44. ГВС нет в районе с 00:00 10.06.2020 до 24:00 13.06.2020. В связи с производством плановых работ по подготовке к ОЗП 2020-2021. "},
                new Event { Title = "Отключение газа", Image = "tea.jpg", Venue = "Информация", Duration = "07:30 - 09:30", Date = new DateTime(2020, 6, 12), Description = "Отключение газа"}
            };
        }

        private async Task OpenAnimation(View view, uint length = 250)
        {
            view.RotationX = -90;
            view.IsVisible = true;
            view.Opacity = 0;
            _ = view.FadeTo(1, length);
            await view.RotateXTo(0, length);
        }

        private async Task CloseAnimation(View view, uint length = 250)
        {
            _ = view.FadeTo(0, length);
            await view.RotateXTo(-90, length);
            view.IsVisible = false;
        }

        private async void MainExpander_Tapped(object sender, EventArgs e)
        {
            var expander = sender as Expander;
            var imgView = expander.FindByName<Grid>("ImageView");
            var detailsView = expander.FindByName<Grid>("DetailsView");

            if (expander.IsExpanded)
            {
                await OpenAnimation(imgView);
                await OpenAnimation(detailsView);
            }
            else
            {
                await CloseAnimation(detailsView);
                await CloseAnimation(imgView);
            }
        }
    }

    public class Event
    {
        public string Title { get; set; }
        public string Venue { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}
