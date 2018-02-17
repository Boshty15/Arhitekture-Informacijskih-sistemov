using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Threading;

namespace WebAIR
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        List<Oseba> osebe = new List<Oseba>();
        List<Podjetje> podjetja = new List<Podjetje>();
        List<OsebaVPodjetju> osebaVpodjetju = new List<OsebaVPodjetju>();
        List<UporabniskiRacun> upoRac = new List<UporabniskiRacun>();
        
        
        [WebMethod]
        public string getOseba()
        {
            SetPodatki();
            XmlSerializer serialize = new XmlSerializer(typeof(Oseba));

            using (StringWriter writer = new StringWriter())
            {
                serialize.Serialize(writer, osebe[0]);
                return writer.ToString();
            }
        }
        [WebMethod]
        public OsebaVPodjetju getPodjetjeMax(string pod)
        {
            
            return osebaVpodjetju[0];
        }
        [WebMethod]
        public List<Oseba> getOsebeVPod()
        {

            return null;
        }
        [WebMethod]
        public Oseba getOsebaIme(string vnesenoIme)
        {
            SetPodatki();

            Oseba o = osebe.Find(ime => ime.ime == vnesenoIme);

            return o;
        }
        [WebMethod]
        
        public Oseba minOseba()
        {
            SetPodatki();
            int leto = 2017;
            Oseba tmp = new Oseba();
            foreach(Oseba o in osebe)
            {
                if (o.letoRojstva < leto)
                {
                    //leto = o.letoRojstva;
                    tmp = o;
                }
                   
            }
            return tmp;
        }
        [WebMethod]
        public List<OsebaVPodjetju> listaOseb(string imePod)
        {
            SetPodatki();
            List<OsebaVPodjetju> lista = new List<OsebaVPodjetju>();
            foreach(OsebaVPodjetju os in osebaVpodjetju)
            {
                if (os.podjetje.naziv == imePod)
                    lista.Add(os);
            }


            return lista;
        }
        [WebMethod]
        public List<OsebaVPodjetju> listaPodjetja(string imeOsebe)
        {
            SetPodatki();
            List<OsebaVPodjetju> lista = new List<OsebaVPodjetju>();
            foreach (OsebaVPodjetju os in osebaVpodjetju)
            {
                if (os.oseba.ime == imeOsebe)
                    lista.Add(os);
            }


            return lista;
        }

        [WebMethod]
        public string povprecna()
        {
            return povp();
        }
        private string povp()
        {
            double povp = 0;
            SetPodatki();
            for (int i = 0; i < podjetja.Count; i++)
            {
                povp += podjetja[i].letoUstanovitve;
            }

            return ((int)(povp / podjetja.Count)).ToString();
        }
        [WebMethod]
        public List<Oseba> getOsebeAll()
        {
            SetPodatki();
            return osebe;
        }
        [WebMethod]
        public List<Podjetje> getPodjetjeAll()
        {
            SetPodatki();
            return podjetja;
        }
        [WebMethod]
        public bool isAdministrator(string rac, string geslo)
        {
            SetPodatki();
            UporabniskiRacun tmp = upoRac.Find(uporabniskoIme => uporabniskoIme.uporabniskoIme == rac);
            if (tmp.isAdmin)
                return true;
            else
                return false;
        }
        public void SetPodatki()
        {
            osebe.Add(new Oseba { ime = "Boštjan", priimek = "Koštomaj", letoRojstva = 1996 });
            osebe.Add(new Oseba { ime = "Žiga", priimek = "Stopar", letoRojstva = 1996 });
            osebe.Add(new Oseba { ime = "Hana", priimek = "Vogelsang", letoRojstva = 1994 });
            osebe.Add(new Oseba { ime = "Tomaž", priimek = "Koštomaj", letoRojstva = 2000 });
            osebe.Add(new Oseba { ime = "Jan", priimek = "Kvas", letoRojstva = 2005 });

            podjetja.Add(new Podjetje { naziv = "FERI", letoUstanovitve = 2000, panoga = "Šola" });
            podjetja.Add(new Podjetje { naziv = "FRI", letoUstanovitve = 1966, panoga = "Šola" });
            podjetja.Add(new Podjetje { naziv = "CMC", letoUstanovitve = 1566, panoga = "Gradbeno" });
            podjetja.Add(new Podjetje { naziv = "HRC", letoUstanovitve = 1766, panoga = "Računalništvo" });

            osebaVpodjetju.Add(new OsebaVPodjetju { oseba = osebe[1], podjetje = podjetja[0], letoOd = 2000, letoDo = 2004, delovnoMesto = "Profesor" });
            osebaVpodjetju.Add(new OsebaVPodjetju { oseba = osebe[1], podjetje = podjetja[1], letoOd = 2005, letoDo = 2010, delovnoMesto = "Ravnatelj" });
            osebaVpodjetju.Add(new OsebaVPodjetju { oseba = osebe[2], podjetje = podjetja[2], letoOd = 2007, letoDo = 2014, delovnoMesto = "Delavewc" });
            osebaVpodjetju.Add(new OsebaVPodjetju { oseba = osebe[3], podjetje = podjetja[3], letoOd = 2000, letoDo = 2024, delovnoMesto = "delavec" });
            osebaVpodjetju.Add(new OsebaVPodjetju { oseba = osebe[3], podjetje = podjetja[0], letoOd = 2000, letoDo = 2034, delovnoMesto = "delavec" });
            osebaVpodjetju.Add(new OsebaVPodjetju { oseba = osebe[0], podjetje = podjetja[0], letoOd = 2005, letoDo = 2014, delovnoMesto = "Profesor" });
            osebaVpodjetju.Add(new OsebaVPodjetju { oseba = osebe[1], podjetje = podjetja[1], letoOd = 2010, letoDo = 2020, delovnoMesto = "Profesor" });

            upoRac.Add(new UporabniskiRacun { isAdmin = true, uporabniskoIme = "Bosti", geslo = "123" });
            upoRac.Add(new UporabniskiRacun { isAdmin = false, uporabniskoIme = "Bosti2", geslo = "123" });


        }
    }
}
