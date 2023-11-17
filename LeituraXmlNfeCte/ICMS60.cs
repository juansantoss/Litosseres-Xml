using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class ICMS60
    {
        [XmlElement("CST")]
        public string CST { get; set; }
        [XmlElement("vBCSTRet")]
        public string vBCSTRet { get; set; }
        [XmlElement("vICMSSTRet")]
        public string vICMSSTRet { get; set; }
        [XmlElement("pICMSSTRet")]
        public string pICMSSTRet { get; set; }
    }
}