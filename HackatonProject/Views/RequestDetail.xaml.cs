using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class RequestDetail : ContentPage
    {
        public RequestDetail(string Name, string MoreDetail, string source, string Status, string TextColor, string BackgroundColor)
        {
            InitializeComponent();

            MyItemNameShow.Text = Name;
            MyIngrediantItemShow.Text = MoreDetail;
            MyImageCall.Source = source;
        }
    }
}