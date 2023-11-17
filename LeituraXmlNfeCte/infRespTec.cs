using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infRespTec
    {
        [XmlElement("CNPJ")]
        public string CNPJ { get; set; }
        [XmlElement("xContato")]
        public string xContato { get; set; }
        [XmlElement("email")]
        public string email { get; set; }
        [XmlElement("fone")]
        public string fone { get; set; }
    }
}