using System;
using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class ComData
    {
        [XmlElement("tpPer")]
        public string Tper { get; set; }
        [XmlElement("dProg")]
        public string DProg { get; set; }
    }
}