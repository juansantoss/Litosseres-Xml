using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class CTe
    {
        [XmlElement("infCte")]
        public InfCte InfCte { get; set; }
        [XmlElement("infCTeSupl")]
        public infCTeSupl infCTeSupl { get; set; }
        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature { get; set; }
    }
}