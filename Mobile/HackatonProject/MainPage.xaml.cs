using HackatonProject.ViewModels.MicroCharts;
using HackatonProject.Views.MicroCharts;
using Microcharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HackatonProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            SetNavBarIsVisible(this, false); // Отключить тулбар
            InitializeComponent();

        }
    }
}
