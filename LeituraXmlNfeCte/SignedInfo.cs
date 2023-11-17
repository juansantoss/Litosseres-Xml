using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class SignedInfo
    {
        [XmlElement("CanonicalizationMethod")]
        public string CanonicalizationMethod { get; set; }
        [XmlElement("SignatureMethod ")]
        public string SignatureMethod { get; set; }
        [XmlElement("Reference")]
        public Reference Reference { get; set; }
    }
}