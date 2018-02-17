using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool isAdmin(string rac, string geslo)
        {
            using (DBContext contex = new DBContext())
            {
                List<UporabniskiRacun> r = contex.UpoRac.ToList();
                UporabniskiRacun tmp = r.Find(uporabniskoIme => uporabniskoIme.uporabniskoIme == rac);
                if (tmp.isAdmin)
                    return true;
                return false;
            }
        }
        public List<Podjetje> getPodjetjeAll()
        {
            using (DBContext contex = new DBContext())
            {
                List<Podjetje> tmp = contex.Podjetje.ToList();
                return tmp;
            }
        }
        public List<Oseba> getOsebeAll()
        {
            using (DBContext contex = new DBContext())
            {
                List<Oseba> tmp = contex.Oseba.ToList();
                return tmp;
            }
        }
        public string povprecna()
        {
            double povp = 0;
            double count = 0;
            using (DBContext contex = new DBContext())
            {
                List<Podjetje> tmp = contex.Podjetje.ToList();
                count = tmp.Count;
                for (int i = 0; i < tmp.Count; i++)
                {
                    povp += tmp[i].letoUstanovitve;
                }
            }

            return ((int)(povp / count)).ToString();
        }
        public List<Podjetje> listaPodjetja(string imeOsebe)
        {
            List<Podjetje> result = new List<Podjetje>();
            using (DBContext contex = new DBContext())
            {
                List<OsebaVPodjetju> tmp = contex.OsebaVPod.ToList();
                foreach (OsebaVPodjetju o in tmp)
                {
                    if (o.OsebaId == contex.Oseba.FirstOrDefault(e => e.ime == imeOsebe).OsebaId)
                        result.Add(contex.Podjetje.FirstOrDefault(e => e.PodjetjeId == o.PodjetjeId));
                }

            }

            return result;
        }
        public List<Oseba> listOseb(string podjetje)
        {
            List<Oseba> result = new List<Oseba>();
            using (DBContext contex = new DBContext())
            {
                var tmp = contex.OsebaVPod.ToList();
                foreach (OsebaVPodjetju o in tmp)
                {
                    if (o.PodjetjeId == contex.Podjetje.FirstOrDefault(e => e.naziv == podjetje).PodjetjeId)
                        result.Add(contex.Oseba.FirstOrDefault(e => e.OsebaId == o.OsebaId));
                }

            }

            return result;
        }
        public Oseba minOseba()
        {
            using (DBContext contex = new DBContext())
            {
                int leto = 2017;
                Oseba result = new Oseba();
                List<Oseba> tmp = contex.Oseba.ToList();
                foreach (Oseba o in tmp)
                {
                    if (o.letoRojstva < leto)
                        result = o;
                }
                return result;

            }
        }
        public Oseba getOsebaIme(string vnesenoIme)
        {
            using (DBContext contex = new DBContext())
            {
                List<Oseba> tmp = contex.Oseba.ToList();
                Oseba o = tmp.Find(ime => ime.ime == vnesenoIme);
                return o;

            }

        }
        public List<Oseba> getOsebeVPod()
        {
            using (DBContext contex = new DBContext())
            {
                return null;

            }
        }
        public OsebaVPodjetju getpodjetjeMax(string podjetje)
        {
            using (DBContext contex = new DBContext())
            {
                int count = 0;
                List<OsebaVPodjetju> tmp = contex.OsebaVPod.ToList();
                count++;
                return tmp[0];

            }
        }
        public Podjetje getPodjetjeWithMaxOseb()
        {
            int max = int.MinValue;
            int id = int.MinValue;
            using (DBContext context = new DBContext())
            {
                foreach (Podjetje pod in context.Podjetje)
                {
                    if (max < context.OsebaVPod.Count(e => e.PodjetjeId == id))
                    {
                        max = context.OsebaVPod.Count(e => e.PodjetjeId == id);
                        id = pod.PodjetjeId;
                    }
                }
                return context.Podjetje.First(e => e.PodjetjeId == id);
            }

        }
        public Oseba getOsebaWithMaxPod()
        {
            int max = int.MinValue;
            int id = int.MinValue;
            using (DBContext context = new DBContext())
            {
                foreach (Oseba pod in context.Oseba)
                {
                    if (max < context.OsebaVPod.Count(e => e.OsebaId == id))
                    {
                        max = context.OsebaVPod.Count(e => e.OsebaId == id);
                        id = pod.OsebaId;
                    }
                }
                return context.Oseba.First(e => e.OsebaId == id);
            }
        }

        public int InsertNewOseba(string ime, string priimek, int letoRojstva)
        {
            using (DBContext context = new DBContext())
            {
                context.Oseba.Add(new Oseba { ime = ime, priimek = priimek, letoRojstva = letoRojstva });
                return context.SaveChanges();
            }
        }
        public int InsertNewPodjetje(string naziv, string panoga, int leto)
        {
            using (DBContext context = new DBContext())
            {
                context.Podjetje.Add(new Podjetje { naziv = naziv, panoga = panoga, letoUstanovitve = leto });
                return context.SaveChanges();
            }
        }
        public int InsertNewUser(string ime, string geslo, bool admin)
        {
            using (DBContext context = new DBContext())
            {
                context.UpoRac.Add(new UporabniskiRacun { uporabniskoIme = ime, geslo = geslo, isAdmin = admin });
                return context.SaveChanges();
            }
        }
        public int RemoveOseba(string ime, string priimek)
        {
            using (DBContext context = new DBContext())
            {
                Oseba o = context.Oseba.FirstOrDefault(e => e.ime == ime && e.priimek == priimek);
                var tmp = context.Oseba.Remove(o);
                return context.SaveChanges();

            }
        }
        public int RemovePodjetje(string naziv)
        {
            using (DBContext context = new DBContext())
            {
                Podjetje o = context.Podjetje.FirstOrDefault(e => e.naziv == naziv);
                var tmp = context.Podjetje.Remove(o);
                return context.SaveChanges();

            }
        }
        public int AddOsebaVPodjetje(string ime, string priimek, string nazivPod, string delovnoMesto, int letoDo)
        {
            using (DBContext context = new DBContext())
            {
                Oseba o = context.Oseba.FirstOrDefault(e => e.ime == ime && e.priimek == priimek);
                Podjetje p = context.Podjetje.FirstOrDefault(e => e.naziv == nazivPod);
                var tmp = context.OsebaVPod.Add(new OsebaVPodjetju { OsebaId = o.OsebaId, PodjetjeId = p.PodjetjeId, letoOd = 2017, letoDo = letoDo, delovnoMesto = delovnoMesto });
                return context.SaveChanges();
            }
        }
        public int AddOsebaVPodjetjeByIndex(int indexO, int indexP, string delovnoMesto, int letoDo)
        {
            using (DBContext context = new DBContext())
            {
                Oseba o = context.Oseba.FirstOrDefault(e => e.OsebaId == indexO);
                Podjetje p = context.Podjetje.FirstOrDefault(e => e.PodjetjeId == indexP);
                var tmp = context.OsebaVPod.Add(new OsebaVPodjetju { OsebaId = o.OsebaId, PodjetjeId = p.PodjetjeId, letoOd = 2017, letoDo = letoDo, delovnoMesto = delovnoMesto });
                return context.SaveChanges();
            }
        }
        public int RemoveOsebeIzPodjetja(string ime, string priimek, string naziv)
        {
            using (DBContext context = new DBContext())
            {
                Oseba o = context.Oseba.FirstOrDefault(e => e.ime == ime && e.priimek == priimek);
                Podjetje p = context.Podjetje.FirstOrDefault(e => e.naziv == naziv);
                OsebaVPodjetju osebaVPodjetje = context.OsebaVPod.FirstOrDefault(e => e.OsebaId == o.OsebaId && e.PodjetjeId == p.PodjetjeId);
                //var tmp = context.OsebaVPod.Add(new OsebaVPodjetju { OsebaId = o.OsebaId, PodjetjeId = p.PodjetjeId, letoOd = 2017, letoDo = letoDo, delovnoMesto = delovnoMesto });
                var tmp = context.OsebaVPod.Remove(osebaVPodjetje);
                return context.SaveChanges();
            }
        }
        public int RemoveOsebeIzPodjetjaByIndex(int indexOseba, int indexPodjetje)
        {
            using (DBContext context = new DBContext())
            {
                Oseba o = context.Oseba.FirstOrDefault(e => e.OsebaId == indexOseba);
                Podjetje p = context.Podjetje.FirstOrDefault(e => e.PodjetjeId == indexPodjetje);
                OsebaVPodjetju osebaVPodjetje = context.OsebaVPod.FirstOrDefault(e => e.OsebaId == o.OsebaId && e.PodjetjeId == p.PodjetjeId);
                //var tmp = context.OsebaVPod.Add(new OsebaVPodjetju { OsebaId = o.OsebaId, PodjetjeId = p.PodjetjeId, letoOd = 2017, letoDo = letoDo, delovnoMesto = delovnoMesto });
                var tmp = context.OsebaVPod.Remove(osebaVPodjetje);
                return context.SaveChanges();
            }
        }
        public int UpdateOsebe(string ime, string priimek, string newIme, string newPriimek, int newLeto)
        {
            using (DBContext context = new DBContext())
            {
                Oseba o = context.Oseba.FirstOrDefault(e => e.ime == ime && e.priimek == priimek);
                o.ime = newIme;
                o.priimek = newPriimek;
                o.letoRojstva = newLeto;
                return context.SaveChanges();
            }

        }
        public int UpdatePodjetje(string naziv, string newNaziv, string newPanoga, int newLeto)
        {
            using (DBContext context = new DBContext())
            {
                Podjetje p = context.Podjetje.FirstOrDefault(e => e.naziv == naziv);
                p.naziv = newNaziv;
                p.panoga = newPanoga;
                p.letoUstanovitve = newLeto;

                return context.SaveChanges();
            }

        }
        public int OdstraniOsebo(int id)
        {
            using (DBContext context = new DBContext())
            {
                Oseba o = context.Oseba.FirstOrDefault(e => e.OsebaId == id);
                //var tmp = context.OsebaVPod.Add(new OsebaVPodjetju { OsebaId = o.OsebaId, PodjetjeId = p.PodjetjeId, letoOd = 2017, letoDo = letoDo, delovnoMesto = delovnoMesto });
                var tmp = context.Oseba.Remove(o);
                return context.SaveChanges();
            }

        }
        public int OdstraniPodjetje(int id)
        {
            using (DBContext context = new DBContext())
            {
                Podjetje o = context.Podjetje.FirstOrDefault(e => e.PodjetjeId == id);
                //var tmp = context.OsebaVPod.Add(new OsebaVPodjetju { OsebaId = o.OsebaId, PodjetjeId = p.PodjetjeId, letoOd = 2017, letoDo = letoDo, delovnoMesto = delovnoMesto });
                var tmp = context.Podjetje.Remove(o);
                return context.SaveChanges();
            }

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
