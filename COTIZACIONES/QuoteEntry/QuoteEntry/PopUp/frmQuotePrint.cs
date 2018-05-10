using Microsoft.Reporting.WinForms;
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
    public partial class frmQuotePrint : MetroFramework.Forms.MetroForm
    {
        public frmQuotePrint()
        {
            InitializeComponent();
        }
        //
        public int QuoteNum;
        public Entidades.EntidadesQuoteHed enT;
        public Ice.Core.Session sess;
        //
        BO.BOMensajes ms = new BO.BOMensajes();

        internal void Consulta()
        {
            try
            {
                BO.Metodos mt = new BO.Metodos();
                string Error = string.Empty;
               
                
                
                rpt.Visible = true;
            }
            catch (Exception ex)
            {
                ms.Error(this, ex.Message);   
            }
        }
        private void frmQuotePrint_Load(object sender, EventArgs e)
        {
            Consulta();
            this.rpt.RefreshReport();
        }
    }
}
