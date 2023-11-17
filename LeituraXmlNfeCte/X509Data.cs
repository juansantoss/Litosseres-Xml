using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class X509Data
    {
        [XmlElement("X509Certificate")]
        public string X509Certificate { get; set; }
    }
}