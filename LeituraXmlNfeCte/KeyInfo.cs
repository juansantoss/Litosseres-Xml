using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class KeyInfo
    {
        [XmlElement("X509Data")]
        public X509Data X509Data { get; set; }
    }
}