using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class InfCte
    {
        [XmlElement("ide")]
        public Ide Ide { get; set; }

        [XmlElement("compl")]
        public Compl Compl { get; set; }
        [XmlElement("emit")]
        public Emit Emit { get; set; }
        [XmlElement("rem")]
        public Rem Rem { get; set; }
        [XmlElement("dest")]
        public Dest Dest { get; set; }
        [XmlElement("vPrest")]
        public vPrest VPrest { get; set; }
        [XmlElement("imp")]
        public Imp Imp { get; set; }
        [XmlElement("infCTeNorm")]
        public infCTeNorm infCTeNorm { get; set; }
        [XmlElement("autXML")]
        public autXML autXML { get; set; }
        [XmlElement("infRespTec")]
        public infRespTec infRespTec { get; set; }
    }
}