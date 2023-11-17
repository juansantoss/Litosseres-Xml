using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Dest
    {
        [XmlElement("CNPJ")]
        public string Cnpj { get; set; }
        [XmlElement("IE")]
        public string IE { get; set; }
        [XmlElement("xNome")]
        public string XNome { get; set; }
        [XmlElement("fone")]
        public string Fone { get; set; }
        [XmlElement("enderDest")]
        public EnderDest EnderDest { get; set; }
    }
}