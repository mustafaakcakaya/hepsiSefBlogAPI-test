using System;
using System.Collections.Generic;
using System.Text;

namespace hepsiSefBlog.Service.Model.Response
{
    public class RecipeResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //içeride seperator ile ayrılan string yapı
        public string ImageUrlList { get; set; }
        public string Tags { get; set; }
        public string HowTo { get; set; }
        public string Ingredients { get; set; }
    }
}
