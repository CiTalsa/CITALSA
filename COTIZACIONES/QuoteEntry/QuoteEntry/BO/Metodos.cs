using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice.Proxy.Lib;
using Ice.Lib.Framework;

namespace QuoteEntry.BO
{
    public class Metodos
    {
        public DataTable consultaslist(object sess, string Table,string Referencia, string Where, string campos, ref string Error)
        {
            DataTable dTable = new DataTable();
            try
            {
                BOReaderImpl _bor = WCFServiceSupport.CreateImpl<Ice.Proxy.Lib.BOReaderImpl>(sess as Ice.Core.Session, Epicor.ServiceModel.Channels.ImplBase<Ice.Contracts.BOReaderSvcContract>.UriPath);
                string whereClause = Where;
                System.Data.DataSet dsPartRevSearchAdapter = _bor.GetList(Referencia, whereClause, campos);
                if (dsPartRevSearchAdapter.Tables[Table].Rows.Count - 1 >= 0)
                {
                    dTable = dsPartRevSearchAdapter.Tables[Table];
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return dTable;
        }
        public DataTable consultaslistRows(object sess,string Table, string Referencia, string Where, string campos, ref string Error)
        {
            DataTable dTable = new DataTable();
            try
            {
                BOReaderImpl _bor = WCFServiceSupport.CreateImpl<Ice.Proxy.Lib.BOReaderImpl>(sess as Ice.Core.Session, Epicor.ServiceModel.Channels.ImplBase<Ice.Contracts.BOReaderSvcContract>.UriPath);
                string whereClause = Where;
                System.Data.DataSet dsPartRevSearchAdapter = _bor.GetRows(Referencia, whereClause, campos);
                if (dsPartRevSearchAdapter.Tables[Table].Rows.Count - 1 >= 0)
                {
                    dTable = dsPartRevSearchAdapter.Tables[Table];
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return dTable;
        }
        public decimal ImpParte(Ice.Core.Session sess,string Impuesto)
        {
            decimal Valor = 0;
            string Error = string.Empty;
            try
            {
                string SQL = "Company = '"+sess.CompanyID.ToString()+"' and TaxCatID = '" + Impuesto + "' and TaxCode = '" + Configuracion.Config.Default.TaxCode + "'";
                var ds = consultaslistRows(sess, "TaxCatD", "Erp:BO:TaxCatDSearch", SQL, "TaxCatID,TaxCode,RateCode", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    SQL = "Company = '" + sess.CompanyID.ToString() + "' and TaxCode = '" + ds.Rows[0]["TaxCode"].ToString() + "'";// and RateCode = '" + ds.Rows[0]["RateCode"].ToString() + "'";
                    var dst = consultaslistRows(sess,"TaxRate","Erp:BO:SalesTax", SQL, "", ref Error);
                    if (dst.Rows.Count - 1 >= 0)
                    {
                        foreach (DataRow dr in dst.Rows)
                        {
                            if(dr["RateCode"].ToString() == ds.Rows[0]["RateCode"].ToString())
                                Valor = Convert.ToDecimal(dr["TaxPercent"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                Valor = 0;
            }
            return Valor;
        }
        public byte[] Imagen(string Ruta)
        {
            byte[] BannerImagen = new byte[1];
            System.IO.FileStream fs = new System.IO.FileStream(Ruta, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] b = new byte[fs.Length];
            fs.Read(b, 0, (int)fs.Length);
            fs.Close();
            return b;
        }
    }
}
