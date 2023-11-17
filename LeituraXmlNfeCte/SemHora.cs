using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class SemHora
    {
        [XmlElement("tpHor")]
        public string TpHor { get; set; }
    }
}