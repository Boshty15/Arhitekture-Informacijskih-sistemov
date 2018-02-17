using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.localhost;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService services = new localhost.WebService();
            bool loop = true;

            //services.SetPodatki();

            Console.WriteLine("Vnesi uporabniško ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Vnesi geslo: ");
            string geslo = Console.ReadLine();
        

            while (loop)
            {
                Console.WriteLine("1. Izpis vseh vrednosti prve entite(Osebe)");
                Console.WriteLine("2. Izpis vseh vrednosti druge entite(Podjetje)");
                Console.WriteLine("3. Pregled vseh primerkov prve entitete v drugi");
                Console.WriteLine("4. Pregled vseh primerkov druge entitete v prvi");
                Console.WriteLine("5. Izpis podrobnosti enega primerka");
                Console.WriteLine("6. Izpis primerka entitete, ki vsebuje največ primerkov druge entitete");
                Console.WriteLine("7. Izpis podrobnosti enega primerka, katerega poljuben atribut ima največjo vrednost (najmlajša oseba) ");
                Console.WriteLine("8. Izpis povprečne vrednosti poljubnega atributa entitete (povprečno leto ustanovitve)");
                Console.WriteLine("0. Konec");
                int izbira = int.Parse(Console.ReadLine());

                switch (izbira)
                {
                    case 1:
                        if (services.isAdministrator(ime, geslo))
                        {
                            Oseba[] oseba = services.getOsebeAll();
                            foreach (Oseba o in oseba)
                            {
                                Console.WriteLine(o.ime + " " + o.priimek + " " + o.letoRojstva);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nimaš dostopa, ker nisi administrator");
                        }

                        Console.WriteLine();
                        break;
                    case 2:
                        if (services.isAdministrator(ime, geslo))
                        {
                            Podjetje[] podjetje = services.getPodjetjeAll();
                        foreach (Podjetje p in podjetje)
                            Console.WriteLine(p.naziv + " " + p.letoUstanovitve + " " + p.panoga);
                        }
                        else
                        {
                            Console.WriteLine("Nimaš dostopa, ker nisi administrator");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Vnesi ime podjetja: ");
                        string t = Console.ReadLine();
                        OsebaVPodjetju[] osebaVPod = services.listaOseb(t);
                        foreach(OsebaVPodjetju op in osebaVPod)
                        {
                            Console.WriteLine(op.oseba.ime + " " + op.oseba.priimek + " " + op.oseba.letoRojstva + " " + op.podjetje.naziv + " " +op.podjetje.panoga + " " +op.letoDo + " " +op.letoOd );
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Vnesi ime osebe: ");
                        string tt = Console.ReadLine();
                        OsebaVPodjetju[] osebaVPod2 = services.listaPodjetja(tt);
                        foreach (OsebaVPodjetju op in osebaVPod2)
                        {
                            Console.WriteLine(op.oseba.ime + " " + op.oseba.priimek + " " + op.oseba.letoRojstva + " " + op.podjetje.naziv + " " + op.podjetje.panoga + " " + op.letoDo + " " + op.letoOd);
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Vnesi ime osebe, ki jo želiš izpisati: ");
                        string ime2 = Console.ReadLine();
                        Oseba o2 = services.getOsebaIme(ime2);
                        Console.WriteLine(o2.ime + " " + o2.priimek + " " + o2.letoRojstva);
                        Console.WriteLine();
                        break;
                    case 6:

                        Console.WriteLine();
                        break;
                    case 7:
                        o2 = services.minOseba();
                        Console.WriteLine(o2.ime + " " + o2.priimek + " " + o2.letoRojstva);
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Povprečno leto ustanovitve podjetja: " + services.povprecna());
                        Console.WriteLine();
                        break;
                    case 0:
                        loop = false;
                        break;
                }



            }
            
            
        }
        
    }
}
