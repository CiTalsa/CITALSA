using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuoteEntry.BO
{
    public class BOMensajes
    {
        public void Alerta(IWin32Window obj, string Mensaje)
        {
            MetroFramework.MetroMessageBox.Show(obj, "\n\n" + Mensaje, "ALERTA DE PROCESO | EPICOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Error(IWin32Window obj, string Mensaje)
        {
            MetroFramework.MetroMessageBox.Show(obj, "\n\n" + Mensaje, "ERROR DE PROCESO | EPICOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult Pregunta(IWin32Window obj, string Mensaje)
        {
            return MetroFramework.MetroMessageBox.Show(obj, "\n\n" + Mensaje, "PREGUNTA DE PROCESO | EPICOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
