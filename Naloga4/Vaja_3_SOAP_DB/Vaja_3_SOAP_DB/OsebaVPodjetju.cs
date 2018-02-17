﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vaja_3_SOAP_DB
{
    public class OsebaVPodjetju
    {
        public int OsebaVPodjetjuId { get; set; }
        public int letoOd { get; set; }
        public int letoDo { get; set; }
        public string delovnoMesto { get; set; }

        public int OsebaId { get; set; }
        public int PodjetjeId { get; set; }
        public virtual Oseba Oseba { get; set; }
        public virtual Podjetje Podjetje { get; set; }
    }
}