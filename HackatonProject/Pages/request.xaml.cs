using System;
using System.Collections.Generic;
using HackatonProject.Models;
using HackatonProject.ViewModel;
using HackatonProject.Views;
using Xamarin.Forms;

namespace HackatonProject.Pages
{
    public partial class Request : ContentPage
    {
        public Request()
        {
            InitializeComponent();
            BindingContext = new RequestViewModel();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as RequestModel;
            await Navigation.PushAsync(new RequestDetail(mydetails.Name, mydetails.Ingredients, mydetails.Image));

        }

    }
}