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
    public partial class frmSearchCampana : MetroFramework.Forms.MetroForm
    {
        public frmSearchCampana()
        {
            InitializeComponent();
        }
        BO.BOMensajes ms = new BO.BOMensajes();
        public string IDCampana;
        public string Campana;
        public Ice.Core.Session sess;
        BO.Metodos mt = new BO.Metodos();
        //
        internal void frmSearchCampana_Load(object sender, EventArgs e)
        {
            txtIDCampana.Focus();
        }
        internal void Buscar()
        {
            try
            {
                string SQL = "Company = '" + sess.CompanyID.ToString() + "'";
                if (!string.IsNullOrEmpty(txtIDCampana.Text))
                {
                    SQL += " and MktgCampaignID LIKE '%" + txtIDCampana.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    SQL += " and CampDescription LIKE '%" + txtNombre.Text + "%'";
                }
                //
                string Error = string.Empty;
                var ds = mt.consultaslist(sess,"MktgCampList", "Erp:BO:MktgCamp", SQL, "MktgCampaignID,CampDescription", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    mgResultados.DataSource = ds;
                    //
                    mgResultados.Columns["MktgCampaignID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void mtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgResultados.Rows.Count - 1 >= 0)
                {
                    IDCampana = mgResultados.CurrentRow.Cells["MktgCampaignID"].Value.ToString();
                    Campana = mgResultados.CurrentRow.Cells["CampDescription"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        internal void mgResultados_DoubleClick(object sender, EventArgs e)
        {
            mtOK.PerformClick();
        }

        internal void mtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        internal void txtIDCampana_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtIDCampana.Text = string.Empty;
        }

        private void txtIDCampana_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDCampana.Text))
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
    }
}
