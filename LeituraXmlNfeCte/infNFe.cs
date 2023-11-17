using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infNFe
    {
        [XmlElement("chave")]
        public string chave { get; set; }
    }
}