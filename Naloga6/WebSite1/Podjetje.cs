using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsFormsApp
{
    public class Podjetje
    {
        public int PodjetjeId { get; set; }
        public string naziv { get; set; }
        public string panoga { get; set; }
        public int letoUstanovitve { get; set; }
    }
}