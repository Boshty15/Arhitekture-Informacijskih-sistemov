﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client
{
    public class UporabniskiRacun
    {
        public int UporabniskiRacunId { get; set; }
        public string uporabniskoIme { get; set; }
        public string geslo { get; set; }
        public bool isAdmin { get; set; }
    }
}