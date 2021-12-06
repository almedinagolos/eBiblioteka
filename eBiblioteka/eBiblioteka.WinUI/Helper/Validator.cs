using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiblioteka.WinUI.Helper
{
    class Validator
    {
        public static bool ValidirajKontrolu(Control kontrola, ErrorProvider err, string poruka)
        {
            bool _setError = false;
            if (kontrola is ComboBox cbx && (string.IsNullOrEmpty(cbx.Text) || cbx.SelectedIndex == -1))
                _setError = true;
            else if (kontrola is TextBox txt && string.IsNullOrEmpty(txt.Text))
                _setError = true;

            if (_setError)
            {
                err.SetError(kontrola, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
