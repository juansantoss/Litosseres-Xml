using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infDoc
    {
        [XmlElement("infNFe")]
        public infNFe infNFe {get;set;}
    }
}