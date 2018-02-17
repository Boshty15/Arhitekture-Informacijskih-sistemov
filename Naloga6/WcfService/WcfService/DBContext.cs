using System;
using System.Collections.Generic;
using System.Data.Entity;

    public class DBContext : DbContext
    {

        public DbSet<Oseba> Oseba { get; set; }

        public DbSet<Podjetje> Podjetje { get; set; }
        public DbSet<OsebaVPodjetju> OsebaVPod { get; set; }

        public DbSet<UporabniskiRacun> UpoRac{ get; set; }

        public DBContext()
        {
            Database.SetInitializer<DBContext>(new DBContextInitializer());

            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public class DBContextInitializer : DropCreateDatabaseIfModelChanges<DBContext>
        {
            protected override void Seed(DBContext context)
            {
                List<Oseba> osebe = new List<Oseba>()
                {
                    new Oseba {OsebaId = 0, ime = "Boštjan", priimek = "Koštomaj", letoRojstva = 1996 },
                    new Oseba {OsebaId = 1, ime = "Žiga", priimek = "Stopar", letoRojstva = 1996 },
                    new Oseba {OsebaId = 2, ime = "Hana", priimek = "Vogelsang", letoRojstva = 1994 },
                    new Oseba {OsebaId = 3, ime = "Tomaž", priimek = "Koštomaj", letoRojstva = 2000 },
                    new Oseba {OsebaId = 4, ime = "Jan", priimek = "Kvas", letoRojstva = 2005 }
                };
                context.Oseba.AddRange(osebe);
                List<Podjetje> podjetje = new List<Podjetje>()
                {
                new Podjetje {PodjetjeId = 0, naziv = "FERI", letoUstanovitve = 2000, panoga = "Šola" },
                new Podjetje {PodjetjeId = 1, naziv = "FRI", letoUstanovitve = 1966, panoga = "Šola" },
                new Podjetje {PodjetjeId = 2, naziv = "CMC", letoUstanovitve = 1566, panoga = "Gradbeno" },
                new Podjetje {PodjetjeId = 3, naziv = "HRC", letoUstanovitve = 1766, panoga = "Računalništvo" }
                };
                context.Podjetje.AddRange(podjetje);

                List<OsebaVPodjetju> osebaVPod = new List<OsebaVPodjetju>()
                {
                new OsebaVPodjetju { OsebaVPodjetjuId = 0, OsebaId = 1, PodjetjeId = 0, letoOd = 2000, letoDo = 2004, delovnoMesto = "Profesor" },
                new OsebaVPodjetju { OsebaVPodjetjuId = 1, OsebaId = 1, PodjetjeId = 1, letoOd = 2005, letoDo = 2010, delovnoMesto = "Ravnatelj" },
                new OsebaVPodjetju { OsebaVPodjetjuId = 2, OsebaId = 2, PodjetjeId = 2, letoOd = 2007, letoDo = 2014, delovnoMesto = "Delavewc" },
                new OsebaVPodjetju { OsebaVPodjetjuId = 3, OsebaId = 3, PodjetjeId = 3, letoOd = 2000, letoDo = 2024, delovnoMesto = "delavec" },
                new OsebaVPodjetju { OsebaVPodjetjuId = 4, OsebaId = 3, PodjetjeId = 0, letoOd = 2000, letoDo = 2034, delovnoMesto = "delavec" },
                new OsebaVPodjetju { OsebaVPodjetjuId = 5, OsebaId = 0, PodjetjeId = 0, letoOd = 2005, letoDo = 2014, delovnoMesto = "Profesor" },
                new OsebaVPodjetju { OsebaVPodjetjuId = 6, OsebaId = 1, PodjetjeId = 1, letoOd = 2010, letoDo = 2020, delovnoMesto = "Profesor" }
                };
                context.OsebaVPod.AddRange(osebaVPod);

                List<UporabniskiRacun> upoRac = new List<UporabniskiRacun>()
                {
                   new UporabniskiRacun {UporabniskiRacunId = 0, isAdmin = true, uporabniskoIme = "Bosti", geslo = "123" },
                   new UporabniskiRacun {UporabniskiRacunId = 1, isAdmin = false, uporabniskoIme = "Bosti2", geslo = "123" }
                };
                context.UpoRac.AddRange(upoRac);

                
                base.Seed(context);
            }
        }
    }
