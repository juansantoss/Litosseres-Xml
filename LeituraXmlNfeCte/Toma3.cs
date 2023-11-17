using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Toma3
    {
        [XmlElement("toma")]
        public string Toma { get; set; }
    }
}