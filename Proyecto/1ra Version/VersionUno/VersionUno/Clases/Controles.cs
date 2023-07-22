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
            // Verificar si la tecla presionada no es un dígito ni un carácter de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Mostrar un mensaje de error utilizando un ErrorProvider
                errorProvider.SetError(tbUser, "Solo se aceptan números sin espacios");
                e.Handled = true; // Marcar el evento como manejado para evitar la entrada del carácter no válido
            }
            else
            {
                errorProvider.Clear(); // Limpiar el mensaje de error si el carácter es válido
            }
        }

        public static void ValidarLargo(KeyPressEventArgs e, ErrorProvider errorProvider, TextBox textBox, int maxLength)
        {
            // Controlar que no se supere la longitud máxima permitida en el TextBox
            if (textBox.SelectionLength == textBox.TextLength && textBox.TextLength != 0)
            {
                // Permitir la sobrescritura cuando se selecciona todo el texto en el TextBox
                e.Handled = false;
            }
            else if (textBox.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                // Mostrar un mensaje de error si se intenta ingresar más caracteres que la longitud máxima permitida
                errorProvider.SetError(textBox, $"Use un pin de {maxLength} caracteres");
                e.Handled = true; // Marcar el evento como manejado para evitar la entrada del carácter no válido
            }
            else
            {
                errorProvider.Clear(); // Limpiar el mensaje de error si la longitud es válida
            }
        }

    }
}
