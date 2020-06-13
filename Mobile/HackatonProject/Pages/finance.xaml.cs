using HackatonProject.ViewModel;
using HackatonProject.ViewModels.MicroCharts;
using HackatonProject.Views.MicroCharts;
using Microcharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackatonProject.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Finance : ContentPage
    {
        public Finance()
        {
            InitializeComponent();
            MostrarMicroChart("Donut", new DonutChart() { HoleRadius = 0.6F });
            BindingContext = new FinanceViewModel();
        }
        async Task MostrarMicroChart(string title, Chart chartType)
        {
            var vm = new VentasViewModel(title, chartType, App.ColorsList);
            await Navigation.PushAsync(new VentasView(vm));
        }

    }
}