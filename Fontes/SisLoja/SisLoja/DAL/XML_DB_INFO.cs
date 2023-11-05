using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    public class XML_DB_INFO
    {
        public string Server { get; set;}
        public string User { get; set; }
        public string Pass { get; set; }


        public void save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(XML_DB_INFO));
                xml.Serialize(stream, this);
            }
        }

        public static XML_DB_INFO LoadFromFile(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(XML_DB_INFO));
                return (XML_DB_INFO)xml.Deserialize(stream);
            }
        }

    }
}
