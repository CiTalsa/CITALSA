using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace QuoteEntry.UserControls
{
    public partial class ucQuoteEntry : MetroFramework.Controls.MetroUserControl
    {
        #region REFERENCIAS GLOBALES
        BO.BOMensajes ms                            = new BO.BOMensajes();
        BO.Metodos mt                               = new BO.Metodos();
        DataTable DSParte                           = new DataTable();
        DataTable DSMiscelaneo                      = new DataTable();
        DataTable DSTotales                         = new DataTable();
        public Ice.Core.Session sess;
        int OrderNum = 0;
        string CustNum, IDCampana = "RELCOMER", IDEvento = "1", TaxCatId;

        #endregion

        public ucQuoteEntry()
        {
            InitializeComponent();
        }

        #region CARGAR COMBOBOX
        internal void CargarContactoCliente(string CustNum)
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "CustCntList", "Erp:BO:CustCnt", "Company = '" + sess.CompanyID.ToString() + "' and CustNum = '" + CustNum + "' and ShipToNum = '"+txtShipToNum.Text+"'", "Name, ConNum", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbContacto.DataSource = ds;
                    cmbContacto.DisplayMember = "Name";
                    cmbContacto.ValueMember = "ConNum";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarRolCliente(string CustNum, string Cnt)
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "CustCntList", "Erp:BO:CustCnt", "Company = '" + sess.CompanyID.ToString() + "' and CustNum = '" + CustNum + "' and ConNum = '" + Cnt + "'", "Func", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    txtContacto.Text = ds.Rows[0]["Func"].ToString();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarAsesor()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "SalesRepList", "Erp:BO:SalesRep", "Company = '" + sess.CompanyID.ToString() + "' and InActive = False", "SalesRepCode,Name", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbAsesor.DataSource = ds;
                    cmbAsesor.DisplayMember = "Name";
                    cmbAsesor.ValueMember = "SalesRepCode";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarTerritorio()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "SalesTerList", "Erp:BO:SalesTer", "Company = '" + sess.CompanyID.ToString() + "'", "TerritoryID, TerritoryDesc", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbTerritorio.DataSource = ds;
                    cmbTerritorio.DisplayMember = "TerritoryDesc";
                    cmbTerritorio.ValueMember = "TerritoryID";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarLab()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "FOBList","Erp:BO:FOB", "Company = '" + sess.CompanyID.ToString() + "'", "FOB, Description", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbLAB.DataSource = ds;
                    cmbLAB.DisplayMember = "Description";
                    cmbLAB.ValueMember = "FOB";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarLabExw()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "FOBList","Erp:BO:FOB", "Company = '" + sess.CompanyID.ToString() + "'", "FOB, Description", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbLABEXW.DataSource = ds;
                    cmbLABEXW.DisplayMember = "Description";
                    cmbLABEXW.ValueMember = "FOB";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarMonedaLinea()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "CurrencyList", "Erp:BO:Currency", "Company = '" + sess.CompanyID.ToString() + "'", "CurrencyCode, CurrDesc", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbMonedaLinea.DataSource = ds;
                    cmbMonedaLinea.DisplayMember = "CurrDesc";
                    cmbMonedaLinea.ValueMember = "CurrencyCode";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarMonedaMisc()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "CurrencyList", "Erp:BO:Currency", "Company = '" + sess.CompanyID.ToString() + "'", "CurrencyCode, CurrDesc", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbMonedaMisc.DataSource = ds;
                    cmbMonedaMisc.DisplayMember = "CurrDesc";
                    cmbMonedaMisc.ValueMember = "CurrencyCode";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargatTipoCotiz()
        {
            try
            {
                DataTable dTable = new DataTable();
                dTable.Columns.Add("ID");
                dTable.Columns.Add("DisplayText");
                dTable.Rows.Add("N", "Nacional");
                dTable.Rows.Add("I", "Internacional");
                dTable.Rows.Add("S", "Servicio Tecnico");
                dTable.AcceptChanges();
                cmbTipo.DataSource = dTable;
                cmbTipo.ValueMember = "ID";
                cmbTipo.DisplayMember = "DisplayText";
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarCargosMisc()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "MiscChrgList", "Erp:BO:MiscChrg", "Company = '" + sess.CompanyID.ToString() + "'", "Description, MiscCode", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbCargoMisc.DataSource = ds;
                    cmbCargoMisc.DisplayMember = "Description";
                    cmbCargoMisc.ValueMember = "MiscCode";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void CargarUOM()
        {
            try
            {
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "UOMList", "Erp:BO:UOM", "Company = '" + sess.CompanyID.ToString() + "'", "UOMCode,UOMDesc", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    cmbUOM.DataSource = ds;
                    cmbUOM.DisplayMember = "UOMDesc";
                    cmbUOM.ValueMember = "UOMCode";
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        #endregion
        #region CONTROLES()
        internal void BloquearControles(bool Estado)
        {
            mlSearchCustomer.Enabled = Estado;
            txtCustID.Enabled = Estado;
            cmbTipo.Enabled = Estado;
            mlViewCustomer.Enabled = Estado;
            txtCustIDShip.Enabled = Estado;
            mlSearchShipToNum.Enabled = Estado;
            txtShipToNum.Enabled = Estado;
            mlViewShipDtl.Enabled = Estado;
            cmbContacto.Enabled = Estado;
            txtContacto.Enabled = Estado;
            dtpFecha.Enabled = Estado;
            cmbTerritorio.Enabled = Estado;
            cmbAsesor.Enabled = Estado;
            cmbLAB.Enabled = Estado;
            cmbLABEXW.Enabled = Estado;
            txtCampana.Enabled = Estado;
            txtEvento.Enabled = Estado;
            txtCaso.Enabled = Estado;
            txtObservaciones.Enabled = Estado;
            mlSearchPartNum.Enabled = Estado;
            txtPartNum.Enabled = Estado;
            chkDesbloquear.Enabled = Estado;
            txtPartDesc.Enabled = Estado;
            mlSearchProdGroup.Enabled = Estado;
            txtProdGroup.Enabled = Estado;
            txtLineObservaciones.Enabled = Estado;
            chkImpuesto.Enabled = Estado;
            mlAgregarLinea.Enabled = Estado;
            NUnitPrice.Enabled = Estado;
            NDctoper.Enabled = Estado;
            NValorDcto.Enabled = Estado;
            NCantidad.Enabled = Estado;
            cmbUOM.Enabled = Estado;
            cmbMonedaLinea.Enabled = Estado;
            mgProductos.Enabled = Estado;
            mgProdMisc.Enabled = Estado;
            mgTotales.Enabled = Estado;
            cmbCargoMisc.Enabled = Estado;
            NValorMisc.Enabled = Estado;
            cmbMonedaMisc.Enabled = Estado;
            mtAddLineaMisc.Enabled = Estado;
            chkDesbloquear.Enabled = Estado;
            chkImpuesto.Enabled = Estado;
            chkTotales.Enabled = Estado;
            //
            mlNuevo.Enabled = true;
            mlModificar.Enabled = Estado;
            mlGuardar.Enabled = Estado;
            mlCancelar.Enabled = Estado;
            mlimprimir.Enabled = Estado;
            mlCreateOrden.Enabled = Estado;
            mlEliminarLineaMisc.Enabled = Estado;
        }
        internal void LimpiarControles()
        {
            CustNum = string.Empty;
            TaxCatId = string.Empty;
            //
            txtQuoteNum.Text = string.Empty;
            txtCustID.Text = string.Empty;
            txtCampana.Text = string.Empty;
            txtCaso.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtCustIDShip.Text = string.Empty;
            txtEvento.Text = string.Empty;
            txtLineObservaciones.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            txtPartDesc.Text = string.Empty;
            txtPartNum.Text = string.Empty;
            txtProdGroup.Text = string.Empty;
            txtShipToNum.Text = string.Empty;
            //
            NCantidad.Value = 0;
            NUnitPrice.Value = 0;
            NValorDcto.Value = 0;
            NValorMisc.Value = 0;
            NDctoper.Value = 0;
            //
            mlViewCustomer.Clear();
            mlViewShipDtl.Clear();
            //
            mgProdMisc.DataSource = null;
            mgProductos.DataSource = null;
            mgTotales.DataSource = null;
            //
            chkDesbloquear.Value = false;
            chkImpuesto.Value = true;
            //
            DSParte.Clear();
            DSMiscelaneo.Clear();
            DSTotales.Clear();
            //
        }
        #endregion
        #region CARGAR DATASET's
        internal void CargarDatas                    ()
        {
            DSParte.Clear();
            DSParte.Columns.Add("Fila", typeof(int));                       //0
            DSParte.Columns.Add("Id Parte", typeof(string));                //1
            DSParte.Columns.Add("Descripcion", typeof(string));             //2
            DSParte.Columns.Add("Cantidad", typeof(double));                //3
            DSParte.Columns.Add("Precio Final", typeof(decimal));           //4
            DSParte.Columns.Add("Moneda", typeof(string));                  //5
            DSParte.Columns.Add("Precio Unitario", typeof(double));         //6
            DSParte.Columns.Add("% Dcto", typeof(string));                  //7
            DSParte.Columns.Add("Valor Dcto", typeof(double));              //8
            DSParte.Columns.Add("IdMoneda", typeof(string));                //9
            DSParte.Columns.Add("ProdCode", typeof(string));                //10
            DSParte.Columns.Add("UM", typeof(string));                      //11
            DSParte.Columns.Add("Precio TRM", typeof(decimal));             //12
            DSParte.Columns.Add("ConsecImp", typeof(string));               //13
            DSParte.Columns.Add("Comentario", typeof(string));              //14
            DSParte.Columns.Add("PartePPal", typeof(string));               //15
            DSParte.Columns.Add("AplicaTitulo", typeof(string));            //16
            DSParte.Columns.Add(".", typeof(string));                       //17
            DSParte.Columns.Add("CalcularImpuesto", typeof(string));        //18
            DSParte.Columns.Add("IVA", typeof(decimal));                    //19
            mgProductos.DataSource = DSParte;
            //
            mgProductos.Columns["Descripcion"].Width = 140;
            //
            mgProductos.Columns["IdMoneda"].Visible = false;
            mgProductos.Columns["ProdCode"].Visible = false;
            mgProductos.Columns["CalcularImpuesto"].Visible = false;
            mgProductos.Columns["IVA"].Visible = false;
            mgProductos.Columns["."].Visible = false;
            mgProductos.Columns["PartePPal"].Visible = false;
            mgProductos.Columns["ConsecImp"].Visible = false;
            mgProductos.Columns["AplicaTitulo"].Visible = false;
            //
            mgProductos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            mgProductos.Columns["Precio Final"].DefaultCellStyle.Format = "N2";
            mgProductos.Columns["Precio Unitario"].DefaultCellStyle.Format = "N2";
            mgProductos.Columns["% Dcto"].DefaultCellStyle.Format = "N2";
            mgProductos.Columns["Valor Dcto"].DefaultCellStyle.Format = "N2";
            mgProductos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            mgProductos.Columns["Precio TRM"].DefaultCellStyle.Format = "N2";
            //
            mgProductos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            mgProductos.Columns["Precio Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            mgProductos.Columns["Precio Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            mgProductos.Columns["% Dcto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            mgProductos.Columns["Valor Dcto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            mgProductos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            mgProductos.Columns["Precio TRM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //
            DSMiscelaneo.Clear();
            DSMiscelaneo.Columns.Add("Fila", typeof(int));                  //0
            DSMiscelaneo.Columns.Add("Cargo Misc", typeof(string));         //1
            DSMiscelaneo.Columns.Add("Valor", typeof(double));              //2
            DSMiscelaneo.Columns.Add("Moneda", typeof(string));             //3
            DSMiscelaneo.Columns.Add("IDMoneda", typeof(string));           //4
            DSMiscelaneo.Columns.Add("IDCargo", typeof(string));            //5
            mgProdMisc.DataSource = DSMiscelaneo;
            mgProdMisc.Columns["IDMoneda"].Visible = false;
            mgProdMisc.Columns["IDCargo"].Visible = false;
            mgProdMisc.Columns["Valor"].DefaultCellStyle.Format = "N2";
            mgProdMisc.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //
            DSTotales.Clear();
            DSTotales.Columns.Add("Moneda", typeof(string));                //0
            DSTotales.Columns.Add("Antes Dcto", typeof(double));            //1
            DSTotales.Columns.Add("Valor Dcto", typeof(double));            //2
            DSTotales.Columns.Add("Antes de Impuesto", typeof(double));     //3
            DSTotales.Columns.Add("Total Final", typeof(double));           //4
            mgTotales.DataSource = DSTotales;
            //
            mgTotales.Columns["Antes Dcto"].Visible = false;
            mgTotales.Columns["Valor Dcto"].Visible = false;
            mgTotales.Columns["Antes de Impuesto"].Visible = false;
            //
            mgTotales.Columns["Total Final"].DefaultCellStyle.Format = "N2";
            mgTotales.Columns["Total Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        #endregion

        internal void ucQuoteEntry_Load              (object sender, EventArgs e)
        {
            CargarDatas();
            mLeft.Focus();
            LoadPrincipal();
            BloquearControles(false);
            txtQuoteNum.Focus();
        }
        //
        internal void chkDesbloquear_Click           (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPartDesc.Text))
                {
                    if (chkDesbloquear.Value)
                    {
                        bool pasa = false;
                        while (!pasa)
                        {
                            txtPartDesc.ReadOnly = true;
                            PopUp.frmGetPassword frmGet = new PopUp.frmGetPassword();
                            if (frmGet.ShowDialog() == DialogResult.OK)
                            {
                                pasa = frmGet.Pasa;
                            }
                            if (!pasa)
                            {
                                if (ms.Pregunta(this, "Error de contraseña, desea intentar de nuevo?") == DialogResult.No)
                                {
                                    txtPartDesc.ReadOnly = true;
                                    chkDesbloquear.Value = false;
                                    break;
                                }
                            }
                        }
                        if (pasa)
                        {
                            txtPartDesc.ReadOnly = false;
                            txtPartDesc.Focus();
                        }
                    }
                }
                else
                {
                    chkDesbloquear.Value = false;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlAgregarLinea_Click           (object sender, EventArgs e)
        {
            AgregarLineaDetalle();
        }
        internal void mlCancelar_Click               (object sender, EventArgs e)
        {
            try
            {
                BloquearControles(false);
                LimpiarControles();
                LoadPrincipal();
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlEliminarLineaMisc_Click      (object sender, EventArgs e)
        {
            try
            {
                if (mgProdMisc.Rows.Count > 0)
                {
                    mgProdMisc.Rows.RemoveAt(mgProdMisc.CurrentRow.Index);
                }
                else
                {
                    ms.Alerta(this,"No hay filas para eliminar");
                }
                LineasCargo();
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlGuardar_Click                (object sender, EventArgs e)
        {
            GuardarCotizacion();
        }
        internal void mlNuevo_Click                  (object sender, EventArgs e)
        {
            try
            {
                //
                txtQuoteNum.Enabled = false;
                txtQuoteNum.Text = "0";
                //
                BloquearControles(true);
                mlModificar.Enabled = false;
                //
                txtCustID.Focus();
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);   
            }
        }
        internal void mlSearchCampana_Click          (object sender, EventArgs e)
        {
            try
            {
                FormSearch.frmSearchCampana frmSearch = new FormSearch.frmSearchCampana();
                frmSearch.sess = sess;
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    IDCampana = frmSearch.IDCampana;
                    txtCampana.Text = frmSearch.Campana;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlSearchCustomer_Click         (object sender, EventArgs e)
        {
            try
            {
                FormSearch.frmSearchCustomer frC = new FormSearch.frmSearchCustomer();
                frC.sess = sess;
                if (frC.ShowDialog() == DialogResult.OK)
                {
                    CustNum = frC.CustNum;
                    CargaInfoCliente(frC.CustID);
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlSearchEvento_Click           (object sender, EventArgs e)
        {
            try
            {
                FormSearch.frmSearchEvento frmSearch = new FormSearch.frmSearchEvento();
                frmSearch.sess = sess;
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    IDEvento = frmSearch.IDEvento;
                    txtEvento.Text = frmSearch.Evento;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlSearchShipToNum_Click        (object sender, EventArgs e)
        {
            try
            {
                FormSearch.frmShipTo frmShip = new FormSearch.frmShipTo();
                frmShip.CustNum = CustNum;
                frmShip.sess = sess;
                if (frmShip.ShowDialog() == DialogResult.OK)
                {
                    txtShipToNum.Text = frmShip.ShipToNum;
                    CargarContactoCliente(CustNum);
                    //
                    mlViewShipDtl.Clear();
                    //
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["Name"].Value.ToString());
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["Address1"].Value.ToString());
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["Address2"].Value.ToString());
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["Address3"].Value.ToString());
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["PhoneNum"].Value.ToString());
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["City"].Value.ToString());
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["State"].Value.ToString());
                    mlViewShipDtl.Items.Add(frmShip.dShip.CurrentRow.Cells["Country"].Value.ToString());
                    //
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlSearchPartNum_Click          (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CustNum))
                {
                    FormSearch.frmSearchPart frmPart = new FormSearch.frmSearchPart();
                    frmPart.sess = sess;
                    if (frmPart.ShowDialog() == DialogResult.OK)
                    {
                        txtPartNum.Text = frmPart.PartNum;
                        txtPartDesc.Text = frmPart.PartDesc;
                        txtProdGroup.Text = frmPart.ProdGroup;
                        cmbUOM.SelectedValue = frmPart.UOM;
                        cmbMonedaLinea.SelectedValue = frmPart.Currenty;
                        NUnitPrice.Value = frmPart.UnitPrice;
                        NCantidad.Value = 1;
                        TaxCatId = frmPart.TaxCatId;
                    }
                }
                else
                {
                    ms.Alerta(this, "Favor ingrese un cliente válido");
                    txtCustID.Focus();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlSearchProdGroup_Click        (object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mlSearchQuoteNum_Click         (object sender, EventArgs e)
        {
            try
            {
                FormSearch.frmSearchQuote frmQ = new FormSearch.frmSearchQuote();
                frmQ.sess = sess;
                if (frmQ.ShowDialog() == DialogResult.OK)
                {
                    txtQuoteNum.Text = frmQ.QuoteNum.ToString();
                    BuscarInfoQuotiz(frmQ.QuoteNum);
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mtAddLineaMisc_Click           (object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(cmbCargoMisc.Text))
                {
                    ms.Alerta(this,"Debe elegir un Cargo Miscelaneo");
                    return;
                }

                if(NValorMisc.Value == 0)
                {
                    ms.Alerta(this,"El valor debe ser mayor que cero");
                    return;
                }
                if (string.IsNullOrEmpty(cmbMonedaMisc.Text))
                {
                    ms.Alerta(this,"Debe ingresar la moneda");
                    return;
                }

                DSMiscelaneo.Rows.Add(new object[]
                {
                0, cmbCargoMisc.Text, NValorMisc.Value, cmbMonedaMisc.Text, cmbMonedaMisc.SelectedValue , cmbCargoMisc.SelectedValue
                });
                DSMiscelaneo.AcceptChanges();
                mgProdMisc.DataSource = DSMiscelaneo;

                NValorMisc.Value = 0;
                cmbCargoMisc.Text = "";
                LineasCargo();
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mtEliminar_Click               (object sender, EventArgs e)
        {
            try
            {
                if (mgProductos.Rows.Count > 0)
                {
                    if(txtQuoteNum.Text == "0")
                        mgProductos.Rows.RemoveAt(mgProductos.CurrentRow.Index);
                    else

                }
                else
                {
                    ms.Alerta(this,"No hay filas para eliminar");
                }
                LimpiaDetalle();
                txtPartNum.Text = "";

                Totalizar();
                mgProductos.ClearSelection();
                mgProductos.CurrentCell = null;
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        //
        internal void txtCustID_KeyPress             (object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCustID.Text))
                {
                    if(e.KeyChar == (char)Keys.Enter)
                        CargaInfoCliente(txtCustID.Text);
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void txtPartNum_KeyPress            (object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    if (!string.IsNullOrEmpty(txtPartNum.Text))
                    {
                    
                        string Error = string.Empty;
                        BO.Metodos mt = new BO.Metodos();
                        var ds = mt.consultaslistRows(sess, "Part", "Erp:BO:Part", "Company = '"+sess.CompanyID.ToString()+"' and PartNum = '"+txtPartNum.Text+"'", "PartNum,PartDescription,ProdCode,IUM,ClassID,TaxCatId,ShortChar10,Number01", ref Error);
                        if (ds.Rows.Count - 1 >= 0)
                        {
                            txtPartNum.Text = ds.Rows[0]["PartNum"].ToString();
                            txtPartDesc.Text = ds.Rows[0]["PartDescription"].ToString();
                            txtProdGroup.Text = ds.Rows[0]["ProdCode"].ToString();
                            cmbUOM.SelectedValue = ds.Rows[0]["IUM"].ToString();
                            cmbMonedaLinea.SelectedValue = ds.Rows[0]["ShortChar10"].ToString();
                            NUnitPrice.Value = Convert.ToDecimal(ds.Rows[0]["Number01"]);
                            NCantidad.Value = 1;
                            TaxCatId = ds.Rows[0]["TaxCatId"].ToString();
                        }
                        else
                        {
                            ms.Alerta(this, "El número de parte no existe!");
                        }
                    }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void txtQuoteNum_KeyPress           (object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtQuoteNum.Text))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                        BuscarInfoQuotiz(Convert.ToInt32(txtQuoteNum.Text));
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        //
        internal void cmbContacto_DropDownClosed     (object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(cmbContacto.Text))
                    CargarRolCliente(CustNum, cmbContacto.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }   
        }
        //
        internal void NDctoper_ValueChanged          (object sender, EventArgs e)
        {
            try
            {
                if (NDctoper.Value > 0)
                {
                    NValorDcto.Value = NUnitPrice.Value * (NDctoper.Value / 100);
                }
                else
                {
                    NValorDcto.Value = 0;
                }
            }
            catch (Exception ex)
            {
                ms.Alerta(this, ex.Message);
            }
        }
        //
        internal void NDctoper_Leave                 (object sender, EventArgs e)
        {
            try
            {
                if (NDctoper.Value > 0)
                {
                    NValorDcto.Value = NUnitPrice.Value * (NDctoper.Value / 100);
                }
                else
                {
                    NValorDcto.Value = 0;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void txtShipToNum_Leave             (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtShipToNum.Text))
                {
                    if(!string.IsNullOrEmpty(CustNum.ToString()))
                        CargarContactoCliente(CustNum);
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        //
        internal void mgTotales_DoubleClick          (object sender, EventArgs e)
        {
            if (mgTotales.Rows.Count - 1 >= 0)
            {
                PopUp.frmDescCurrency frmMon = new PopUp.frmDescCurrency();
                frmMon.dsMonedas = DSTotales;
                frmMon.ShowDialog();
            }
        }
        //
        internal void mgProductos_CellClick          (object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (mgProductos.Rows.Count - 1 >= 0)
                {
                    lblIva.Text = "";
                    txtPartNum.Text = mgProductos.CurrentRow.Cells["Id Parte"].Value.ToString();
                    txtPartDesc.Text = mgProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                    NCantidad.Value = Convert.ToDecimal(mgProductos.CurrentRow.Cells["Cantidad"].Value);
                    NUnitPrice.Value = Convert.ToDecimal(mgProductos.CurrentRow.Cells["Precio Unitario"].Value);
                    NDctoper.Value = Convert.ToDecimal(mgProductos.CurrentRow.Cells["% Dcto"].Value);
                    NValorDcto.Value = Convert.ToDecimal(mgProductos.CurrentRow.Cells["Valor Dcto"].Value);
                    cmbMonedaLinea.SelectedValue = mgProductos.CurrentRow.Cells["IdMoneda"].Value.ToString();
                    cmbUOM.SelectedValue = mgProductos.CurrentRow.Cells["UM"].Value.ToString();
                    txtProdGroup.Text = mgProductos.CurrentRow.Cells["ProdCode"].Value.ToString();
                    txtLineObservaciones.Text = mgProductos.CurrentRow.Cells["Comentario"].Value.ToString();
                    lblIva.Text = mgProductos.CurrentRow.Cells["IVA"].Value.ToString();
                    lblCalcImp.Text = mgProductos.CurrentRow.Cells["CalcularImpuesto"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        //
        //
        internal void CargaInfoCliente               (string CustID)
        {
            try
            {
                string Error = string.Empty;
                //
                var ds = mt.consultaslistRows(sess, "Customer","Erp:BO:Customer", "Company = '" + sess.CompanyID.ToString() + "' and CustID = '" + CustID + "'", "CustNum,CustID,Name, Address1, Address2, Address3, PhoneNum, City, State, Country,TerritoryID, SalesRepCode", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    CustNum = ds.Rows[0]["CustNum"].ToString();
                    //
                    CargarContactoCliente(CustNum);
                    if (!string.IsNullOrEmpty(cmbContacto.Text))
                        CargarRolCliente(CustNum, cmbContacto.SelectedValue.ToString());
                    //
                    txtCustID.Text = ds.Rows[0]["CustID"].ToString();
                    txtCustIDShip.Text = ds.Rows[0]["CustID"].ToString();
                    mlViewCustomer.Items.Add(ds.Rows[0]["Name"].ToString());
                    mlViewCustomer.Items.Add(ds.Rows[0]["Address1"].ToString());
                    mlViewCustomer.Items.Add(ds.Rows[0]["Address2"].ToString());
                    mlViewCustomer.Items.Add(ds.Rows[0]["Address3"].ToString());
                    mlViewCustomer.Items.Add(ds.Rows[0]["PhoneNum"].ToString());
                    mlViewCustomer.Items.Add(ds.Rows[0]["City"].ToString());
                    mlViewCustomer.Items.Add(ds.Rows[0]["State"].ToString());
                    mlViewCustomer.Items.Add(ds.Rows[0]["Country"].ToString());
                    //
                    cmbTerritorio.SelectedValue = ds.Rows[0]["TerritoryID"].ToString();
                    cmbAsesor.SelectedValue     = ds.Rows[0]["SalesRepCode"].ToString();
                    //
                    mlViewShipDtl.Items.Add(ds.Rows[0]["Name"].ToString());
                    mlViewShipDtl.Items.Add(ds.Rows[0]["Address1"].ToString());
                    mlViewShipDtl.Items.Add(ds.Rows[0]["Address2"].ToString());
                    mlViewShipDtl.Items.Add(ds.Rows[0]["Address3"].ToString());
                    mlViewShipDtl.Items.Add(ds.Rows[0]["PhoneNum"].ToString());
                    mlViewShipDtl.Items.Add(ds.Rows[0]["City"].ToString());
                    mlViewShipDtl.Items.Add(ds.Rows[0]["State"].ToString());
                    mlViewShipDtl.Items.Add(ds.Rows[0]["Country"].ToString());
                }
                else
                {
                    ms.Alerta(this, "El cliente no existe!!!");
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void LoadPrincipal                  ()
        {
            try
            {
                CargarAsesor        ();
                CargarTerritorio    ();
                CargarLab           ();
                CargarLabExw        ();
                CargarMonedaLinea   ();
                CargarMonedaMisc    ();
                CargatTipoCotiz     ();
                CargarCargosMisc    ();
                CargarUOM           ();
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void AgregarLineaDetalle            ()
        {
            try
            {
                if (ValidarAgregarLinea())
                {
                    decimal ValorFinal = (NUnitPrice.Value - NValorDcto.Value) * NCantidad.Value;
                    decimal ValorTrm = 0,iva;
                    if(!string.IsNullOrEmpty(cmbMonedaLinea.Text))
                        if (cmbMonedaLinea.SelectedValue.ToString() != "COP")
                        {
                            string Error = string.Empty;
                            string SQL = "TargetCurrCode = 'COP' AND " +
                                         "EffectiveDate = '" + DateTime.Now.ToString("MM/dd/yyyy") + "' AND Company = '" + sess.CompanyID.ToString() + "' " +
                                         " AND SourceCurrCode = '" + cmbMonedaLinea.SelectedValue.ToString() + "'";
                            var ds = mt.consultaslist(sess, "CurrExRateList", "Erp:BO:CurrExRate", SQL, "CurrentRate", ref Error);
                            if (ds.Rows.Count > 0)
                            {
                                ValorTrm = Convert.ToDecimal(ds.Rows[0]["CurrentRate"]) * NUnitPrice.Value;
                            }
                        }
                        else
                        {
                            ValorTrm = NUnitPrice.Value;
                        }
                    //
                    string impuesto = "0";
                    if (chkImpuesto.Value)
                    {
                        impuesto = "1";
                    }
                    iva = mt.ImpParte(sess, TaxCatId);
                    if (mgProductos.CurrentCell == null)
                    {
                        DSParte.Rows.Add(new object[]
                        {
                            0,                                              //0
                            txtPartNum.Text,                                //1
                            txtPartDesc.Text,                               //2
                            NCantidad.Value,                                //3
                            ValorFinal.ToString() ,                         //4
                            cmbMonedaLinea.SelectedValue.ToString() ,       //5
                            NUnitPrice.Value,                               //6
                            NDctoper.Value,                                 //7
                            NValorDcto.Value,                               //8
                            cmbMonedaLinea.SelectedValue,                   //9
                            txtProdGroup.Text,                              //10
                            cmbUOM.SelectedValue.ToString(),                //11
                            ValorTrm,                                       //12
                            "",                                             //13
                            txtLineObservaciones.Text,                      //14
                            "",                                             //15
                            "",                                             //16
                            "",                                             //17
                            impuesto,                                       //18
                            iva                                             //19
                        });
                        DSParte.AcceptChanges();
                        mgProductos.DataSource = DSParte;
                        //CARGAR PRODUCTOS SUGERIDOS
                        string Error = string.Empty, subPart;
                        decimal CantidadSubPart = 0;
                        string SQL = "Company = '" + sess.CompanyID.ToString() + "' and PartNum = '" + txtPartNum.Text + "'";
                        var dspsug = mt.consultaslistRows(sess, "PartSubs","Erp:BO:Part", SQL, "SubPart,QtyPer", ref Error);
                        if (dspsug.Rows.Count - 1 >= 0)
                        {
                            for (int m = 0; m <= dspsug.Rows.Count-1; m++)
                            {
                                subPart = dspsug.Rows[m]["SubPart"].ToString();
                                CantidadSubPart = Convert.ToDecimal(dspsug.Rows[m]["QtyPer"]);

                                //TRAIGO EL DETALLE DE LAS PARTES
                                SQL = "Company = '" + sess.CompanyID.ToString() + "' and PartNum = '" + subPart + "' and InActive = False";
                                var dsDescSubPart = mt.consultaslistRows(sess, "Part","Erp:BO:Part", SQL, "PartNum,PartDescription,ProdCode,IUM,ClassID,TaxCatId,ShortChar10,Number01", ref Error);
                                if (dsDescSubPart.Rows.Count > 0)
                                {
                                    //saco el % del CATID
                                    decimal cual_ivaOpcional = mt.ImpParte(sess, dsDescSubPart.Rows[0]["TaxCatId"].ToString());


                                    //multiplicar el % de dcto por el precio unitario de la subparte
                                    decimal valor_dcto_linea = (Convert.ToDecimal(dsDescSubPart.Rows[0]["Number01"]) * CantidadSubPart) * (NDctoper.Value / 100);
                                    decimal precio_final_linea = (Convert.ToDecimal(dsDescSubPart.Rows[0]["Number01"]) * CantidadSubPart) - valor_dcto_linea;

                                    DSParte.Rows.Add(new object[]
                                   {
                                   0,                                                                       //0
                                   subPart,                                                                 //1
                                   dsDescSubPart.Rows[0]["PartDescription"].ToString(),                     //2
                                   CantidadSubPart,                                                         //3
                                   precio_final_linea,                                                      //4
                                   dsDescSubPart.Rows[0]["ShortChar10"].ToString(),                         //5
                                   Convert.ToDecimal(dsDescSubPart.Rows[0]["Number01"].ToString()),         //6
                                   NDctoper.Value,                                                          //7
                                   valor_dcto_linea,                                                        //8
                                   dsDescSubPart.Rows[0]["ShortChar10"].ToString(),                         //9
                                   dsDescSubPart.Rows[0]["ProdCode"].ToString(),                            //10
                                   dsDescSubPart.Rows[0]["IUM"].ToString(),                                 //11
                                   Convert.ToDouble(dsDescSubPart.Rows[0]["Number01"].ToString()),          //12
                                   "",                                                                      //13
                                   "",                                                                      //14
                                   txtPartNum.Text,                                                         //15
                                   dsDescSubPart.Rows[0]["ClassID"].ToString(),                             //16
                                   "",                                                                      //17
                                   impuesto,                                                                //18
                                   cual_ivaOpcional                                                         //19
                                   });
                                    DSParte.AcceptChanges();
                                    mgProductos.DataSource = DSParte;
                                }
                            }
                        }
                    }
                    else
                    {
                        mgProductos.CurrentRow.Cells["Id Parte"].Value = txtPartNum.Text;
                        mgProductos.CurrentRow.Cells["Descripcion"].Value = txtPartDesc.Text;
                        mgProductos.CurrentRow.Cells["Cantidad"].Value = NCantidad.Value;
                        mgProductos.CurrentRow.Cells["Precio Final"].Value = ValorFinal.ToString();
                        mgProductos.CurrentRow.Cells["Moneda"].Value = cmbMonedaLinea.SelectedValue.ToString();
                        mgProductos.CurrentRow.Cells["Precio Unitario"].Value = NUnitPrice.Value;
                        mgProductos.CurrentRow.Cells["% Dcto"].Value = NDctoper.Value;
                        mgProductos.CurrentRow.Cells["Valor Dcto"].Value = NValorDcto.Value;
                        mgProductos.CurrentRow.Cells["IdMoneda"].Value = cmbMonedaLinea.SelectedValue.ToString();
                        mgProductos.CurrentRow.Cells["ProdCode"].Value = txtProdGroup.Text;
                        mgProductos.CurrentRow.Cells["UM"].Value = cmbUOM.SelectedValue.ToString();
                        mgProductos.CurrentRow.Cells["Comentario"].Value = txtLineObservaciones.Text;
                        mgProductos.CurrentRow.Cells["CalcularImpuesto"].Value = lblCalcImp.Text;
                        mgProductos.CurrentRow.Cells["IVA"].Value = lblIva.Text;
                    }
                    LimpiaDetalle();
                    txtPartNum.Text = "";
                }
                if (mgProductos.Rows.Count - 1 >= 0)
                {
                    mgProductos.Columns["Descripcion"].Width = 340;
                    //
                    mgProductos.Columns["IdMoneda"].Visible = false;
                    mgProductos.Columns["ProdCode"].Visible = false;
                    mgProductos.Columns["CalcularImpuesto"].Visible = false;
                    mgProductos.Columns["IVA"].Visible = false;
                    mgProductos.Columns["."].Visible = false;
                    mgProductos.Columns["PartePPal"].Visible = false;
                    mgProductos.Columns["ConsecImp"].Visible = false;
                    mgProductos.Columns["AplicaTitulo"].Visible = false;
                    //
                    mgProductos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
                    mgProductos.Columns["Precio Unitario"].DefaultCellStyle.Format = "N2";
                    mgProductos.Columns["% Dcto"].DefaultCellStyle.Format = "N2";
                    mgProductos.Columns["Valor Dcto"].DefaultCellStyle.Format = "N2";
                    mgProductos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
                    mgProductos.Columns["Precio TRM"].DefaultCellStyle.Format = "N2";
                    //
                    mgProductos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    mgProductos.Columns["Precio Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    mgProductos.Columns["% Dcto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    mgProductos.Columns["Valor Dcto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    mgProductos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    mgProductos.Columns["Precio TRM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                Totalizar();
                mgProductos.ClearSelection();
                mgProductos.CurrentCell = null;
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void LimpiaDetalle                  ()
        {
            try
            {
                txtPartDesc.Text = "";
                NUnitPrice.Value = 0;
                cmbUOM.Text = "";
                NValorDcto.Value = 0;
                NCantidad.Value = 0;
                txtProdGroup.Text = "";
                txtLineObservaciones.Text = "";
                chkDesbloquear.Value = false;
                lblIva.Text = string.Empty;
                lblCalcImp.Text = string.Empty;
                TaxCatId = string.Empty;
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void Totalizar                      ()
        {
            string fila = "";
            string SQL = string.Empty;
            int contador = 0,contador1=0;
            for (int k = 0; k <= mgProductos.Rows.Count - 1; k++)
            {
                mgProductos["Fila", k].Value = k + 1;

                decimal ValorTrm = 0;

                //PREGUNTO SI LA MONEDA ES DIFERENTE DE COP PARA CALCULAR EL VALOR CON LA TRM DEL DIA
                if (mgProductos["Moneda", k].Value.ToString() != "COP")
                {
                    string Error = string.Empty;
                    SQL = "TargetCurrCode = 'COP' AND " +
                                 "EffectiveDate = '" + DateTime.Now.ToString("MM/dd/yyyy") + "' AND Company = '" + sess.CompanyID.ToString() + "' " +
                                 " AND SourceCurrCode = '" + cmbMonedaLinea.SelectedValue.ToString() + "'";
                    var ds = mt.consultaslist(sess, "CurrExRateList", "Erp:BO:CurrExRate", SQL, "CurrentRate", ref Error);
                    if (ds.Rows.Count > 0)
                    {
                        ValorTrm = Convert.ToDecimal(ds.Rows[0]["CurrentRate"]) * NUnitPrice.Value;
                    }
                }
                else
                {
                    ValorTrm = Convert.ToDecimal(mgProductos["Precio Final", k].Value.ToString());
                }

                mgProductos["Precio TRM", k].Value = ValorTrm;

                //CALCULO EL CONSEC DE LA IMPRESION
                if (mgProductos["PartePPal", k].Value.ToString() == "")
                {
                    contador = contador + 1;
                    mgProductos["ConsecImp", k].Value = contador;
                    contador1 = 0;

                    if (Convert.ToDecimal(mgProductos["% Dcto", k].Value) != NDctoper.Value)
                    {
                        NDctoper.Value = 0;
                        NValorDcto.Value = 0;
                    }
                }
                else
                {
                    if (k != 0)
                    {
                        if ((mgProductos["PartePPal", k].Value.ToString() == mgProductos["PartePPal", k - 1].Value.ToString()) && (!string.IsNullOrEmpty(mgProductos["PartePPal", k - 1].Value.ToString())))
                        {
                            contador1 = contador1 + 1;
                            fila = contador.ToString() + "." + contador1.ToString();
                            mgProductos["ConsecImp", k].Value = fila;
                        }
                        else
                        {
                            contador1 = 0;
                            contador1 = contador1 + 1;
                            fila = contador.ToString() + "." + contador1.ToString();
                            mgProductos["ConsecImp", k].Value = fila;

                        }
                    }
                }

                //VALIDO QUE PARTE DEBE LLEVAR TITULO
                if ((mgProductos["PartePPal", k].Value.ToString() != "") && (mgProductos["AplicaTitulo", k].Value.ToString() != ""))
                {
                    string cual_parteppal = mgProductos["PartePPal", k].Value.ToString();
                    string cual_calse = mgProductos["AplicaTitulo", k].Value.ToString();
                    if (mgProductos[".", k].Value.ToString() != "0")
                    {
                        mgProductos[".", k].Value = 1;
                        //pregunto a partir de la fila si la clase y la parte ppal es la misma
                        for (int m = k + 1; m <= mgProductos.Rows.Count - 1; m++)
                        {
                            if (mgProductos["PartePPal", m].Value.ToString() == cual_parteppal)
                            {
                                mgProductos[".", m].Value = 0;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            mgProductos.ClearSelection();
            mgProductos.CurrentCell = null;
            Totalizar_Moneda();
        }
        internal void GuardarCotizacion              ()
        {
            try
            {
                if(ValidarGuardado())
                {
                    string Error        = string.Empty;
                    BO.QuoteHed qQuote  = new BO.QuoteHed(sess);
                    Entidades.EntidadesQuoteHed enT = new Entidades.EntidadesQuoteHed();
                    enT.Company         = sess.CompanyID.ToString();
                    enT.sess            = sess;
                    enT.ShipToNum       = txtShipToNum.Text;
                    enT.CustNum         = Convert.ToInt32(CustNum);
                    enT.CustID          = txtCustID.Text;
                    if(!string.IsNullOrEmpty(cmbContacto.Text))
                        enT.ConNum = cmbContacto.SelectedValue.ToString();
                    if(!string.IsNullOrEmpty(cmbAsesor.Text))
                        enT.SalesRepCode = cmbAsesor.SelectedValue.ToString();
                    if(!string.IsNullOrEmpty(cmbTipo.Text))
                        enT.Tipo = cmbTipo.SelectedValue.ToString();
                    enT.LAB             = cmbLAB.SelectedValue.ToString();
                    enT.LABEW           = cmbLABEXW.SelectedValue.ToString();
                    enT.CreateBy        = sess.UserID.ToString();
                    enT.MktgCampaignID  = IDCampana;
                    enT.MktgEvntSeq     = Convert.ToInt32(IDEvento);
                    enT.TerritoryID     = cmbTerritorio.SelectedValue.ToString();
                    enT.RateGrpCode     = "TRM";
                    enT.QuoteComment    = txtObservaciones.Text;
                    if (!qQuote.QuoteExist(sess.CompanyID.ToString(),Convert.ToInt32(txtQuoteNum.Text)))
                    {
                        txtQuoteNum.Text = qQuote.QuoteHead(enT, ref Error).ToString();
                        if (!string.IsNullOrEmpty(Error))
                            ms.Error(this, Error);
                        else
                            GuardarDetalleQuote(Convert.ToInt32(txtQuoteNum.Text));
                    }
                    else
                    {
                        ms.Alerta(this, qQuote.UpdateQuoteHead(enT, Convert.ToInt32(txtQuoteNum.Text)));
                        BloquearControles(true);
                    }
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void GuardarDetalleQuote            (int QuoteNum)
        {
            try
            {
                string Error = string.Empty;
                BO.QuoteHed qQuote = new BO.QuoteHed(sess);
                qQuote.QuoteDtl(QuoteNum, mgProductos, ref Error);
                if (!string.IsNullOrEmpty(Error))
                    ms.Error(this, Error);
                else
                {
                    GuardarCargosMusc(QuoteNum);
                }
                    
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void GuardarCargosMusc              (int QuoteNum)
        {
            try
            {
                string Error = string.Empty;
                BO.QuoteHed qQuote = new BO.QuoteHed(sess);
                qQuote.QuoteMsc(QuoteNum, mgProdMisc, ref Error);
                if (!string.IsNullOrEmpty(Error))
                    ms.Error(this, Error);
                else
                    ms.Alerta(this, "Término el proceso!");
            }
            catch (Exception ex)
            {
                ms.Error(this,ex.Message);
            }
        }
        internal void Totalizar_Moneda               ()
        {
            double total_cotiz = 0;
            string cual_moneda = "";
            bool moneda_existe = false;
            double total_sindcto = 0;
            double valor_dcto = 0;
            double total_iva = 0;
            double porc_iva = 0;

            DSTotales.Clear();
            //TOTALIZO POR MONEDA
            for (int k = 0; k <= mgProductos.Rows.Count - 1; k++)
            {
                cual_moneda = mgProductos["IdMoneda", k].Value.ToString();
                total_cotiz = Convert.ToDouble(mgProductos["Precio Final", k].Value.ToString());
                total_sindcto = Convert.ToDouble(mgProductos["Cantidad", k].Value) * Convert.ToDouble(mgProductos["Precio Unitario", k].Value);
                //total IVA = (PRECIO FINAL * (IVA/100)) + PRECIO FINAL
                if (mgProductos["CalcularImpuesto", k].Value.ToString() == "0")
                {
                    mgProductos["IVA", k].Value = "0";
                }
                if (mgProductos["IVA", k].Value.ToString() == "")
                {
                    mgProductos["IVA", k].Value = "0";
                }
                //valido si la cotizacion es INTERNACIONAL PARA NO CALCULAR IVA
                if (cmbTipo.SelectedValue.ToString() == "I")
                {
                    porc_iva = 0;
                }
                else
                {
                    porc_iva = Convert.ToDouble(mgProductos["IVA", k].Value);
                }

                total_iva = (Convert.ToDouble(mgProductos["Precio Final", k].Value) * (porc_iva / 100)) + Convert.ToDouble(mgProductos["Precio Final", k].Value);

                moneda_existe = false;
                //VALIDO QUE NO ESTÉ ENLA GRID DE MONEDAS
                for (int h = 0; h < mgTotales.Rows.Count; h++)
                {
                    if (cual_moneda == mgTotales[0, h].Value.ToString())
                    {
                        moneda_existe = true;
                        break;
                    }
                }

                if (moneda_existe == false)
                {
                    //recorro la lista a apartir de la fila en la que estoy parado mas 1
                    for (int y = k + 1; y < mgProductos.Rows.Count; y++)
                    {
                        if (cual_moneda == mgProductos["IdMoneda", y].Value.ToString())
                        {
                            total_cotiz = total_cotiz + Convert.ToDouble(mgProductos["Precio Final", y].Value.ToString());
                            total_sindcto = total_sindcto + (Convert.ToDouble(mgProductos["Cantidad", y].Value) * Convert.ToDouble(mgProductos["Precio Unitario", y].Value));
                            if (mgProductos["CalcularImpuesto", y].Value.ToString() == "0")
                            {
                                mgProductos["IVA", y].Value = "0";
                            }
                            if (mgProductos["IVA", y].Value.ToString() == "")
                            {
                                mgProductos["IVA", y].Value = "0";
                            }
                            if (cmbTipo.SelectedValue.ToString() == "I")
                            {
                                porc_iva = 0;
                            }
                            else
                            {
                                porc_iva = Convert.ToDouble(mgProductos["IVA", y].Value);
                            }
                            total_iva = total_iva + (Convert.ToDouble(mgProductos["Precio Final", y].Value) * (porc_iva / 100)) + Convert.ToDouble(mgProductos["Precio Final", y].Value);
                        }
                    }

                    valor_dcto = total_sindcto - total_cotiz;

                    //cargo la moneda mas el valor en la grid TOTALES
                    DSTotales.Rows.Add(new object[]
                        {
                            cual_moneda, total_sindcto, valor_dcto, total_cotiz, total_iva
                        });
                    DSTotales.AcceptChanges();
                    mgTotales.DataSource = DSTotales;
                    if (mgTotales.Rows.Count - 1 >= 0)
                    {
                        mgTotales.Columns["Antes Dcto"].Visible = false;
                        mgTotales.Columns["Valor Dcto"].Visible = false;
                        mgTotales.Columns["Antes de Impuesto"].Visible = false;
                        //
                        mgTotales.Columns["Total Final"].DefaultCellStyle.Format = "N2";
                        mgTotales.Columns["Total Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
        }
        internal void BuscarInfoQuotiz               (int QuoteNum)
        {
            try
            {
                mlNuevo.Enabled = false;
                mlModificar.Enabled = true;
                mlimprimir.Enabled = true;
                mlCreateOrden.Enabled = true;
                mlCancelar.Enabled = true;
                //
                string Error = string.Empty;
                BO.QuoteHed qQuote = new BO.QuoteHed(sess);
                var dQuote = qQuote.dQuote(QuoteNum, ref Error);
                if (!string.IsNullOrEmpty(Error))
                {
                    ms.Alerta(this, Error);
                }
                else
                {
                    foreach (Erp.BO.QuoteDataSet.QuoteHedRow dr in dQuote.QuoteHed)
                    {
                        txtQuoteNum.Text = dr.QuoteNum.ToString();
                        cmbTipo.SelectedValue = dr["ShortChar01"].ToString();
                        CustNum = dr.CustNum.ToString();
                        txtCustID.Text = dr.BTCustID.ToString();
                        //
                        CargaInfoCliente(txtCustID.Text);
                        txtShipToNum.Text = dr.ShipToNum;
                        CargarContactoCliente(CustNum);
                        if (!string.IsNullOrEmpty(txtShipToNum.Text))
                        {
                            BO.Metodos mt = new BO.Metodos();
                            var dt = mt.consultaslist(sess, "ShipToList", "Erp:BO:ShipTo", "Company = '" + sess.CompanyID.ToString() + "' and CustNum = '" + CustNum + "' and ShipToNum = '" + txtShipToNum.Text + "'", "Name,Address1,Address2,Address3,PhoneNum,City,State,Country", ref Error);
                            if (dt.Rows.Count - 1 >= 0)
                            {
                                mlViewShipDtl.Items.Add(dt.Rows[0]["Name"].ToString());
                                mlViewShipDtl.Items.Add(dt.Rows[0]["Address1"].ToString());
                                mlViewShipDtl.Items.Add(dt.Rows[0]["Address2"].ToString());
                                mlViewShipDtl.Items.Add(dt.Rows[0]["Address3"].ToString());
                                mlViewShipDtl.Items.Add(dt.Rows[0]["PhoneNum"].ToString());
                                mlViewShipDtl.Items.Add(dt.Rows[0]["City"].ToString());
                                mlViewShipDtl.Items.Add(dt.Rows[0]["State"].ToString());
                                mlViewShipDtl.Items.Add(dt.Rows[0]["Country"].ToString());
                            }
                        }
                        dtpFecha.Value = dr.EntryDate;
                        cmbLAB.SelectedValue = dr["ShortChar02"].ToString();
                        cmbLABEXW.SelectedValue = dr["ShortChar04"].ToString();
                        //
                        cmbTerritorio.SelectedValue = dr.TerritoryID;
                        IDCampana = dr.MktgCampaignID;IDEvento = dr.MktgEvntSeq.ToString();
                        txtCampana.Text = dr.MktgCpgnCampDescription;
                        txtEvento.Text = dr.MktgEventEvntDescription;
                        txtCaso.Text = dr.HDCaseNum.ToString();
                        txtObservaciones.Text = dr.QuoteComment;
                    }
                    foreach (Erp.BO.QuoteDataSet.QSalesRPRow dr in dQuote.QSalesRP)
                    {
                        if (dr.PrimeRep)
                        {
                            cmbAsesor.SelectedValue = dr.SalesRepCode;
                        }
                    }
                    foreach (Erp.BO.QuoteDataSet.QuoteCntRow dr in dQuote.QuoteCnt)
                    {
                        cmbContacto.SelectedValue = dr.ConNum;
                        txtContacto.Text = dr.Func;
                        lblTelContact.Text = dr.PhoneNum;
                    }
                    foreach (Erp.BO.QuoteDataSet.QuoteDtlRow dr in dQuote.QuoteDtl)
                    {
                        DSParte.Rows.Add(new object[]
                        {
                            dr.QuoteLine, 
                            dr.PartNum,
                            dr.LineDesc,
                            dr.SellingExpectedQty,
                            ((dr.ListPrice-dr.Discount)*dr.SellingExpectedQty),
                            dr["ShortChar02"].ToString(),
                            dr.ListPrice,
                            dr.DiscountPercent,
                            dr.Discount,
                            dr["ShortChar02"].ToString(),
                            dr.ProdCode,
                            dr.SellingExpectedUM,
                            0,
                            Convert.ToDecimal(dr["Number01"]),
                            dr.QuoteComment,
                            dr["ShortChar03"].ToString(),
                            "" ,                                    //CLASE
                            "" ,                                     
                            dr["ShortChar04"].ToString(),
                            Convert.ToDecimal(dr["Number02"])
                        });
                        DSParte.AcceptChanges();
                        mgProductos.DataSource = DSParte;
                        //
                        mgProductos.Columns["Descripcion"].Width = 340;
                    }
                    foreach (Erp.BO.QuoteDataSet.QuoteHedMscRow dr in dQuote.QuoteHedMsc)
                    {
                        DSMiscelaneo.Rows.Add(new object[]
                        {
                            dr.SeqNum,
                            dr.Description,
                            dr.DocMiscAmt,
                            dr.CurrencyCode,
                            dr["ShortChar01"].ToString(),
                            dr.MiscCode
                        });
                        DSMiscelaneo.AcceptChanges();
                        mgProdMisc.DataSource = DSMiscelaneo;
                    }
                    Totalizar();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void mlModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CustNum))
            {
                BloquearControles(true);
                mlNuevo.Enabled = false;
            }
        }

        private void mlCreateOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtQuoteNum.Text))
                {
                    ms.Alerta(this,"Debe elegir una cotización");
                }
                else
                {
                    if (ms.Pregunta(this, "Esta seguro de crear la orden?") == DialogResult.Yes)
                    {
                        BO.Metodos mt = new BO.Metodos();
                        string Error = string.Empty;
                        var dt = mt.consultaslist(sess, "CustomerList", "Erp:BO:Customer", "Company = '" + sess.CompanyID.ToString() + "' and CustNum = '" + CustNum + "' and CreditHold = True", "CreditHold", ref Error);
                        if (dt.Rows.Count -1 >= 0)
                        {
                            ms.Alerta(this,"ATENCIÓN!!!: No se puede crear la orden de Venta porque el cliente " + txtCustID.Text + " tiene crédito Retenido. Por favor contactar a Cartera");
                        }
                        else
                        {
                            BO.SalesOrder sl = new BO.SalesOrder();
                            ms.Alerta(this,sl.Conectar(mgProductos, txtCustID.Text, sess));
                            BloquearControles(false);
                            //
                            mlNuevo.Enabled = false;
                            mlModificar.Enabled = true;
                            mlimprimir.Enabled = true;
                            mlCreateOrden.Enabled = true;
                            mlCancelar.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        internal void mlimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtQuoteNum.Text))
                {
                    WebClient wb = new WebClient();
                    wb.Credentials = CredentialCache.DefaultCredentials;
                    string Ruta = @"\\JAKE\EpicorData\CustomReports\Epicor\Cotizacion\Cotizaciones\Cotizacion"+txtQuoteNum.Text+".pdf";
                    wb.DownloadFile("http://toruk/Reportserver/reports/CustomReports/QuoteReports.rdl?%2freports/CustomReports%2fQuoteReports&rs:Format=PDF&Company=" + sess.CompanyID.ToString() + "&QuoteNum=" + txtQuoteNum.Text + "&Totales=" + chkTotales.Value + "", Ruta);
                    System.Diagnostics.Process.Start(Ruta);
                }
                else
                {
                    ms.Alerta(this, "Ingrese una cotización");txtQuoteNum.Focus();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        internal void LineasCargo                    ()
        {
            for (int k = 0; k <= mgProdMisc.Rows.Count - 1; k++)
            {
                mgProdMisc["Fila", k].Value = k + 1;
            }
        }
        internal bool ValidarAgregarLinea            ()
        {
            bool Pass = true;
            try
            {
                if (string.IsNullOrEmpty(txtPartNum.Text) || string.IsNullOrEmpty(txtPartDesc.Text))
                {
                    ms.Alerta(this,"Debe ingresar la información completa de la parte:  ID y Descripción");
                    return false;
                }
                if (NUnitPrice.Value == 0)
                {
                    ms.Alerta(this,"Debe ingresar el precio de la parte");
                    return false;
                }
                if (NCantidad.Value == 0)
                {
                    ms.Alerta(this,"Debe ingresar una cantidad válida");
                    return false;
                }
                if (cmbMonedaLinea.Text == "")
                {
                    ms.Alerta(this,"Debe elegir una moneda");
                    return false;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
            return Pass;
        }
        internal bool ValidarGuardado                ()
        {
            bool Pass = true;
            try
            {
                if (string.IsNullOrEmpty(txtCustID.Text))
                {
                    ms.Alerta(this,"Debe ingresar un cliente para la cotizacíón");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbTipo.Text))
                {
                    ms.Alerta(this,"Debe elegir el tipo de Cotización");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbTerritorio.Text))
                {
                    ms.Alerta(this,"Debe ingresar el territorio del cliente");
                    return false;
                }

                if (string.IsNullOrEmpty(cmbAsesor.Text))
                {
                    ms.Alerta(this,"Debe ingresar el Asesor Comercial del cliente");
                    return false;
                }
                if (mgProductos.Rows.Count == 0)
                {
                    ms.Alerta(this,"Debe ingresar al menos una Parte a Cotizar");
                    return false;
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
