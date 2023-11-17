using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infCarga
    {
        [XmlElement("vCarga")]
        public string vCarga { get; set; }
        [XmlElement("proPred")]
        public string proPred { get; set; }
        [XmlElement("infQ")]
        public infQ infQ { get; set; }
        [XmlElement("vCargaAverb")]
        public string vCargaAverb { get; set; }
    }
}