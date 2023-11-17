using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Emit
    {
        [XmlElement("CNPJ")]
        public string CNPJ { get; set; }
        [XmlElement("IE")]
        public string IE { get; set; }
        [XmlElement("xNome")]
        public string XNome { get; set; }
        [XmlElement("xFant")]
        public string XFante { get; set; }
        [XmlElement("enderEmit")]
        public EnderEmit EnderEmit { get; set; }
    }
}