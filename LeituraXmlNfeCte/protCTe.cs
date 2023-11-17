using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class protCTe
    {
        [XmlElement("infProt")]
        public infProt infProt { get; set; }
    }
}