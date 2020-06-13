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
    public partial class News : ContentPage
    {
        public News()
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
                new Event { Title = "Отключение горячей воды", Duration = "12.06.2020 07:30 - 09:30", Description = "В связи с проведением работ по замене узла на ПНС «Ростоши-2». Пос. Ростоши-2. В районе отключения ЦТП и котельные отсутствуют. Подвоз воды по заявкам потребителей. аааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааа"},
                new Event { Title = "Отключение холодной воды", Duration = "11.06.2020 07:30 - 09:30", Description = "В связи с проведением работ по замене узла на ПНС «Ростоши-2». Пос. Ростоши-2. В районе отключения ЦТП и котельные отсутствуют. Подвоз воды по заявкам потребителей.  "},
                new Event { Title = "Отключение электричества", Duration = "13.06.2020 07:30 - 09:30", Description = "В связи с плановыми ремонтными работами ожидается прекращение подачи электроэнергии в Пос.Ростоши"},
                new Event { Title = "Плановые ремонтные работы", Duration = "14.05.2020 07:30 - 09:30", Description = "Ул. Салмышская, 44. ГВС нет в районе с 00:00 10.06.2020 до 24:00 13.06.2020. В связи с производством плановых работ по подготовке к ОЗП 2020-2021. "},
                new Event { Title = "Отключение газа", Duration = "11.05.2020 07:30 - 09:30", Description = "Отключение газа"}
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

        private void ShortNewsColor(View view, Color color)
        {
            view.BackgroundColor = color; 
        }
        private async void MainExpander_Tapped(object sender, EventArgs e)
        {
            var expander = sender as Expander;
            var detailsView = expander.FindByName<Grid>("DetailsView");
            var shortnews = expander.FindByName<Grid>("ShortView");
            if (expander.IsExpanded)
            {
                ShortNewsColor(shortnews, Color.LightGray);
                await OpenAnimation(detailsView);
            }
            else
            {
                ShortNewsColor(shortnews, Color.White);
                await CloseAnimation(detailsView);
            }
        }
    }

    public class Event
    {
        public string Title { get; set; }
        public string Venue { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
