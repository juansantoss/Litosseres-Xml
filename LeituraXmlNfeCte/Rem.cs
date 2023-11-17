﻿using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Rem
    {
        [XmlElement("CNPJ")]
        public string Cnpj { get; set; }
        [XmlElement("IE")]
        public string IE { get; set; }
        [XmlElement("xNome")]
        public string XNome { get; set; }
        [XmlElement("xFant")]
        public string XFante { get; set; }
        [XmlElement("fone")]
        public string Fone { get; set; }
        [XmlElement("enderReme")]
        public EnderReme EnderReme { get; set; }
    }
}