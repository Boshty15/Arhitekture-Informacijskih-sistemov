using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using Naloga1;

namespace Naloga1_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            StartServer();
        }

        static void StartServer()
        {
            double rezultat = 0;
            double a, b;
            string tmp;

            Console.WriteLine("Server");
            var server = new NamedPipeServerStream("PodatkiNaloga1");
            Console.WriteLine("Strežnik je pripravljen.");
            server.WaitForConnection();
            Console.WriteLine("Strežnik je povezan");
            
            StreamReader reader = new StreamReader(server);
            StreamWriter writer = new StreamWriter(server);

            while (server.IsConnected)
            {
                //Console.WriteLine("While zanka strezni connected.");
                var line = reader.ReadLine();
                if(line != null)
                {
                    
                    Console.WriteLine("Prejeti podatki {0}", line);
                    // writer.WriteLine(String.Join("", line.Reverse()));
                    switch (line)
                    {
                        case "+":
                            //Console.WriteLine("+");
                            // writer.WriteLine("+");
                            writer.WriteLine("Izbrali ste seštevanje, vnesite prvo število");
                            writer.Flush();
                           
                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out a)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out a))
                                    break;
                            }
                            a = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + a);

                            writer.WriteLine("Število sprejeto, vnesite drugo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out b)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out b))
                                    break;
                            }

                            b = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + b);
                            
                            rezultat = a + b;
                            writer.WriteLine( "Rezultat: " + rezultat);
                            Console.WriteLine("Rezultat: " + rezultat);
                            writer.Flush();

                            break;
                        case "-":
                            //Console.WriteLine("-");
                            // writer.WriteLine("-");
                            writer.WriteLine("Izbrali ste odštevanje, vnesite prvo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out a)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out a))
                                    break;
                            }
                            a = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + a);

                            writer.WriteLine("Število sprejeto, vnesite drugo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out b)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out b))
                                    break;
                            }

                            b = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + b);

                            rezultat = a - b;
                            writer.WriteLine("Rezultat: " + rezultat);
                            Console.WriteLine("Rezultat: " + rezultat);
                            writer.Flush();

                            break;
                        case "/":
                           // Console.WriteLine("/");
                            // writer.WriteLine("/");
                            writer.WriteLine("Izbrali ste deljenje, vnesite prvo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out a)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out a))
                                    break;
                            }
                            a = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + a);

                            writer.WriteLine("Število sprejeto, vnesite drugo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out b)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out b))
                                    break;
                            }

                            b = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + b);

                            rezultat = a / b;
                            writer.WriteLine("Rezultat: " + rezultat);
                            Console.WriteLine("Rezultat: " + rezultat);
                            writer.Flush();

                            break;
                        case "*":
                           // Console.WriteLine("*");
                            // writer.WriteLine("*");
                            writer.WriteLine("Izbrali ste množenje, vnesite prvo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out a)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out a))
                                    break;
                            }
                            a = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + a);

                            writer.WriteLine("Število sprejeto, vnesite drugo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out b)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out b))
                                    break;
                            }

                            b = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + b);

                            rezultat = a * b;
                            writer.WriteLine("Rezultat: " + rezultat);
                            Console.WriteLine("Rezultat: " + rezultat);
                            writer.Flush();

                            break;
                        case "%":
                            //Console.WriteLine("%");
                            // writer.WriteLine("%");
                            writer.WriteLine("Izbrali ste množenje, vnesite prvo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out a)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out a))
                                    break;
                            }
                            a = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + a);

                            writer.WriteLine("Število sprejeto, vnesite drugo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out b)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out b))
                                    break;
                            }

                            b = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + b);

                            rezultat = a % b;
                            writer.WriteLine("Rezultat: " + rezultat);
                            Console.WriteLine("Rezultat: " + rezultat);
                            writer.Flush();

                            break;
                        case ">":
                            //Console.WriteLine(">");
                            // writer.WriteLine(">");
                            writer.WriteLine("Izbrali ste večje, vnesite prvo število");
                            writer.Flush();
                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out a)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out a))
                                    break;
                            }
                            a = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + a);

                            writer.WriteLine("Število sprejeto, vnesite drugo število");
                            writer.Flush();

                            tmp = reader.ReadLine();
                            while (!(double.TryParse(tmp, out b)))
                            {
                                writer.WriteLine("Nepravilno število, vnesite število ponovno");
                                Console.WriteLine("Nepravilno število, vnesite število ponovno");
                                writer.Flush();

                                tmp = reader.ReadLine();
                                if (double.TryParse(tmp, out b))
                                    break;
                            }

                            b = double.Parse(tmp);
                            Console.WriteLine("Prvo število: " + b);

                            if (a > b)
                            {
                                writer.WriteLine("Rezultat: "  + a + " je večje od  " + b);
                                Console.WriteLine("Rezultat: " + a + " je večje od  " + b);
                                writer.Flush();
                            }
                            else
                            {
                                writer.WriteLine("Rezultat: " + a + " je manjše od  " + b);
                                Console.WriteLine("Rezultat: " + a + " je manjše od " + b);
                                writer.Flush();
                            }

                            break;
                        default:
                           // Console.WriteLine("Eror, Nepravilen vnos!");
                            writer.WriteLine("Error, Nepravilen vnos!");
                            writer.Flush();
                            break;
                    }
                   
                }
            }
            server.Close();
        }
    }
}
