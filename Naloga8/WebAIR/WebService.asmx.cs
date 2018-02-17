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
        private double PretvoriFeetToMeters(double feet)
        {
            double rez = 0.0;
            LengthUnit.lengthUnit pretvorba = new LengthUnit.lengthUnit();
            rez = pretvorba.ChangeLengthUnit(feet, LengthUnit.Lengths.Feet, LengthUnit.Lengths.Meters);
            return Math.Round(rez, 3);
        }
        [WebMethod]
        public string GetLetalisceByCode(string code)
        {
            Letalisce l = new Letalisce();

            AirportCode.airport letalisce = new AirportCode.airport();
            string returnInformation = letalisce.getAirportInformationByAirportCode(code);
            string[] tmp = returnInformation.Split('\n');

            for (int j = 2; j < tmp.Length / 2; j++)
            {
                if (tmp[j].Contains("City"))
                {
                    string[] splitFront = tmp[j].Split('>');
                    string[] splitBack = splitFront[1].Split('<');
                    l.City = splitBack[0];
                }

                if (tmp[j].Contains("<AirportCode>"))
                {
                    string[] splitFront = tmp[j].Split('>');
                    string[] splitBack = splitFront[1].Split('<');
                    l.Code = splitBack[0];
                }
                if (tmp[j].Contains("<Country>"))
                {
                    string[] splitFront = tmp[j].Split('>');
                    string[] splitBack = splitFront[1].Split('<');
                    l.Country = splitBack[0];
                }
                if (tmp[j].Contains("Elevation"))
                {
                    string[] splitFront = tmp[j].Split('>');
                    string[] splitBack = splitFront[1].Split('<');
                    l.NadmorskaVisina = PretvoriFeetToMeters(double.Parse(splitBack[0]));
                }
                if (tmp[j].Contains("Length"))
                {
                    string[] splitFront = tmp[j].Split('>');
                    string[] splitBack = splitFront[1].Split('<');
                    l.DolzinaLSteze = PretvoriFeetToMeters(double.Parse(splitBack[0]));
                }
            }
            string replace = l.City.Replace(" ", "+");
            l.Map = "https://www.google.com/maps/embed/v1/place?key=AIzaSyBwcDEFxj32ZcrkGrruGzuQOTNHwBrjOWc" + "&q=" + l.Code + "+" + replace;
            
            l.Opis = "Država, v kateri se nahaja letališče, je " + l.Country + ", v mestu " + l.City + ", s kodo letališča " + l.Code + ". Dolžina pristajalne steze je " + l.DolzinaLSteze + " metrov in nadmorska višina " + l.NadmorskaVisina + " metrov.";


             XmlSerializer serialize = new XmlSerializer(typeof(Letalisce));

             using (StringWriter writer = new StringWriter())
             {
                 serialize.Serialize(writer, l);
                 return writer.ToString();
             }
        }
        
        [WebMethod]
        public List<string> GetLeltalisceDrzava(string drzava)
        {
            List<string> list = new List<string>();
            AirportCode.airport let = new AirportCode.airport();
            string podatki = let.GetAirportInformationByCountry(drzava);
            string[] tmp = podatki.Split();
            for(int i = 2; i< tmp.Length; i++)
            {
                if (tmp[i].Contains("<AirportCode>"))
                {
                    string[] splitFront = tmp[i].Split('>');
                    string[] splitBack = splitFront[1].Split('<');
                    list.Add(splitBack[0]);
                }
            }
            //list.RemoveAt(0);
            
            for(int i = 0; i < list.Count;i += 2)
            {
                list.RemoveAt(i);
            }
            int tmp2 = list.Count - 1;
            list.RemoveAt(tmp2);
            return list;
        }
    }
}
