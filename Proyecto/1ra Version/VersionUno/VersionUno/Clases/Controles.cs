using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionUno.Clases
{
    internal class Controles
    {
        public static void ValidarNumerico(KeyPressEventArgs e, TextBox tbUser, ErrorProvider errorProvider)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                errorProvider.SetError(tbUser, "Solo se aceptan números sin espacios");
                e.Handled = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        public static void ValidarLargo(KeyPressEventArgs e, ErrorProvider errorProvider, TextBox textBox, int maxLength)
        {
            if (textBox.SelectionLength == textBox.TextLength)
            {
              e.Handled = false;
            }else if (textBox.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                errorProvider.SetError(textBox, $"Use un pin de {maxLength} caracteres");
                e.Handled = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }


    }
}
