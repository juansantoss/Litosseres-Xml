using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class vPrest
    {
        [XmlElement("vTPrest")]
        public string vTPrest { get; set; }
        [XmlElement("vRec")]
        public string vRec { get; set; }
        [XmlElement("Comp")]
        public Comp Comp { get; set; }


    }
}