using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;
using LeituraXmlNfeCte;

try
{
    string connectionString = "Server=DESKTOP-8HL9C64\\NASASCHOOL; Database=DB_SistemStudent;User Id=sa ; Password= Harando@30194110;";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();

        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        string xmlFilePath = Path.Combine(path, "0058582928_60409075012088_001170066_001_cte.xml");
        //0058582928_60409075012088_001170066_001_cte
        //2_175786459_MIDAS_0059135497_00657565000146_000071578_009

        XmlSerializer serializer = new XmlSerializer(typeof(CteProc));

        CteProc xml;



        using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
        {
            xml = (CteProc)serializer.Deserialize(fileStream);

            Console.WriteLine("Xml lido com sucesso, segue principais informações:\n");
            Console.WriteLine($"Chave: {xml.protCTe.infProt.chCTe}");
            Console.WriteLine($"Numero do documento: {xml.CTe.InfCte.Ide.CCt}");
            Console.WriteLine($"Data de chegada {xml.CTe.InfCte.Compl.Entrega.ComData.DProg}");
            //Console.WriteLine($"Certificado: {xml.CTe.Signature.SignatureValue}");
        }
        string insertCommand = "INSERT INTO InformacoesDadosDeCTe (cUF,cCT,CFOP,natOp,mod,serie,nCT,dhEmi,tpImp,tpEmis,cDV,tpAmb,tpCTe,procEmi,verProc,cMunEnv,xMunEnv,UFEnv,modal,tpServ,cMunIni,xMunIni,UFIni,cMunFim,xMunFim,UFFim,retira,indIEToma,toma,tpPer,dProg,tpHor,origCalc,destCalc,xObs,xTexto,CNPJ_Emitente,IE_Emitente,xNome_Emitente,xFant_Emitente,xLgr_Emitente,nro_Emitente,xBairro_Emitente,cMun_Emitente,xMun_Emitente,CEP_Emitente,UF_Emitente,fone_Emitente,CNPJ_Remetente,IE_Remetente,xNome_Remetente,xFant_Remetente,fone_Remetente,xLgr_Remetente,nro_Remetente,xBairro_Remetente,cMun_Remetente,xMun_Remetente,CEP_Remetente,UF_Remetente,cPais_Remetente,xPais_Remetente,CNPJ_Destinatario,IE_Destinatario,xNome_Destinatario,fone_Destinatario,xLgr_Destinatario,nro_Destinatario,xBairro_Destinatario,cMun_Destinatario,xMun_Destinatario,CEP_Destinatario,UF_Destinatario,cPais_Destinatario,xPais_Destinatario,vTPrest,vRec,xNome_Comp1,vComp1,xNome_Comp2,vComp2,CST_ICMS,vBCSTRet,vICMSSTRet,pICMSSTRet,infAdFisco,vCarga,proPred,cUnid,tpMed,qCarga,vCargaAverb,chave,RNTRC,CNPJ_Autorizado,CNPJ_ResponsavelTec,xContato,email,fone_ResponsavelTec,qrCodCTe,SignatureValue,tpAmb_Proto,verAplic_Proto,chCTe_Proto,dhRecbto_Proto,nProt_Proto,digVal_Proto,cStat_Proto,xMotivo_Proto) " +
                                             "VALUES (@cUF,@cCT,@CFOP,@natOp,@mod,@serie,@nCT,@dhEmi,@tpImp,@tpEmis,@cDV,@tpAmb,@tpCTe,@procEmi,@verProc,@cMunEnv,@xMunEnv,@UFEnv,@modal,@tpServ,@cMunIni,@xMunIni,@UFIni,@cMunFim,@xMunFim,@UFFim,@retira,@indIEToma,@toma,@tpPer,@dProg,@tpHor,@origCalc,@destCalc,@xObs,@xTexto,@CNPJ_Emitente,@IE_Emitente,@xNome_Emitente,@xFant_Emitente,@xLgr_Emitente,@nro_Emitente,@xBairro_Emitente,@cMun_Emitente,@xMun_Emitente,@CEP_Emitente,@UF_Emitente,@fone_Emitente,@CNPJ_Remetente,@IE_Remetente,@xNome_Remetente,@xFant_Remetente,@fone_Remetente,@xLgr_Remetente,@nro_Remetente,@xBairro_Remetente,@cMun_Remetente,@xMun_Remetente,@CEP_Remetente,@UF_Remetente,@cPais_Remetente,@xPais_Remetente,@CNPJ_Destinatario,@IE_Destinatario,@xNome_Destinatario,@fone_Destinatario,@xLgr_Destinatario,@nro_Destinatario,@xBairro_Destinatario,@cMun_Destinatario,@xMun_Destinatario,@CEP_Destinatario,@UF_Destinatario,@cPais_Destinatario,@xPais_Destinatario,@vTPrest,@vRec,@xNome_Comp1,@vComp1,@xNome_Comp2,@vComp2,@CST_ICMS,@vBCSTRet,@vICMSSTRet,@pICMSSTRet,@infAdFisco,@vCarga,@proPred,@cUnid,@tpMed,@qCarga,@vCargaAverb,@chave,@RNTRC,@CNPJ_Autorizado,@CNPJ_ResponsavelTec,@xContato,@email,@fone_ResponsavelTec,@qrCodCTe,@SignatureValue,@tpAmb_Proto,@verAplic_Proto,@chCTe_Proto,@dhRecbto_Proto,@nProt_Proto,@digVal_Proto,@cStat_Proto,@xMotivo_Proto)";
        using (SqlCommand command = new SqlCommand(insertCommand, connection))
        {
            command.Parameters.AddWithValue("@cUF", xml.CTe.InfCte.Ide.CUf);
            command.Parameters.AddWithValue("@cCT", xml.CTe.InfCte.Ide.CCt);
            command.Parameters.AddWithValue("@CFOP", xml.CTe.InfCte.Ide.CFOP);
            command.Parameters.AddWithValue("@natOp", xml.CTe.InfCte.Ide.NatOp);
            command.Parameters.AddWithValue("@mod", xml.CTe.InfCte.Ide.Mod);
            command.Parameters.AddWithValue("@serie", xml.CTe.InfCte.Ide.Serie);
            command.Parameters.AddWithValue("@nCT", xml.CTe.InfCte.Ide.NCt);
            command.Parameters.AddWithValue("@dhEmi", xml.CTe.InfCte.Ide.DhEmi);
            command.Parameters.AddWithValue("@tpImp", xml.CTe.InfCte.Ide.TpImp);
            command.Parameters.AddWithValue("@tpEmis", xml.CTe.InfCte.Ide.TpEmis);
            command.Parameters.AddWithValue("@cDV", xml.CTe.InfCte.Ide.CDv);
            command.Parameters.AddWithValue("@tpAmb", xml.CTe.InfCte.Ide.TpAmb);
            command.Parameters.AddWithValue("@tpCTe", xml.CTe.InfCte.Ide.TpCte);
            command.Parameters.AddWithValue("@procEmi", xml.CTe.InfCte.Ide.ProcEmi);
            command.Parameters.AddWithValue("@verProc", xml.CTe.InfCte.Ide.VerProc);
            command.Parameters.AddWithValue("@cMunEnv", xml.CTe.InfCte.Ide.CMunEnv);
            command.Parameters.AddWithValue("@xMunEnv", xml.CTe.InfCte.Ide.XMunEnv);
            command.Parameters.AddWithValue("@UFEnv", xml.CTe.InfCte.Ide.UFEnv);
            command.Parameters.AddWithValue("@modal", xml.CTe.InfCte.Ide.Modal);
            command.Parameters.AddWithValue("@tpServ", xml.CTe.InfCte.Ide.TpServ);
            command.Parameters.AddWithValue("@cMunIni", xml.CTe.InfCte.Ide.CMunIni);
            command.Parameters.AddWithValue("@xMunIni", xml.CTe.InfCte.Ide.XMunIni);
            command.Parameters.AddWithValue("@UFIni", xml.CTe.InfCte.Ide.UFIni);
            command.Parameters.AddWithValue("@cMunFim", xml.CTe.InfCte.Ide.CMunFim);
            command.Parameters.AddWithValue("@xMunFim", xml.CTe.InfCte.Ide.XMunFim);
            command.Parameters.AddWithValue("@UFFim", xml.CTe.InfCte.Ide.UFFim);
            command.Parameters.AddWithValue("@retira", xml.CTe.InfCte.Ide.Retira);
            command.Parameters.AddWithValue("@indIEToma", xml.CTe.InfCte.Ide.DescricaoIndIEToma);
            command.Parameters.AddWithValue("@toma", xml.CTe.InfCte.Ide.Toma3.Toma);
            command.Parameters.AddWithValue("@tpPer", xml.CTe.InfCte.Compl.Entrega.ComData.Tper);
            command.Parameters.AddWithValue("@dProg", xml.CTe.InfCte.Compl.Entrega.ComData.DProg);
            command.Parameters.AddWithValue("@tpHor", xml.CTe.InfCte.Compl.Entrega.SemHora.TpHor);
            command.Parameters.AddWithValue("@origCalc", xml.CTe.InfCte.Compl.OrigCalc);
            command.Parameters.AddWithValue("@destCalc", xml.CTe.InfCte.Compl.DestCalc);
            command.Parameters.AddWithValue("@xObs", xml.CTe.InfCte.Compl.XObs);
            command.Parameters.AddWithValue("@xTexto", xml.CTe.InfCte.Compl.ObsCont.XTexto);
            command.Parameters.AddWithValue("@CNPJ_Emitente", xml.CTe.InfCte.Emit.CNPJ);
            command.Parameters.AddWithValue("@IE_Emitente", xml.CTe.InfCte.Emit.IE);
            command.Parameters.AddWithValue("@xNome_Emitente", xml.CTe.InfCte.Emit.XNome);
            command.Parameters.AddWithValue("@xFant_Emitente", xml.CTe.InfCte.Emit.XFante);
            command.Parameters.AddWithValue("@xLgr_Emitente", xml.CTe.InfCte.Emit.EnderEmit.XLgr);
            command.Parameters.AddWithValue("@nro_Emitente", xml.CTe.InfCte.Emit.EnderEmit.Nro);
            command.Parameters.AddWithValue("@xBairro_Emitente", xml.CTe.InfCte.Emit.EnderEmit.XBairro);
            command.Parameters.AddWithValue("@cMun_Emitente", xml.CTe.InfCte.Emit.EnderEmit.CMun);
            command.Parameters.AddWithValue("@xMun_Emitente", xml.CTe.InfCte.Emit.EnderEmit.XMun);
            command.Parameters.AddWithValue("@CEP_Emitente", xml.CTe.InfCte.Emit.EnderEmit.Cep);
            command.Parameters.AddWithValue("@UF_Emitente", xml.CTe.InfCte.Emit.EnderEmit.UF);
            command.Parameters.AddWithValue("@fone_Emitente", xml.CTe.InfCte.Emit.EnderEmit.Fone);
            command.Parameters.AddWithValue("@CNPJ_Remetente", xml.CTe.InfCte.Rem.Cnpj);
            command.Parameters.AddWithValue("@IE_Remetente", xml.CTe.InfCte.Rem.IE);
            command.Parameters.AddWithValue("@xNome_Remetente", xml.CTe.InfCte.Rem.XNome);
            command.Parameters.AddWithValue("@xFant_Remetente", xml.CTe.InfCte.Rem.XFante);
            command.Parameters.AddWithValue("@fone_Remetente", xml.CTe.InfCte.Rem.Fone);
            command.Parameters.AddWithValue("@xLgr_Remetente", xml.CTe.InfCte.Rem.EnderReme.XLgr);
            command.Parameters.AddWithValue("@nro_Remetente", xml.CTe.InfCte.Rem.EnderReme.Nro);
            command.Parameters.AddWithValue("@xBairro_Remetente", xml.CTe.InfCte.Rem.EnderReme.XBairro);
            command.Parameters.AddWithValue("@cMun_Remetente", xml.CTe.InfCte.Rem.EnderReme.CMun);
            command.Parameters.AddWithValue("@xMun_Remetente", xml.CTe.InfCte.Rem.EnderReme.XMun);
            command.Parameters.AddWithValue("@CEP_Remetente", xml.CTe.InfCte.Rem.EnderReme.Cep);
            command.Parameters.AddWithValue("@UF_Remetente", xml.CTe.InfCte.Rem.EnderReme.UF);
            command.Parameters.AddWithValue("@cPais_Remetente", xml.CTe.InfCte.Rem.EnderReme.CPais);
            command.Parameters.AddWithValue("@xPais_Remetente", xml.CTe.InfCte.Rem.EnderReme.XPais);
            command.Parameters.AddWithValue("@CNPJ_Destinatario", xml.CTe.InfCte.Dest.Cnpj);
            command.Parameters.AddWithValue("@IE_Destinatario", xml.CTe.InfCte.Dest.IE);
            command.Parameters.AddWithValue("@xNome_Destinatario", xml.CTe.InfCte.Dest.XNome);
            command.Parameters.AddWithValue("@fone_Destinatario", xml.CTe.InfCte.Dest.Fone);
            command.Parameters.AddWithValue("@xLgr_Destinatario", xml.CTe.InfCte.Dest.EnderDest.xLgr);
            command.Parameters.AddWithValue("@nro_Destinatario", xml.CTe.InfCte.Dest.EnderDest.Nro);
            command.Parameters.AddWithValue("@xBairro_Destinatario", xml.CTe.InfCte.Dest.EnderDest.XBairro);
            command.Parameters.AddWithValue("@cMun_Destinatario", xml.CTe.InfCte.Dest.EnderDest.CMun);
            command.Parameters.AddWithValue("@xMun_Destinatario", xml.CTe.InfCte.Dest.EnderDest.XMun);
            command.Parameters.AddWithValue("@CEP_Destinatario", xml.CTe.InfCte.Dest.EnderDest.Cep);
            command.Parameters.AddWithValue("@UF_Destinatario", xml.CTe.InfCte.Dest.EnderDest.UF);
            command.Parameters.AddWithValue("@cPais_Destinatario", xml.CTe.InfCte.Dest.EnderDest.CPais);
            command.Parameters.AddWithValue("@xPais_Destinatario", xml.CTe.InfCte.Dest.EnderDest.XPais);
            command.Parameters.AddWithValue("@vTPrest", xml.CTe.InfCte.VPrest.vTPrest);
            command.Parameters.AddWithValue("@vRec", xml.CTe.InfCte.VPrest.vRec);
            command.Parameters.AddWithValue("@xNome_Comp1", xml.CTe.InfCte.VPrest.Comp.xNome);
            command.Parameters.AddWithValue("@vComp1", xml.CTe.InfCte.VPrest.Comp.VComp);
            command.Parameters.AddWithValue("@xNome_Comp2", xml.CTe.InfCte.VPrest.Comp.xNome);
            command.Parameters.AddWithValue("@vComp2", xml.CTe.InfCte.VPrest.Comp.VComp);
            command.Parameters.AddWithValue("@CST_ICMS", xml.CTe.InfCte.Imp.ICMS.ICMS60.CST);
            command.Parameters.AddWithValue("@vBCSTRet", xml.CTe.InfCte.Imp.ICMS.ICMS60.vBCSTRet);
            command.Parameters.AddWithValue("@vICMSSTRet", xml.CTe.InfCte.Imp.ICMS.ICMS60.vICMSSTRet);
            command.Parameters.AddWithValue("@pICMSSTRet", xml.CTe.InfCte.Imp.ICMS.ICMS60.pICMSSTRet);
            command.Parameters.AddWithValue("@infAdFisco", xml.CTe.InfCte.Imp.infAdFisco);
            command.Parameters.AddWithValue("@vCarga", xml.CTe.InfCte.infCTeNorm.infCarga.vCarga);
            command.Parameters.AddWithValue("@proPred", xml.CTe.InfCte.infCTeNorm.infCarga.proPred);
            command.Parameters.AddWithValue("@cUnid", xml.CTe.InfCte.infCTeNorm.infCarga.infQ.cUnid);
            command.Parameters.AddWithValue("@tpMed", xml.CTe.InfCte.infCTeNorm.infCarga.infQ.tpMed);
            command.Parameters.AddWithValue("@qCarga", xml.CTe.InfCte.infCTeNorm.infCarga.infQ.qCarga);
            command.Parameters.AddWithValue("@vCargaAverb", xml.CTe.InfCte.infCTeNorm.infCarga.vCargaAverb);
            command.Parameters.AddWithValue("@chave", xml.CTe.InfCte.infCTeNorm.infDoc.infNFe.chave);
            command.Parameters.AddWithValue("@RNTRC", xml.CTe.InfCte.infCTeNorm.infModal.rodo.RNTRC);
            command.Parameters.AddWithValue("@CNPJ_Autorizado", xml.CTe.InfCte.autXML.CNPJ);
            command.Parameters.AddWithValue("@CNPJ_ResponsavelTec", xml.CTe.InfCte.infRespTec.CNPJ);
            command.Parameters.AddWithValue("@xContato", xml.CTe.InfCte.infRespTec.xContato);
            command.Parameters.AddWithValue("@email", xml.CTe.InfCte.infRespTec.email);
            command.Parameters.AddWithValue("@fone_ResponsavelTec", xml.CTe.InfCte.infRespTec.fone);
            command.Parameters.AddWithValue("@qrCodCTe", xml.CTe.infCTeSupl.qrCodCTe);
            command.Parameters.AddWithValue("@SignatureValue", xml.CTe.Signature.SignatureValue);
            command.Parameters.AddWithValue("@tpAmb_Proto", xml.protCTe.infProt.tpAmb);
            command.Parameters.AddWithValue("@verAplic_Proto", xml.protCTe.infProt.verAplic);
            command.Parameters.AddWithValue("@chCTe_Proto", xml.protCTe.infProt.chCTe);
            command.Parameters.AddWithValue("@dhRecbto_Proto", xml.protCTe.infProt.dhRecbto);
            command.Parameters.AddWithValue("@nProt_Proto", xml.protCTe.infProt.nProt);
            command.Parameters.AddWithValue("@digVal_Proto", xml.protCTe.infProt.digVal);
            command.Parameters.AddWithValue("@cStat_Proto", xml.protCTe.infProt.cStat);
            command.Parameters.AddWithValue("@xMotivo_Proto", xml.protCTe.infProt.xMotivo);

            command.ExecuteNonQuery();
            Console.WriteLine("\nXml salvo com sucesso no Banco de Dados!");
        }
        connection.Close();
    }
}

catch (SqlException ex)
{
    for (int i = 0; i < ex.Errors.Count; i++)
    {
        Console.WriteLine("Erro " + i + " - Message: " + ex.Errors[i].Message);
    }
}