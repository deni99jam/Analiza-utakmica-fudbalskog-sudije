using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizaUtakmica.Klase
{
    public class Validator
    {
        public static bool ValidirajKontrolu(Control control, ErrorProvider err, string poruka)
        {
            if (control is TextBox)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    err.SetError(control, poruka);
                    return false;
                }
            }
            else if (control is ComboBox)
            {
                var cmb = control as ComboBox;
                if (string.IsNullOrEmpty(cmb.Text) || cmb.SelectedIndex < 0)
                {
                    err.SetError(control, poruka);
                    return false;
                }
            }
            else if (control is PictureBox)
            {
                var pb = control as PictureBox;
                if (pb.Image == null)
                {
                    err.SetError(control, poruka);
                    return false;
                }
            }
            else if (control is DateTimePicker)
            {
                var dtp = control as DateTimePicker;
                if (dtp.Value > DateTime.Now)
                {
                    err.SetError(control, poruka);
                    return false;
                }
            }

            err.Clear();
            return true;
        }
    }
}
