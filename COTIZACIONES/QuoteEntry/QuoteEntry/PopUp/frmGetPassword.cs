using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuoteEntry.PopUp
{
    public partial class frmGetPassword : MetroFramework.Forms.MetroForm
    {
        public frmGetPassword()
        {
            InitializeComponent();
        }
        //
        public bool Pasa = false;
        BO.BOMensajes ms = new BO.BOMensajes();
        //
        private void frmGetPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void mtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    Pasa = false;
                    if (txtPassword.Text == Configuracion.Config.Default.Password)
                    {
                        Pasa = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);    
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    mtOK.PerformClick();
                }
            }
        }
    }
}
