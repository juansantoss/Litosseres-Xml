using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infModal
    {
        [XmlElement("rodo")]
        public rodo rodo { get; set; }
    }
}