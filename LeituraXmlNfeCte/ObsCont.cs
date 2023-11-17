using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class ObsCont
    {
        [XmlElement("xTexto")]
        public string XTexto { get; set; }
    }
}