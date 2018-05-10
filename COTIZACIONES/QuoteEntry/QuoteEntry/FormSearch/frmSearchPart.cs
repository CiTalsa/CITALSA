using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuoteEntry.FormSearch
{
    public partial class frmSearchPart : MetroFramework.Forms.MetroForm
    {
        public frmSearchPart()
        {
            InitializeComponent();
        }
        BO.BOMensajes ms = new BO.BOMensajes();
        public string PartNum,PartDesc,ProdGroup,UOM,Currenty, TaxCatId;
        public decimal UnitPrice;
        public Ice.Core.Session sess;

        private void mtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgResultados.Rows.Count - 1 >= 0)
                {
                    PartNum = mgResultados.CurrentRow.Cells["PartNum"].Value.ToString();
                    PartDesc = mgResultados.CurrentRow.Cells["PartDescription"].Value.ToString();
                    ProdGroup = mgResultados.CurrentRow.Cells["ProdCode"].Value.ToString();
                    UOM = mgResultados.CurrentRow.Cells["IUM"].Value.ToString();
                    Currenty = mgResultados.CurrentRow.Cells["ShortChar10"].Value.ToString();
                    UnitPrice = Convert.ToDecimal(mgResultados.CurrentRow.Cells["Number01"].Value);
                    TaxCatId = mgResultados.CurrentRow.Cells["TaxCatId"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void txtPartNum_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtPartNum.Text = string.Empty;
        }

        private void mgResultados_DoubleClick(object sender, EventArgs e)
        {
            mtOK.PerformClick();
        }

        private void txtPartNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPartNum.Text))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                        mtBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                        mtBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        BO.Metodos mt = new BO.Metodos();
        private void frmSearchPart_Load(object sender, EventArgs e)
        {
            txtPartNum.Focus();
        }

        private void mtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        internal void Buscar()
        {
            try
            {
                string SQL = "Company = '" + sess.CompanyID.ToString() + "'";
                if (!string.IsNullOrEmpty(txtPartNum.Text))
                {
                    SQL += " and PartNum LIKE '%" + txtPartNum.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    SQL += " and PartDescription LIKE '%" + txtNombre.Text + "%'";
                }
                //
                string Error = string.Empty;
                var ds = mt.consultaslistRows(sess, "Part","Erp:BO:Part", SQL, "PartNum,PartDescription,ProdCode,IUM,ClassID,TaxCatId,ShortChar10,Number01", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    mgResultados.DataSource = ds;
                    //
                    mgResultados.Columns["ClassID"].Visible = false;
                    mgResultados.Columns["Number01"].Visible = false;
                    mgResultados.Columns["ShortChar10"].Visible = false;
                    mgResultados.Columns["IUM"].Visible = false;
                    mgResultados.Columns["ProdCode"].Visible = false;
                    mgResultados.Columns["TaxCatId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
    }
}
