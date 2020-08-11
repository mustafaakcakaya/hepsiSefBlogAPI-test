using System;
using System.Collections.Generic;
using System.Text;

namespace hepsiSefBlog.Data.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //image'leri image entity'si olarak kaydetmek deletable(boolean ile) yapmak daha mantıklı overengineering olmasın diye basit geçiyorum
        public string ImageUrlList { get; set; }
        public string Tags { get; set; }
        public string HowTo { get; set; }

        //malzemeler
        public string Ingredients { get; set; }
    }
}
