using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.Adapters;
using Erp.Proxy.BO;
using Erp.BO;
using Ice.Core;
using Erp.UI.App.QuoteEntry;
using Ice.Lib.Framework;

namespace QuoteEntry.BO
{
    public class QuoteHed
    {
        ILaunch iLaunch;
        Transaction oTrans;
        Session sesProv;
        
        public QuoteHed                     (Ice.Core.Session sess)
        {

            iLaunch = new ILauncher(sess);
            oTrans = new Transaction(iLaunch);
        }

        public void QuoteDtl                (int QuoteNum,MetroFramework.Controls.MetroGrid mgProductos, ref string Error)
        {
            try
            {
                QuoteAdapter qad = new QuoteAdapter(oTrans); qad.BOConnect();
                QuoteImpl aQuote = qad.BusinessObject as QuoteImpl;
                QuoteDataSet dQuote = new QuoteDataSet();
                if (mgProductos.Rows.Count - 1 >= 0)
                {
                    for (int i = 0; i <= mgProductos.Rows.Count - 1; i++)
                    {
                        string PartNum = mgProductos.Rows[i].Cells["Id Parte"].Value.ToString();
                        dQuote = aQuote.GetByID(QuoteNum);
                        aQuote.GetNewQuoteDtl(dQuote, QuoteNum);
                        Guid SysRow = new Guid("00000000-0000-0000-0000-000000000000");
                        var qh = (QuoteDataSet.QuoteDtlRow)dQuote.QuoteDtl.Rows[(dQuote.QuoteDtl.Rows.Count - 1)];
                        qh.PartNum = PartNum;
                        qh.SysRowID = SysRow;


                        bool[] refbool = new bool[11];string[] refstring = new string[9];
                        aQuote.ChangePartNumMaster(ref PartNum, ref refbool[0], ref refbool[1], ref refstring[0], "", SysRow, false, false, false, true, out refstring[2], out refstring[3], out refstring[4], out refbool[2], out refstring[5], true, true, out refstring[6], out refbool[3], out refbool[4], out refstring[7], dQuote);
                        aQuote.ChangePartNum(dQuote, false, "");
                        //
                        qh = (QuoteDataSet.QuoteDtlRow)dQuote.QuoteDtl.Rows[(dQuote.QuoteDtl.Rows.Count - 1)];
                        qh.OrderQty = Convert.ToDecimal(mgProductos.Rows[i].Cells["Cantidad"].Value);
                        qh.SellingExpectedQty = Convert.ToDecimal(mgProductos.Rows[i].Cells["Cantidad"].Value);
                        qh.ExtPriceDtl = Convert.ToDecimal(mgProductos.Rows[i].Cells["Precio Unitario"].Value);
                        qh.DocExtPriceDtl = Convert.ToDecimal(mgProductos.Rows[i].Cells["Precio Unitario"].Value);
                        qh.ExpUnitPrice = Convert.ToDecimal(mgProductos.Rows[i].Cells["Precio Unitario"].Value);
                        qh.DocExpUnitPrice = Convert.ToDecimal(mgProductos.Rows[i].Cells["Precio Unitario"].Value);
                        qh.QuoteComment = mgProductos.Rows[i].Cells["Comentario"].Value.ToString();
                        qh["ShortChar02"] = mgProductos.Rows[i].Cells["IdMoneda"].Value.ToString();
                        qh["Number01"] = Convert.ToDecimal(mgProductos.Rows[i].Cells["ConsecImp"].Value);
                        qh["ShortChar03"] = mgProductos.Rows[i].Cells["PartePPal"].Value.ToString();
                        qh["ShortChar04"] = mgProductos.Rows[i].Cells["CalcularImpuesto"].Value.ToString();
                        qh["Number02"] = Convert.ToDecimal(mgProductos.Rows[i].Cells["IVA"].Value);
                        //

                        //
                        aQuote.Update(dQuote);
                        aQuote.ExistsProductGroupPriceList(QuoteNum, mgProductos.Rows[i].Cells["ProdCode"].Value.ToString(), mgProductos.Rows[i].Cells["UM"].Value.ToString());
                        aQuote.ExistsProductGroupDiscPriceList(QuoteNum, mgProductos.Rows[i].Cells["ProdCode"].Value.ToString(), mgProductos.Rows[i].Cells["UM"].Value.ToString());
                        //
                        var qq = (QuoteDataSet.QuoteQtyRow)dQuote.QuoteQty.Rows[(dQuote.QuoteQty.Rows.Count - 1)];
                        qq.SellingQuantity = Convert.ToDecimal(mgProductos.Rows[i].Cells["Cantidad"].Value);
                        qq.UnitPrice = Convert.ToDecimal(mgProductos.Rows[i].Cells["Precio Unitario"].Value);
                        qq.DocUnitPrice = Convert.ToDecimal(mgProductos.Rows[i].Cells["Precio Unitario"].Value);
                        qq.IUM = mgProductos.Rows[i].Cells["UM"].Value.ToString();
                        qq.CurrencyCode = mgProductos.Rows[i].Cells["IdMoneda"].Value.ToString();
                        //
                        aQuote.Update(dQuote);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
        public void QuoteMsc                (int QuoteNum, MetroFramework.Controls.MetroGrid mgProdMisc, ref string Error)
        {
            try
            {
                QuoteAdapter qad = new QuoteAdapter(oTrans); qad.BOConnect();
                QuoteImpl aQuote = qad.BusinessObject as QuoteImpl;
                QuoteDataSet dQuote = new QuoteDataSet();
                if (mgProdMisc.Rows.Count - 1 >= 0)
                {
                    dQuote = aQuote.GetByID(QuoteNum);
                    for (int i = 0; i<= mgProdMisc.Rows.Count - 1; i++)
                    {
                        dQuote.QuoteHedMsc.NewRow();
                        aQuote.GetNewQuoteHedMsc(dQuote, QuoteNum, 0, 0);
                        Guid SysRow = new Guid("00000000-0000-0000-0000-000000000000");
                        var qm = (QuoteDataSet.QuoteHedMscRow)dQuote.QuoteHedMsc.Rows[(dQuote.QuoteHedMsc.Rows.Count - 1)];
                        qm.MiscCode = mgProdMisc.Rows[i].Cells["IDCargo"].Value.ToString();
                        qm.CurrencySwitch = false;
                        qm["ShortChar01"] = mgProdMisc.Rows[i].Cells["IDMoneda"].Value.ToString();
                        qm.SysRowID = SysRow;
                        aQuote.GetMiscChrgDefaults(dQuote, "QuoteHedMsc");
                        qm.MiscAmt = Convert.ToDecimal(mgProdMisc.Rows[i].Cells["Valor"].Value);
                        qm.DocMiscAmt = Convert.ToDecimal(mgProdMisc.Rows[i].Cells["Valor"].Value);
                        aQuote.Update(dQuote);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }
        public int QuoteHead                (Entidades.EntidadesQuoteHed enT, ref string Error)
        {
            int QuoteNum = 0;
            try
            {
                BO.Metodos mt = new Metodos();
                QuoteAdapter qad = new QuoteAdapter(oTrans);qad.BOConnect();
                QuoteImpl aQuote = qad.BusinessObject as QuoteImpl;
                QuoteDataSet dQuote = new QuoteDataSet();
                aQuote.GetNewQuoteHed(dQuote);
                
                foreach (QuoteDataSet.QuoteHedRow drQuoteHed in dQuote.QuoteHed)
                {
                    drQuoteHed.Company                  = enT.Company;
                    drQuoteHed.CustNum                  = enT.CustNum;
                    drQuoteHed.BTCustNum                = enT.CustNum;
                    drQuoteHed.ShipToCustNum            = enT.CustNum;
                    //
                    drQuoteHed.ShipToNum                = enT.ShipToNum;
                    //
                    drQuoteHed.BTCustID                 = enT.CustID;
                    drQuoteHed.CustomerCustID           = enT.CustID;
                    drQuoteHed.ShipToCustID             = enT.CustID;
                    //
                    drQuoteHed.EntryDate                = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    drQuoteHed.DueDate                  = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    drQuoteHed.EntryDate                = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                    drQuoteHed.Quoted                   = false;
                    drQuoteHed.CheckOff1                = false;
                    drQuoteHed.CheckOff2                = false;
                    drQuoteHed.CheckOff3                = false;
                    drQuoteHed.CheckOff4                = false;
                    drQuoteHed.CheckOff5                = false;
                    drQuoteHed.CurrencyCode             = Configuracion.Config.Default.CurrencyDefault;
                    decimal ExchangeRate                = 0;
                    string RateLabel                    = string.Empty;
                    aQuote.GetExchangeRate              (Configuracion.Config.Default.CurrencyDefault, enT.RateGrpCode, out ExchangeRate, out RateLabel);
                    drQuoteHed.ExchangeRate             = ExchangeRate;
                    drQuoteHed.TerritoryID              = enT.TerritoryID;
                    drQuoteHed.MktgCampaignID           = enT.MktgCampaignID;
                    drQuoteHed.MktgEvntSeq              = enT.MktgEvntSeq;
                    drQuoteHed.QuoteComment             = enT.QuoteComment;
                    drQuoteHed.RateGrpCode              = enT.RateGrpCode;
                    drQuoteHed.ShipViaCode              = Configuracion.Config.Default.ShipViaCodeDefault;
                    drQuoteHed.TermsCode                = "60D";
                    Guid SysRow                         = new Guid("00000000-0000-0000-0000-000000000000");
                    drQuoteHed.SysRowID                 = SysRow;
                    //
                    drQuoteHed.TaskSetID                = Configuracion.Config.Default.TaskSetID;
                    drQuoteHed.ActiveTaskID             = Configuracion.Config.Default.ActiveTaskID;
                    //
                    drQuoteHed["ShortChar01"]           = enT.Tipo;
                    drQuoteHed["ShortChar02"]           = enT.LAB;
                    drQuoteHed["ShortChar04"]           = enT.LABEW;
                    drQuoteHed["Character01"]           = enT.CreateBy;
                }
                aQuote.GetCustomerInfo(dQuote);
                aQuote.Update(dQuote);
                QuoteNum = Convert.ToInt32(dQuote.Tables["QuoteHed"].Rows[dQuote.Tables["QuoteHed"].Rows.Count - 1]["QuoteNum"]);
                //
                string[] refstring = new string[10];
                decimal[] refdecimal = new decimal[1];
                int[] refint = new int[1];
                //
                if (!string.IsNullOrEmpty(enT.SalesRepCode))
                {
                    aQuote.GetSalesRepInfo(true, QuoteNum, enT.SalesRepCode, ref refstring[9], out refstring[0], out refdecimal[0], out refint[0], out refstring[1], out refstring[2],
                        out refstring[3], out refstring[4], out refstring[5], out refstring[6], out refstring[7], out refstring[8]);
                    var qr = (QuoteDataSet.QSalesRPRow)dQuote.QSalesRP.Rows[(dQuote.QSalesRP.Rows.Count - 1)];
                    qr.SalesRepCode = enT.SalesRepCode;
                    qr.Name = refstring[0];
                    qr.PrimeRep = true;
                    qr.RoleCode = refstring[9];
                    qr.OfficePhone = refstring[1];
                    qr.HomePhone = refstring[2];
                    qr.ReportsTo = refstring[3];
                    qr.EmailAddress = refstring[4];
                    qr.Fax = refstring[5];
                    qr.MobilePhone = refstring[6];
                    qr.SalesRepTitle = refstring[7];
                    //
                    aQuote.Update(dQuote);
                }
                
                if (!string.IsNullOrEmpty(enT.ConNum))
                {
                    
                    var ds = mt.consultaslist(enT.sess, "CustCntList", "Erp:BO:CustCnt", "Company = '" + enT.Company + "' and CustNum = '" + enT.CustNum + "' and ConNum = '" + enT.ConNum + "' and ShipToNum = '"+enT.ShipToNum+"'", "PerConID", ref Error);
                    if (ds.Rows.Count - 1 >= 0)
                    {
                        aQuote.GetNewQuoteCnt(dQuote, QuoteNum, enT.CustNum, enT.ShipToNum, Convert.ToInt32(enT.ConNum));
                        aQuote.GetCustCntInfo(QuoteNum, enT.CustNum, enT.ShipToNum, Convert.ToInt32(enT.ConNum), Convert.ToInt32(ds.Rows[0]["PerConID"].ToString()), dQuote);
                    }
                    else
                    {
                        ds = mt.consultaslist(enT.sess, "CustCntList", "Erp:BO:CustCnt", "Company = '" + enT.Company + "' and CustNum = '" + enT.CustNum + "' and ConNum = '" + enT.ConNum + "'", "PerConID", ref Error);
                        if (ds.Rows.Count - 1 >= 0)
                        {
                            aQuote.GetNewQuoteCnt(dQuote, QuoteNum, enT.CustNum, enT.ShipToNum, Convert.ToInt32(enT.ConNum));
                            aQuote.GetCustCntInfo(QuoteNum, enT.CustNum, enT.ShipToNum, Convert.ToInt32(enT.ConNum), Convert.ToInt32(ds.Rows[0]["PerConID"].ToString()), dQuote);
                        }
                    }
                    aQuote.Update(dQuote);
                }
                if (!string.IsNullOrEmpty(enT.ShipToNum.ToString()))
                {
                    var ds = mt.consultaslist(enT.sess, "ShipToList", "Erp:BO:ShipTo", "Company = '" + enT.Company + "' and CustNum = '" + enT.CustNum + "' and ShipToNum = '" + enT.ShipToNum + "'", "TerritoryID,Name,Address1,City,State,ZIP,Country", ref Error);
                    if (ds.Rows.Count - 1 >= 0)
                    {
                        var qr = (QuoteDataSet.QuoteHedRow)dQuote.QuoteHed.Rows[(dQuote.QuoteHed.Rows.Count - 1)];
                        qr.TerritoryID = ds.Rows[0]["TerritoryID"].ToString();
                        qr.ShipToNum = enT.ShipToNum;
                        qr.RowMod = "U";
                        aQuote.GetShipToInfo(dQuote);
                        aQuote.Update(dQuote);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return QuoteNum;
        }
        public string UpdateQuoteHead       (Entidades.EntidadesQuoteHed enT, int QuoteNum)
        {
            string Msg = string.Empty;
            try
            {
                BO.Metodos mt = new Metodos();
                QuoteAdapter qad = new QuoteAdapter(oTrans); qad.BOConnect();
                QuoteImpl aQuote = qad.BusinessObject as QuoteImpl;
                QuoteDataSet dQuote = new QuoteDataSet();
                dQuote = aQuote.GetByID(QuoteNum);
                foreach (QuoteDataSet.QuoteHedRow drQuoteHed in dQuote.QuoteHed)
                {
                    drQuoteHed.TerritoryID = enT.TerritoryID;
                    drQuoteHed.MktgCampaignID = enT.MktgCampaignID;
                    drQuoteHed.MktgEvntSeq = enT.MktgEvntSeq;
                    drQuoteHed.QuoteComment = enT.QuoteComment;
                    //
                    drQuoteHed["ShortChar01"] = enT.Tipo;
                    drQuoteHed["ShortChar02"] = enT.LAB;
                    drQuoteHed["ShortChar04"] = enT.LABEW;
                }
                aQuote.Update(dQuote);

                Msg = "Proceso exitoso!";
            }
            catch (Exception ex)
            {
                Msg = ex.Message;
            }
            return Msg;
        }
        public QuoteDataSet dQuote          (int QuoteNum,ref string Error)
        {
            QuoteDataSet ds = new QuoteDataSet();
            try
            {
                QuoteAdapter qad = new QuoteAdapter(oTrans); qad.BOConnect();
                QuoteImpl aQuote = qad.BusinessObject as QuoteImpl;
                ds = aQuote.GetByID(QuoteNum);
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return ds;
        }
        public bool QuoteExist              (string Company, int QuoteNum)
        {
            bool Pass = false;
            try
            {
                BO.Metodos mt = new Metodos();
                string Error = string.Empty;
                var ds = mt.consultaslist((oTrans.Session as Ice.Core.Session), "QuoteHedList", "Erp:BO:Quote", "Company = '" + Company + "' and QuoteNum = '" + QuoteNum + "'", "QuoteNum", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    Pass = true;
                }
            }
            catch
            {
                Pass = false;
            }
            return Pass;
        }
    }
}
