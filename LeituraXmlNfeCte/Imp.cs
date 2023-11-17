using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Imp
    {
        [XmlElement("ICMS")]
        public ICMS ICMS { get; set; }
        [XmlElement("infAdFisco")]
        public string infAdFisco { get; set; }
    }
}