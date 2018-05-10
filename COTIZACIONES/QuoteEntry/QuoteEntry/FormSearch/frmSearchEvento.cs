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
    public partial class frmSearchEvento : MetroFramework.Forms.MetroForm
    {
        public frmSearchEvento()
        {
            InitializeComponent();
        }
        BO.BOMensajes ms = new BO.BOMensajes();
        public string IDEvento, Evento;
        public Ice.Core.Session sess;
        BO.Metodos mt = new BO.Metodos();

        internal void frmSearchEvento_Load(object sender, EventArgs e)
        {
            txtIDEvento.Focus();
        }

        private void mtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgResultados.Rows.Count - 1 >= 0)
                {
                    IDEvento = mgResultados.CurrentRow.Cells["MktgCampaignID"].Value.ToString();
                    Evento = mgResultados.CurrentRow.Cells["EvntDescription"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void mgResultados_DoubleClick(object sender, EventArgs e)
        {
            mtOK.PerformClick();
        }

        private void mtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtIDEvento_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtIDEvento.Text = string.Empty;
        }

        private void txtIDEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDEvento.Text))
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

        internal void Buscar()
        {
            try
            {
                string SQL = "Company = '" + sess.CompanyID.ToString() + "'";
                if (!string.IsNullOrEmpty(txtIDEvento.Text))
                {
                    SQL += " and MktgCampaignID LIKE '%" + txtIDEvento.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    SQL += " and EvntDescription LIKE '%" + txtNombre.Text + "%'";
                }
                //
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "MktgEvntList", "Erp:BO:MktgEvnt", SQL, "MktgCampaignID,EvntDescription", ref Error);
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
    }
}
