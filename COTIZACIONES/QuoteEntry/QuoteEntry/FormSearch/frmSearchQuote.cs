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
    public partial class frmSearchQuote : MetroFramework.Forms.MetroForm
    {
        public frmSearchQuote()
        {
            InitializeComponent();
        }
        BO.BOMensajes ms = new BO.BOMensajes();
        public int QuoteNum,CustNum;
        public Ice.Core.Session sess;
        BO.Metodos mt = new BO.Metodos();

        private void frmSearchQuote_Load(object sender, EventArgs e)
        {
            txtQuoteNum.Focus();
        }
        internal void Buscar()
        {
            try
            {
                string SQL = "Company = '" + sess.CompanyID.ToString() + "' and EntryDate >= '"+Convert.ToDateTime(dtpfechaI.Value).ToString("yyyy-MM-dd") + "' and EntryDate <= '"+ Convert.ToDateTime(dtpfechaF.Value).ToString("yyyy-MM-dd") + "'";
                if (!string.IsNullOrEmpty(txtQuoteNum.Text))
                {
                    SQL += " and QuoteNum LIKE '%" + txtQuoteNum.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtIDCliente.Text))
                {
                    SQL += " and CustNum = '" + CustNum.ToString() + "'";
                }
                //
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "QuoteHedList", "Erp:BO:Quote", SQL, "QuoteNum,CustomerName,EntryDate", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    mgResultados.DataSource = ds;
                    mgResultados.Columns["QuoteNum"].Width = 100;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        private void mtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgResultados.Rows.Count - 1 >= 0)
                {
                    QuoteNum = Convert.ToInt32(mgResultados.CurrentRow.Cells["QuoteNum"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        internal void mtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void mgResultados_DoubleClick(object sender, EventArgs e)
        {
            mtOK.PerformClick();
        }

        private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDCliente.Text))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                        BuscarCliente(txtIDCliente.Text);
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
        internal void BuscarCliente(string CustID)
        {
            try
            {
                BO.Metodos mt = new BO.Metodos();
                string Error = string.Empty;
                var ds = mt.consultaslist(sess, "CustomerList", "Erp:BO:Customer", "Company = '" + sess.CompanyID.ToString() + "' and CustID LIKE '%" + CustID + "%'", "CustNum,CustID,Name", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    CustNum = Convert.ToInt32(ds.Rows[0]["CustNum"]);
                    txtIDCliente.Text = ds.Rows[0]["CustID"].ToString();
                    txtNombre.Text = ds.Rows[0]["Name"].ToString();
                    mtBuscar.PerformClick();
                }
                else
                {
                    ms.Alerta(this, "El cliente no existe");
                    txtIDCliente.Text = string.Empty;
                    txtIDCliente.Focus();
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void txtQuoteNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuoteNum.Text))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    mtBuscar.PerformClick();
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                FormSearch.frmSearchCustomer frmC = new frmSearchCustomer();
                frmC.sess = sess;
                if (frmC.ShowDialog() == DialogResult.OK)
                {
                    CustNum = Convert.ToInt32(frmC.CustNum);
                    txtIDCliente.Text = frmC.CustID;
                    txtNombre.Text = frmC.CustName;
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
    }
}
