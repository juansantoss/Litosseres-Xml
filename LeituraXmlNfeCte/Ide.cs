using System;
using System.Xml.Serialization;

namespace LeituraXmlNfeCte
{
    public class Ide
    {
        [XmlElement("cUF")]
        public string CUf { get; set; }

        [XmlElement("cCT")]
        public string CCt { get; set; }
        [XmlElement("CFOP")]
        public string CFOP { get; set; }

        [XmlElement("natOp")]
        public string NatOp { get; set; }

        [XmlElement("mod")]
        public string Mod { get; set; }

        [XmlElement("serie")]
        public string Serie { get; set; }

        [XmlElement("nCT")]
        public string NCt { get; set; }

        [XmlElement("dhEmi")]
        public string DhEmi { get; set; }

        [XmlElement("tpImp")]
        public string TpImp { get; set; }

        [XmlElement("tpEmis")]
        public string TpEmis { get; set; }

        [XmlElement("cDV")]
        public string CDv { get; set; }

        [XmlElement("tpAmb")]
        public string TpAmb { get; set; }

        [XmlElement("tpCTe")]
        public string TpCte { get; set; }

        [XmlElement("procEmi")]
        public string ProcEmi { get; set; }

        [XmlElement("verProc")]
        public string VerProc { get; set; }

        [XmlElement("cMunEnv")]
        public string CMunEnv { get; set; }

        [XmlElement("xMunEnv")]
        public string XMunEnv { get; set; }

        [XmlElement("UFEnv")]
        public string UFEnv { get; set; }

        [XmlElement("modal")]
        public string Modal { get; set; }

        [XmlElement("tpServ")]
        public string TpServ { get; set; }

        [XmlElement("cMunIni")]
        public string CMunIni { get; set; }

        [XmlElement("xMunIni")]
        public string XMunIni { get; set; }

        [XmlElement("UFIni")]
        public string UFIni { get; set; }

        [XmlElement("cMunFim")]
        public string CMunFim { get; set; }

        [XmlElement("xMunFim")]
        public string XMunFim { get; set; }

        [XmlElement("UFFim")]
        public string UFFim { get; set; }

        [XmlElement("retira")]
        public string Retira { get; set; }

        [XmlElement("indIEToma")]
        public string IndIEToma { get; set; }
        [XmlElement("toma3")]
        public Toma3 Toma3 { get; set; }
        public string DescricaoIndIEToma
        {
            get
            {
                // Lógica para traduzir o valor de IndIEToma para a string desejada
                switch (IndIEToma)
                {
                    case "0":
                        return "Frete pago pelo emitente";
                    case "1":
                        return "Frete pago pelo destinatário";
                    default:
                        // Retornar um valor padrão ou tratar outros casos conforme necessário
                        return "Descrição não disponível";
                }
            }
        }
    }
}