using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class infCTeNorm
    {
        [XmlElement("infCarga")]
        public infCarga infCarga { get; set; }
        [XmlElement("infDoc")]
        public infDoc infDoc { get; set; }
        [XmlElement("infModal")]
        public infModal infModal { get; set; }
    }
}