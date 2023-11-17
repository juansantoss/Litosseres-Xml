using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class rodo
    {
        [XmlElement("RNTRC")]
        public string RNTRC { get; set; }
    }
}