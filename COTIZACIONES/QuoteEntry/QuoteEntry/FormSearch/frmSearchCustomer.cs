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
    public partial class frmSearchCustomer : MetroFramework.Forms.MetroForm
    {
        public frmSearchCustomer()
        {
            InitializeComponent();
        }
        BO.BOMensajes ms = new BO.BOMensajes();
        public string CustNum;
        public string CustID;
        public string CustName;
        public Ice.Core.Session sess;
        BO.Metodos mt = new BO.Metodos();

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            txtNit.Focus();
        }

        internal void Buscar()
        {
            try
            {
                string SQL = "Company = '" + sess.CompanyID.ToString() + "'";
                if (!string.IsNullOrEmpty(txtNit.Text))
                {
                    SQL += " and ResaleID LIKE '%" + txtNit.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtIDCustomer.Text))
                {
                    SQL += " and CustID LIKE '%" + txtIDCustomer.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    SQL += " and Name LIKE '%" + txtNombre.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtTelefono.Text))
                {
                    SQL += " and PhoneNum LIKE '%" + txtTelefono.Text + "%'";
                }
                //
                string Error = string.Empty;
                var ds = mt.consultaslistRows(sess, "Customer", "Erp:BO:Customer", SQL, "CustNum,CustID,Name,ResaleID,PhoneNum", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    mgResultados.DataSource = ds;
                    //
                    mgResultados.Columns["CustNum"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void mtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void mgResultados_DoubleClick(object sender, EventArgs e)
        {
            mtOK.PerformClick();
        }

        private void mtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgResultados.Rows.Count - 1 >= 0)
                {
                    CustNum = mgResultados.CurrentRow.Cells["CustNum"].Value.ToString();
                    CustID = mgResultados.CurrentRow.Cells["CustID"].Value.ToString();
                    CustName = mgResultados.CurrentRow.Cells["Name"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
            txtIDCustomer.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void txtIDCustomer_TextChanged(object sender, EventArgs e)
        {
            txtNit.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNit.Text = string.Empty;
            txtIDCustomer.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtNit.Text = string.Empty;
            txtIDCustomer.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNit.Text))
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

        private void txtIDCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDCustomer.Text))
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTelefono.Text))
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
