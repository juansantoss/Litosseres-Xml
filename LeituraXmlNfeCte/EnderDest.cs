using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class EnderDest
    {
        [XmlElement("xLgr")]
        public string xLgr { get; set; }
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
        [XmlElement("cPais")]
        public string CPais { get; set; }
        [XmlElement("xPais")]
        public string XPais { get; set; }
    }
}