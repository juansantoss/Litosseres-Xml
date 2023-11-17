using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    [XmlRoot(ElementName = "cteProc", Namespace = "http://www.portalfiscal.inf.br/cte")]
    public class CteProc
    {
        [XmlElement(ElementName = "CTe", Namespace = "http://www.portalfiscal.inf.br/cte")]
        public CTe CTe { get; set; }
        [XmlElement("protCTe")]
        public protCTe protCTe { get; set; }
    }
}
