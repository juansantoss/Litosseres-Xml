using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class EnderEmit
    {
        [XmlElement("xLgr")]
        public string XLgr { get; set; }
        [XmlElement("nro")]
        public string Nro { get; set; }
        [XmlElement("xBairro")]
        public string XBairro { get; set; }
        [XmlElement("cMun")]
        public string CMun { get; set; }
        [XmlElement("xMun")]
        public string XMun { get; set; }
        [XmlElement("CEP")]
        public string Cep { get; set; }
        [XmlElement("UF")]
        public string UF { get; set; }
        [XmlElement("fone")]
        public string Fone { get; set; }
    }
}