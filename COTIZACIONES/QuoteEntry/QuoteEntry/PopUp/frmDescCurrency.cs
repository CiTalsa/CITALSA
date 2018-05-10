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
    public partial class frmDescCurrency : MetroFramework.Forms.MetroForm
    {
        public frmDescCurrency()
        {
            InitializeComponent();
        }
        public DataTable dsMonedas;

        private void frmDescCurrency_Load(object sender, EventArgs e)
        {
            if (dsMonedas.Rows.Count - 1 >= 0)
            {
                mgMonedas.DataSource = dsMonedas;
                //
                mgMonedas.Columns["Antes Dcto"].DefaultCellStyle.Format = "N2";
                mgMonedas.Columns["Valor Dcto"].DefaultCellStyle.Format = "N2";
                mgMonedas.Columns["Antes de Impuesto"].DefaultCellStyle.Format = "N2";
                mgMonedas.Columns["Total Final"].DefaultCellStyle.Format = "N2";
                //
                mgMonedas.Columns["Antes Dcto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                mgMonedas.Columns["Valor Dcto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                mgMonedas.Columns["Antes de Impuesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                mgMonedas.Columns["Total Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}
