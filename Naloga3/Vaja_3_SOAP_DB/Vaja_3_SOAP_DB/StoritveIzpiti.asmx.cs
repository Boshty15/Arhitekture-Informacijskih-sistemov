using System.Collections.Generic;
using System.Web.Services;

namespace Vaja_3_SOAP_DB
{
    /// <summary>
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StoritveIzpiti : System.Web.Services.WebService
    {
        [WebMethod]
        public OsebaVPodjetju getPodjetjeMax(string pod)
        {
            return Podatki.getpodjetjeMax(pod);
        }
        [WebMethod]
        public List<Oseba> getOsebeVPod()
        {
            return Podatki.getOsebeVPod();
        }
        [WebMethod]
        public Oseba getOsebaIme(string vnesenoIme)
        {
            return Podatki.getOsebaIme(vnesenoIme);
        }
        [WebMethod]

        public Oseba minOseba()
        {
            return Podatki.minOseba();
        }
        [WebMethod]
        public List<Oseba> listaOseb(string imePod)
        {
            return Podatki.listOseb(imePod);
        }
        [WebMethod]
        public List<Podjetje> listaPodjetja(string imeOsebe)
        {
            return Podatki.listaPodjetja(imeOsebe);
        }

        [WebMethod]
        public string povprecna()
        {
            return Podatki.povprecna();
        }
        [WebMethod]
        public List<Oseba> getOsebeAll()
        {
            return Podatki.getOsebeAll();
        }
        [WebMethod]
        public List<Podjetje> getPodjetjeAll()
        {
            return Podatki.getPodjetjeAll();
        }
        [WebMethod]
        public bool isAdministrator(string rac, string geslo)
        {
            return Podatki.isAdmin(rac, geslo);
        }
        [WebMethod]
        public Podjetje getPodjetjeWithMaxOseb()
        {
            return Podatki.getPodjetjeWithMaxOseb();
        }
        [WebMethod]
        public Oseba getOsebaWithMaxPod()
        {
            return Podatki.getOsebaWithMaxPod();
        }
        [WebMethod]
        public int InsertNewOseba(string ime, string priimek, int letoRojstva)
        {
            return Podatki.InsertNewOseba(ime, priimek, letoRojstva);
        }
        [WebMethod]
        public int InsertNewPodjetje(string naziv, string panoga, int leto)
        {
            return Podatki.InsertNewPodjetje(naziv,panoga,leto);
        }
        [WebMethod]
        public int InsertNewUser(string ime, string geslo, bool admin)
        {
            return Podatki.InsertNewUser(ime, geslo, admin);
        }
        [WebMethod]
        public int RemoveOseba(string ime, string priimek)
        {
            return Podatki.RemoveOseba(ime, priimek);
        }
        [WebMethod]
        public int RemovePodjetje(string naziv)
        {
            return Podatki.RemovePodjetje(naziv);
        }
        [WebMethod]
        public int AddOsebaVPodjetje(string ime, string priimek, string nazivPod, string delovnoMesto, int letoDo)
        {
            return Podatki.AddOsebaVPodjetje(ime, priimek, nazivPod, delovnoMesto, letoDo);
        }
        [WebMethod]
        public int RemoveOsebeIzPodjetja(string ime, string priimek, string naziv)
        {
            return Podatki.RemoveOsebeIzPodjetja(ime, priimek, naziv);
        }
        [WebMethod]
        public int UpdateOsebe(string ime, string priimek, string newIme, string newPriimek, int newLeto)
        {
            return Podatki.UpdateOsebe(ime, priimek, newIme, newPriimek, newLeto);
        }
        [WebMethod]
        public int UpdatePodjetje(string naziv, string newNaziv, string newPanoga, int newLeto)
        {
            return Podatki.UpdatePodjetje(naziv, newNaziv, newPanoga, newLeto);
        }
    }
}
