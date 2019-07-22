using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookliberary.Models
{
    public class books
    {
        public int id { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public string bookyear { get; set; }
        public string category { get; set; }
        public string category2 { get; set; }
        public int ISBN { get; set; }
        public string image { get; set; }
        public double matchedratio { get; set; }
    }
}