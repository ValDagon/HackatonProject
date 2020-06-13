using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class RequestDetail : ContentPage
    {
        public RequestDetail(string Name, string MoreDetail, string MoreDetailImage, string commentTitle, string commentDetail)
        {
            InitializeComponent();

            MyItemNameShow.Text = Name;
            MyIngrediantItemShow.Text = MoreDetail;
            MyImageCall.Source = MoreDetailImage;

            CommentTitle.Text = commentTitle;
            CommentDetail.Text = commentDetail;
        }
    }
}