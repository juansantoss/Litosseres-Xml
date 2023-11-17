using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Transforms
    {
        [XmlElement("Transform")]
        public string xTransform { get; set; }
    }
}