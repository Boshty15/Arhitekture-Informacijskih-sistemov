using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Naloga1
{
    class Podatki
    {
        public string znak { get; set; }
        public double a { get; set; }
        public double b { get; set; }


        public static string Serialize(Podatki dto)
        {
            //Add an empty namespace and empty value
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlSerializer ser = new XmlSerializer(typeof(Podatki));
            using (StringWriter textWriter = new StringWriter())
            {
                ser.Serialize(textWriter, dto, ns);
                return textWriter.ToString();
            }
        }

        public static Podatki Deserialize(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Podatki));
            using (var reader = new StringReader(xml))
            {
                return (Podatki)ser.Deserialize(reader);
            }
        }

    }
}
