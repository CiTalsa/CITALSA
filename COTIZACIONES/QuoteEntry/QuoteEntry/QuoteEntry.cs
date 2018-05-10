using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteEntry
{
    public class QuoteEntry
    {
        public MetroFramework.Controls.MetroUserControl controler(Ice.Core.Session sess)
        {
            UserControls.ucQuoteEntry ucQuote = new UserControls.ucQuoteEntry();
            ucQuote.sess = sess;
            ucQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            return ucQuote;
        }
    }
}
