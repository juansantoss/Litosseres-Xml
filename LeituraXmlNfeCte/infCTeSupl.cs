using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infCTeSupl
    {
        [XmlElement("qrCodCTe")]
        public string qrCodCTe { get; set; }
    }
}