using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace Naloga1
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");
            var client = new NamedPipeClientStream("PodatkiNaloga1");
            client.Connect();
            Console.WriteLine("Povezan s strežnikom.");
            Console.WriteLine("Pošlji prazno vrstico za konec");
            StreamReader reader = new StreamReader(client);
            StreamWriter writer = new StreamWriter(client);
            Console.WriteLine("Pošlji operacijo, ki jo želiš izvesti, za konec pošlji prazno vrstico.");

            string input = "testni podatki";
            while (input != "")
            {
                
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input)) break;
                writer.WriteLine(input);
                writer.Flush();
                Console.WriteLine(reader.ReadLine());
                
            }
            //Console.ReadKey();
        }
    }
}
