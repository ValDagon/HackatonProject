using HackatonProject.ViewModel;
using HackatonProject.ViewModels.MicroCharts;
using Microcharts.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackatonProject.Views.MicroCharts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentasView : ContentPage
    {
        public VentasView(VentasViewModel vm)
        {
            InitializeComponent();
            CV.BindingContext = vm;
            LV.BindingContext = new FinanceViewModel();
        }
    }
}