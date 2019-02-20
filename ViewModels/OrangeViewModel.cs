using MultipleViews.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultipleViews.ViewModels
{
    public class OrangeViewModel
    {
        public PlantCollection PlantCol { get; set; }

        public OrangeViewModel()
        {
            PlantCol = ReadJsonFile();
        }

        /// <summary>
        /// read xml
        /// </summary>
        public void ReadXml(string file)
        {
            List<String> names = new List<String>();

            var xml = File.ReadAllText(file);
            var parsed = XElement.Parse(xml);
            var employee = parsed.Elements(XName.Get("Mitarbeiter"));
            var ordered = employee.OrderBy(i => i.Element("Nachname")?.Value ?? string.Empty);

            foreach (var o in ordered)
            {
                names.Add(o.Element("Nachname")?.Value + ", " + o.Element("Vorname"));
            }
        }

        /// <summary>
        /// read json
        /// </summary>
        public void ReadJsonWeb()
        {
            // web
            using (var webClient = new WebClient())
            {
                // get a String representation of our json
                String rawJSON = webClient.DownloadString("http://plantplaces.com/perl/mobile/viewplantsjson.pl?Combined_Name=Redbud");
                // convert the JSON string to a series of objects
                PlantCollection plantCollection = JsonConvert.DeserializeObject<PlantCollection>(rawJSON);
                // Do some computation
                Console.WriteLine(plantCollection.Plants.Count);
            }   
        }

        /// <summary>
        /// read json
        /// </summary>
        public PlantCollection ReadJsonFile()
        {
            using (StreamReader r = new StreamReader(@"Data\plants.json"))
            {
                string rawJSON = r.ReadToEnd();
                PlantCollection plantCollection = JsonConvert.DeserializeObject<PlantCollection>(rawJSON);
                return plantCollection;
            }
        }
    }
}
