using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Reference
    {
        [XmlElement("Transforms")]
        public Transforms Transforms { get; set; }
        [XmlElement("DigestMethod")]
        public string DigestMethod { get; set; }
        [XmlElement("DigestValue")]
        public string DigestValue { get; set; }
    }
}