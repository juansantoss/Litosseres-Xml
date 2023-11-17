using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Entrega
    {
        [XmlElement("comData")]
        public ComData ComData { get; set; }
        [XmlElement("semHora")]
        public SemHora SemHora { get; set; }
    }
}