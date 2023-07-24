﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionUno.Clases
{
    internal class NumPad
    {
        
        private static void agregarNumero(string numero, TextBox textbox)
        {
            
            textbox.Text += numero;
            //  Poner el caret (simbolo que parpadea) despues del ultimo caracter
            //  Esto debido a que al pulsar cualquier boton en el NumPad causa que se quite el foco del textbox, generando conflictos con el timer
            textbox.Select(textbox.Text.Length, 0);
            textbox.Focus();
            textbox.ScrollToCaret();
        }

        public static void AccionBoton(Button btnNum, TextBox tbUser, TextBox tbPassword, ErrorProvider errorProvider, ErrorProvider errorProvider2, int textBoxSeleccionado)
        {

            NumPad numPad = new NumPad();

            if (textBoxSeleccionado == 1)
            {
                
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {

                    errorProvider.Clear();
                    agregarNumero(btnNum.Text, tbUser);

                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider2.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum.Text, tbPassword);
                }
            }
        }



    }
}
