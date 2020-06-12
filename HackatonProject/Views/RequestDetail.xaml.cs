using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class RequestDetail : ContentPage
    {
        public RequestDetail(string Name, string Ingredients, string source)
        {
            InitializeComponent();

            MyItemNameShow.Text = Name;
            MyIngrediantItemShow.Text = Ingredients;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };

        }
    }
}