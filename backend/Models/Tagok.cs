using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Models
{
    public class Tagok
    {
        public int TagID { get; set; }
        public string Nev { get; set; }
        public string SZIG { get; set; }
        public int IR { get; set; }
        public string Cim { get; set; }
        public string Statusz { get; set; }

    }
}