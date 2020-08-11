using System;
using System.Collections.Generic;
using System.Text;

namespace hepsiSefBlog.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool isSubToBulletin { get; set; }
    }
}
