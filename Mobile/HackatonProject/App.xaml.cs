using System;
using System.Collections.Generic;
using System.Linq;
using HackatonProject.Helpers;
using HackatonProject.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackatonProject
{
    public partial class App : Application
    {
        public static List<string> ColorsList;
        public App()
        {
            InitializeComponent();
            ColorsList = ColorHelper.GetRandomColors().ToList();
            Device.SetFlags(new[] { "Expander_Experimental" });
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
