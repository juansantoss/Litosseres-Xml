using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infQ
    {
        [XmlElement("cUnid")]
        public string cUnid { get; set; }
        [XmlElement ("tpMed")]
        public string tpMed { get; set; }
        [XmlElement("qCarga")]
        public string qCarga { get; set; }
    }
}