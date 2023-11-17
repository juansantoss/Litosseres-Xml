using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infProt
    {
        [XmlElement("tpAmb")]
        public string tpAmb { get; set; }
        [XmlElement("verAplic")]
        public string verAplic { get; set; }
        [XmlElement("chCTe")]
        public string chCTe { get; set; }
        [XmlElement("dhRecbto")]
        public string dhRecbto { get; set; }
        [XmlElement("nProt")]
        public string nProt { get; set; }
        [XmlElement("digVal")]
        public string digVal { get; set; }
        [XmlElement("cStat")]
        public string cStat { get; set; }
        [XmlElement("xMotivo")]
        public string xMotivo { get; set; }
    }
}