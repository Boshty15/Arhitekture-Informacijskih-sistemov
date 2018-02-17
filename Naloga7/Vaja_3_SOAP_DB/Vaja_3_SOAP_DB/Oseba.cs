using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vaja_3_SOAP_DB
{
    public class Oseba
    {
        public int OsebaId { get; set; }
        public string ime { get; set; }
        public string priimek { get; set; }
        public int letoRojstva { get; set; }
    }
}