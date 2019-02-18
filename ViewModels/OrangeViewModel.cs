using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultipleViews.ViewModels
{
    public class OrangeViewModel
    {
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
        public void ReadJson()
        {

        }
    }
}
