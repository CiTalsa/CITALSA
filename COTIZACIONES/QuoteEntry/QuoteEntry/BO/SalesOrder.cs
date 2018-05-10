using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ice.Core;
using Erp.Adapters;
using Erp.BO;
using Erp.Proxy.BO;

namespace QuoteEntry.BO
{
    class SalesOrder
    {
        string parte = "";
        string unidad = "";
        string descripcion = "";
        string ss;
        string Ordenes = "";
        //
        bool n;
        bool t = false;
        //
        int cualOrden = 0;
        //
        decimal precio = 0;
        decimal descuento = 0;
        //
        decimal Pordescuento = 0;
        decimal Cantidad = 0;

        public string Conectar(DataGridView ms_partes, string CustID,Session sess)
        {
            string Msg = string.Empty;
            try
            {
                SalesOrderDataSet dsSalesOrder;
                CrearEncabezado(CustID, ms_partes, out dsSalesOrder, 0, sess);
                Agrupar(ms_partes, dsSalesOrder, CustID, sess);
                Msg = "Ordenes Creadas: " + Ordenes;
            }
            catch (Exception ex)
            {
                Msg = ex.Message;
            }
            return Msg;
        }
        protected void Agrupar(DataGridView ms_partes, SalesOrderDataSet dsSalesOrder, string cual_cliente,Session sess)
        {
            string moneda = "";
            string listamonedas = "";
            DataSet ms_moneda = new DataSet();
            Ordenes = cualOrden + "-" + Ordenes;
            for (int h = 0; h <= ms_partes.Rows.Count - 1; h++)
            {
                if (moneda != ms_partes.Rows[h].Cells["Moneda"].Value.ToString())
                {
                    moneda = ms_partes.Rows[h].Cells["Moneda"].Value.ToString();
                    if (listamonedas.Contains(moneda) == false)
                    {
                        listamonedas = listamonedas + "-" + moneda;
                        if (h != 0)
                        {
                            CrearEncabezado(cual_cliente, ms_partes, out dsSalesOrder, h,sess);
                            Ordenes = cualOrden + "-" + Ordenes;
                        }

                        CrearDetalle(ms_partes, h, dsSalesOrder,sess);

                        for (int k = h + 1; k <= ms_partes.Rows.Count - 1; k++)
                        {
                            if (moneda == ms_partes.Rows[k].Cells["Moneda"].Value.ToString())
                            {
                                CrearDetalle(ms_partes, k, dsSalesOrder,sess);
                            }
                        }
                    }
                }
            }
        }
        protected void CrearEncabezado(string cual_cliente, DataGridView ms_partes, out SalesOrderDataSet dsSalesOrder, int fila,Session sess)
        {
            var boSales = new SalesOrderAdapter(sess); boSales.BOConnect();
            var boSalesOrder = boSales.BusinessObject as SalesOrderImpl;
            dsSalesOrder = new SalesOrderDataSet();

            boSalesOrder.GetNewOrderHed(dsSalesOrder);
            boSalesOrder.OnChangeofSoldToCreditCheck(0, cual_cliente, out ss, out n, dsSalesOrder);
            boSalesOrder.ChangeSoldToID(dsSalesOrder);
            boSalesOrder.ChangeCustomer(dsSalesOrder);
            boSalesOrder.Update(dsSalesOrder);

            int indice = dsSalesOrder.Tables["OrderHed"].Rows.Count - 1;
            cualOrden = Convert.ToInt32(dsSalesOrder.Tables["OrderHed"].Rows[indice]["OrderNum"]);
            dsSalesOrder.Tables["OrderHed"].Rows[indice].BeginEdit();
            dsSalesOrder.Tables["OrderHed"].Rows[indice]["CurrencyCode"] = ms_partes.Rows[fila].Cells["Moneda"].Value.ToString();
            dsSalesOrder.Tables["OrderHed"].Rows[indice].EndEdit();
            boSalesOrder.Update(dsSalesOrder);
        }
        protected void CrearDetalle(DataGridView ms_partes, int j, SalesOrderDataSet dsSalesOrder,Session sess)
        {
            
            if (ms_partes.Rows.Count - 1 >= 0)
            {
                parte = "";
                unidad = "";
                precio = 0;
                Cantidad = 0;
                descuento = 0;
                Pordescuento = 0;
                descripcion = "";
                //
                parte = ms_partes.Rows[j].Cells["Id Parte"].Value.ToString();
                unidad = ms_partes.Rows[j].Cells["UM"].Value.ToString();
                precio = Convert.ToDecimal(ms_partes.Rows[j].Cells["Precio Unitario"].Value);
                Cantidad = Convert.ToDecimal(ms_partes.Rows[j].Cells["Cantidad"].Value);
                descuento = Convert.ToDecimal(ms_partes.Rows[j].Cells["Valor Dcto"].Value);
                Pordescuento = Convert.ToDecimal(ms_partes.Rows[j].Cells["% Dcto"].Value);
                descripcion = ms_partes.Rows[j].Cells["Descripcion"].Value.ToString();
                //
                var boSales = new SalesOrderAdapter(sess); boSales.BOConnect();
                var boSalesOrder = boSales.BusinessObject as SalesOrderImpl;
                //
                boSalesOrder.GetNewOrderDtl(dsSalesOrder, cualOrden);
                Guid SysRow = new Guid("00000000-0000-0000-0000-000000000000");
                //
                boSalesOrder.ChangePartNumMaster(ref parte, ref n, ref n, ref ss, SysRow, ss, n, n, n, n, n, n, out ss, out ss, out ss, out n, out n, out ss, out ss, out ss, out ss, out n, out n, dsSalesOrder);
                parte = ms_partes.Rows[j].Cells["Id Parte"].Value.ToString();
                boSalesOrder.ChangeSellingQtyMaster(dsSalesOrder, Cantidad, n, n, t, t, n, t, parte, ss, ss, ss, unidad, 1, out ss, out ss, out ss, out ss);
                //
                var odr = (SalesOrderDataSet.OrderDtlRow)dsSalesOrder.OrderDtl.Rows[(dsSalesOrder.OrderDtl.Rows.Count - 1)];
                //
                odr.UnitPrice = precio;
                odr.DocUnitPrice = precio;
                odr.DspUnitPrice = precio;
                odr.DocDspUnitPrice = precio;
                odr.Discount = descuento;
                odr.DocDiscount = descuento;
                odr.DiscountPercent = Pordescuento;
                //
                odr.ExtPriceDtl = ((precio-descuento)*Cantidad);
                odr.DocExtPriceDtl = ((precio - descuento) * Cantidad);
                odr.ExtPrice = ((precio - descuento) * Cantidad);
                odr.DocExtPrice = ((precio - descuento) * Cantidad);
                odr.TotalPrice = ((precio - descuento) * Cantidad);
                odr.DocTotalPrice = ((precio - descuento) * Cantidad);
                boSalesOrder.Update(dsSalesOrder);
                //
            }
        }
    }
}
