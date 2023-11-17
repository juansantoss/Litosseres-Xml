using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class autXML
    {
        [XmlElement("CNPJ")]
        public string CNPJ { get; set; }
    }
}