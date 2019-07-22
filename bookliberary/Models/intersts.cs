using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bookliberary.Models
{
    public class intersts
    {

        public int userid { get; set; }
        public SelectList author { get; set; }
        public string author_name { get; set; }

        public SelectList year { get; set; }
        public string selectedyear { get; set; }
        public SelectList booktype { get; set; }
        public string selectedbooktype { get; set; }
    }

    public class authors
    {
        public string  name { get; set; }
        public int id { get; set; }
    }
    public class years
    {
        public string name { get; set; }
        public int id { get; set; }
    }
    public class booktypes
    {
        public string name { get; set; }
        public string id { get; set; }
    }


}