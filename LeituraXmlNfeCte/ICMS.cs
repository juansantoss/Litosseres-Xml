using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class ICMS
    {
        [XmlElement("ICMS60")]
        public ICMS60 ICMS60 { get; set; }
    }
}