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
            localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
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
                Console.WriteLine("9. DOdaj nov primerek osebe");
                Console.WriteLine("10. Dodaj nov primerek Podjetja");
                Console.WriteLine("11. Ureanje oseb");
                Console.WriteLine("12. Urenaje podjetij");
                Console.WriteLine("13 Dodaj osebo v podjetje");
                Console.WriteLine("14. Odstrani osebo iz podjetja");
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
                        Oseba[] osebaVPod = services.listaOseb(t);
                        foreach(Oseba op in osebaVPod)
                        {
                            Console.WriteLine(op.ime + " " + op.priimek + " " + op.letoRojstva );
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Vnesi ime osebe: ");
                        string tt = Console.ReadLine();
                        Podjetje[] osebaVPod2 = services.listaPodjetja(tt);
                        foreach (Podjetje op in osebaVPod2)
                        {
                            Console.WriteLine(op.naziv + " " + op.panoga);
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
                    case 9:
                        Console.WriteLine("Dodaj novo osebo");
                        Console.WriteLine("Vnesi ime, priimek in leto rojstva");
                        var i = Console.ReadLine();
                        var pr = Console.ReadLine();
                        var l = int.Parse(Console.ReadLine());

                        services.InsertNewOseba(i, pr, l);

                        if(services.InsertNewOseba(i, pr, l) == 1){
                            Console.WriteLine("Uspešno dodana oseba");
                        }

                        break;
                    case 10:
                        Console.WriteLine("Dodaj novo podjetje");
                        Console.WriteLine("Vnesi naziv, panoga");
                        var n = Console.ReadLine();
                        var pan = Console.ReadLine();

                        if(services.InsertNewPodjetje(n,pan, 2017) == 1)
                        {
                            Console.WriteLine("Uspešno dodano podjetje");
                        }

                        break;
                    case 11:
                        Console.WriteLine("Urejanje oseb");
                        Console.WriteLine("Vnesi ime in priimek osebe, ki jo želiš urejati. Vnesi novo ime, priimek in leto");
                        var osI = Console.ReadLine();
                        var osP = Console.ReadLine();
                        var newI = Console.ReadLine();
                        var newP = Console.ReadLine();
                        var newLeto = int.Parse(Console.ReadLine());

                        if (services.UpdateOsebe(osI, osP, newI, newP, newLeto) == 1)
                            Console.WriteLine("Uspešno urejanje osebe");

                        break;
                    case 12:
                        Console.WriteLine("Urejanje podjetij");
                        Console.WriteLine("Vnesi naziv podjeja, ki ga želiš urejati. Vnesi novo ime, panoga in leto");
                        var pN = Console.ReadLine();
                        var nn = Console.ReadLine();
                        var newN = Console.ReadLine();
                        var newL = int.Parse(Console.ReadLine());

                        if (services.UpdatePodjetje(pN,nn, newN, newL) == 1)
                            Console.WriteLine("Uspešno urejanje podjatja");

                        break;
                    case 13:
                        Console.WriteLine("Dodaj osebo v podjetje");
                        Console.WriteLine("Vnesi ime, priimek osebe.  Naziv podjetja, delovno mesto in leto do");
                        var ii = Console.ReadLine();
                        var pp = Console.ReadLine();
                        var nazivP = Console.ReadLine();
                        var de = Console.ReadLine();
                        var lDo = int.Parse(Console.ReadLine());

                        if(services.AddOsebaVPodjetje(ii,pp,nazivP,de,lDo) == 1)
                        {
                            Console.WriteLine("oseba uspešno dodana v podjetje");
                        }

                        break;
                    case 14:
                        Console.WriteLine("Odstrani osebo iz podjetja");
                        Console.WriteLine("Vnesi ime, priimek in naziv podjetja");
                        var iii = Console.ReadLine();
                        var ppp = Console.ReadLine();
                        var pod = Console.ReadLine();

                        if (services.RemoveOsebeIzPodjetja(iii, ppp, pod) == 1)
                            Console.WriteLine("Uspešno odstranjena oseba v podjetaj");
                        break;

                    case 0:
                        loop = false;
                        break;
                }



            }
            
            
        }
        
    }
}
