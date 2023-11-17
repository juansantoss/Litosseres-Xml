using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Comp
    {
        [XmlElement("xNome")]
        public string xNome { get; set; }
        [XmlElement("vComp")]
        public string VComp { get; set; }
    }
}