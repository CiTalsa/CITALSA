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
    public partial class frmShipTo : MetroFramework.Forms.MetroForm
    {
        public frmShipTo()
        {
            InitializeComponent();
        }
        BO.BOMensajes ms = new BO.BOMensajes();
        public string CustNum, ShipToNum;
        public MetroFramework.Controls.MetroGrid dShip;
        public Ice.Core.Session sess;
        BO.Metodos mt = new BO.Metodos();
        private void frmShipTo_Load(object sender, EventArgs e)
        {
            Consultar("");
        }

        internal void mtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (mgResultados.Rows.Count - 1 >= 0)
                {
                    ShipToNum = mgResultados.CurrentRow.Cells["ShipToNum"].Value.ToString();
                    dShip = mgResultados;
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
            try
            {
                if (!string.IsNullOrEmpty(txtIDSucursal.Text))
                {
                    Consultar(txtIDSucursal.Text);
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }

        private void txtIDSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDSucursal.Text))
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

        internal void Consultar(string ShipToNum)
        {
            try
            {
                string SQL = "Company = '" + sess.CompanyID.ToString() + "' and CustNum = '"+CustNum+"'";
                if (!string.IsNullOrEmpty(ShipToNum))
                {
                    SQL += " and ShipToNum LIKE '%"+ShipToNum+"%'";
                }
                //
                string Error = string.Empty;
                var ds = mt.consultaslistRows(sess, "ShipTo", "Erp:BO:ShipTo", SQL, "ShipToNum, Address1, Address2, Address3, PhoneNum, Name, City, State, Country", ref Error);
                if (ds.Rows.Count - 1 >= 0)
                {
                    mgResultados.DataSource = ds;
                    //
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);
            }
        }
    }
}
