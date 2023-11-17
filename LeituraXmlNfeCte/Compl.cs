using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Compl
    {
        [XmlElement("Entrega")]
        public Entrega Entrega { get; set; }
        [XmlElement("origCalc")]
        public string OrigCalc { get; set; }
        [XmlElement("destCalc")]
        public string DestCalc { get; set; }
        [XmlElement("xObs")]
        public string XObs { get; set; }
        [XmlElement("ObsCont")]
        public ObsCont ObsCont { get; set; }
    }
}