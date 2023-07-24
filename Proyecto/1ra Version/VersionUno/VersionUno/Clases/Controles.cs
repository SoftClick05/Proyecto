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
        public static void ValidarIngreso(KeyPressEventArgs e, TextBox tbUser, ErrorProvider errorProvider)
        {
            // Verificar si la tecla presionada no es un dígito ni un carácter de control
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                // Mostrar un mensaje de error utilizando un ErrorProvider
                errorProvider.SetError(tbUser, "No se acepta el ingreso por teclado");
                e.Handled = true; // Marcar el evento como manejado para evitar la entrada del carácter no válido
            }
            else
            {
                errorProvider.Clear(); // Limpiar el mensaje de error si el carácter es válido
            }
        }

    }
}
