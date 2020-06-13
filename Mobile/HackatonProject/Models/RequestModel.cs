using System;
using System.Dynamic;
using System.Xml.Linq;

namespace HackatonProject.Models
{
    public class RequestModel
    {
        public string Name { get; set; }

        public string Detail { get; set; }

        public string Image { get; set; }

        public string MoreDetail { get; set; }

        public string MoreDetailImage {get; set; }
        public string Status { get; set; }

        public string BackgroundColor { get; set; }

        public string TextColor { get; set; }

        public string CommentTitle { get; set; }

        public string CommentDetail { get; set; }

    }
}