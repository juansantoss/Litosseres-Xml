using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Signature
    {
        [XmlElement("SignedInfo")]
        public SignedInfo SignedInfo { get; set; }
        [XmlElement("SignatureValue")]
        public string SignatureValue { get; set; }
        [XmlElement("KeyInfo")]
        public KeyInfo KeyInfo { get; set; }
    }
}