using System;
using System.Collections.Generic;
using System.Text;

namespace hepsiSefBlog.Service.Model.Request
{
    public class RecipeCreateRequest
    {
        public string Title { get; set; }
        public string ImageUrlList { get; set; }
        public string Tags { get; set; }
        public string HowTo { get; set; }
        public string Ingredients { get; set; }
    }
}
