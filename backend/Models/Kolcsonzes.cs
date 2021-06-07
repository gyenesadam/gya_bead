using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Models
{
    public class Kolcsonzes
    {
        public int KolcsID { get; set; }
        public int Tag { get; set; }
        public string Kolcsdatuma { get; set; }
        public string Visszadatum { get; set; }
        public int Media { get; set; }
     }
}