using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VersionUno.Clases;
using VersionUno.Ventanas;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
<<<<<<< HEAD
=======
using System.Xml.Linq;
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a

namespace VersionUno
{
    public partial class Totem : Form
    {
        
        public Totem()
        {
            InitializeComponent();
            //btnIngresar por defecto del formulario
            //this.AcceptButton = btnIngresar;
        }


<<<<<<< HEAD
        int posicionActualPanelXUser = 0;
        int posicionActualPanelYUser = 0;

        int posicionActualPanelXPasswd = 0;
        int posicionActualPanelYPasswd = 0;

        bool numPadVisible = false;
        // 1=User
        // 2=Passwd
        int textBoxSeleccionado = 0;

=======
        private int posicionActualPanelXUser = 0;
        private int posicionActualPanelYUser = 0;

        private int posicionActualPanelXPasswd = 0;
        private int posicionActualPanelYPasswd = 0;

        private bool numPadVisible = false;

        private int textBoxSeleccionado = 0;
        // 1=User
        // 2=Passwd
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        private void NumPadTimer_Tick(object sender, EventArgs e)
        {
            if (numPadVisible == false)
            {
                posicionActualPanelYUser = panelTxtUser.Location.Y;

<<<<<<< HEAD
                posicionActualPanelYPasswd = panelTxtPasswd.Location.Y;

                PanelNumPad.BringToFront();
                PanelNumPad.Top -= 60;
                PanelNumPad.Height += 60;
                if (PanelNumPad.Size == PanelNumPad.MaximumSize && tbUser.Focused == true)
                {
                    numPadVisible = true;
                    int coordenadaNueva = PanelNumPad.Location.Y - panelTxtUser.Size.Height;
                    panelTxtUser.Location = new System.Drawing.Point(panelTxtUser.Location.X, coordenadaNueva);
                    NumPadTimer.Stop();
                    textBoxSeleccionado = 1;
=======
                posicionActualPanelYPasswd = panelConjunto.Location.Y;

                PanelNumPad.BringToFront();
                PanelNumPad.Top -= 40;
                PanelNumPad.Height += 40;
                if (PanelNumPad.Size == PanelNumPad.MaximumSize && tbUser.Focused == true)
                {
                    numPadVisible = true;

                    //Obtiene la ubicación del control 'elemento' dentro de 'panel2' en coordenadas de pantalla
                    Point elementoLocationOnScreen = panelConjunto.PointToScreen(panelTxtUser.Location);
                    // Convierte las coordenadas de pantalla al sistema de coordenadas cliente del Formulario Principal
                    Point elementoLocationPrincipal = PointToClient(elementoLocationOnScreen);

                    if (elementoLocationPrincipal.Y > PanelNumPad.Location.Y)
                    {
                        int coordenadaNueva = elementoLocationPrincipal.Y - panelTxtUser.Size.Height;
                        panelTxtUser.Location = new Point(panelTxtUser.Location.X, elementoLocationPrincipal.Y - coordenadaNueva);
                        NumPadTimer.Stop();
                        textBoxSeleccionado = 1;
                        
                    }
                    else
                    {
                        int coordenadaNueva = panelTxtUser.Location.Y;
                        panelTxtUser.Location = new Point(panelTxtUser.Location.X, coordenadaNueva);
                        NumPadTimer.Stop();
                        textBoxSeleccionado = 1;
                    }
                    
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
                }
                else if (PanelNumPad.Size == PanelNumPad.MaximumSize && tbPassword.Focused == true)
                {
                    numPadVisible = true;
<<<<<<< HEAD
                    int coordenadaNueva = PanelNumPad.Location.Y - panelTxtPasswd.Size.Height;
                    panelTxtPasswd.Location = new System.Drawing.Point(panelTxtPasswd.Location.X, coordenadaNueva);
                    NumPadTimer.Stop();
                    textBoxSeleccionado = 2;
=======
                    if ((panelConjunto.Location.Y + panelConjunto.Size.Height) > PanelNumPad.Location.Y)
                    {
                        
                        int coordenadaNueva = PanelNumPad.Location.Y - panelConjunto.Size.Height;
                        panelConjunto.Location = new Point(panelConjunto.Location.X, coordenadaNueva);
                        NumPadTimer.Stop();
                        textBoxSeleccionado = 2;
                        
                        
                    }
                    else
                    {
                        int coordenadaNueva = panelConjunto.Location.Y;
                        panelConjunto.Location = new Point(panelConjunto.Location.X, coordenadaNueva);
                        NumPadTimer.Stop();
                        textBoxSeleccionado = 2;
                        MessageBox.Show(coordenadaNueva.ToString());
                    }

>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
                }
            }
            else
            {
                PanelNumPad.Top += 40;
                PanelNumPad.Height -= 40;
                if (PanelNumPad.Size == PanelNumPad.MinimumSize)
                {
                    NumPadTimer.Stop();
                    numPadVisible = false;
                    PanelNumPad.SendToBack();
                    panelTxtUser.Location = new System.Drawing.Point(panelTxtUser.Location.X, posicionActualPanelYUser);
<<<<<<< HEAD
                    panelTxtPasswd.Location = new System.Drawing.Point(panelTxtPasswd.Location.X, posicionActualPanelYPasswd);
=======
                    panelConjunto.Location = new System.Drawing.Point(panelConjunto.Location.X, posicionActualPanelYPasswd);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
                    textBoxSeleccionado = 0;
                }
            }
        }

<<<<<<< HEAD
        private void agregarNumero(string numero, System.Windows.Forms.TextBox textbox)
        {
            textbox.Text += numero;
            //  Poner el caret (simbolo que parpadea) despues del ultimo caracter
            //  Esto debido a que al pulsar cualquier boton en el NumPad causa que se quite el foco del textbox, generando conflictos con el timer
            textbox.Select(textbox.Text.Length, 0);
            textbox.Focus();
            textbox.ScrollToCaret();
        }
=======
        
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a

        //Visivilidad de texto en los textbox
        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "User")
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.LightGray;               
            }
            if (numPadVisible == false)
            {
                NumPadTimer.Start();
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if(tbUser.Text == "" && PanelNumPad.ContainsFocus == false)
            {
                tbUser.Text = "User";
                tbUser.ForeColor = Color.DimGray;
            }
            //NumPadTimer.Start();
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.LightGray;
                //Convierte a puntos para no ser visible
                tbPassword.UseSystemPasswordChar = true;
            }
            if (numPadVisible == false)
            {
                NumPadTimer.Start();
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "" && PanelNumPad.ContainsFocus == false)
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.DimGray;
                //Vuelven a ser visibles los datos
                tbPassword.UseSystemPasswordChar = false;
            }
            //NumPadTimer.Start();
        }
        // Fin visivilidad
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Llamar al método loggear de la clase Session para iniciar sesión
            Session.loggear(tbUser.Text, tbPassword.Text, this);
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen números y controlar la longitud máxima
            Controles.ValidarNumerico(e, tbUser, errorProvider);
            Controles.ValidarLargo(e, errorProvider2, tbUser, 8);
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen números y controlar la longitud máxima
            Controles.ValidarNumerico(e, tbPassword, errorProvider);
            Controles.ValidarLargo(e, errorProvider2, tbPassword, 4);
        }

        private void lilblOlvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir el formulario frmInvitado y ocultar el formulario actual
            new frmInvitado().Show();
            this.Hide();
        }

        private void Totem_Click(object sender, EventArgs e)
        {
            btnIngresar.Focus();
            if (numPadVisible == true)
            {                
                NumPadTimer.Start();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum9.Text, tbUser);
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
                    agregarNumero(btnNum9.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum9, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum8.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum8.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum8, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum7.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum7.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum7, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum6.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum6.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum6, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum5.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum5.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum5, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum4.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum4.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum4, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum3.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum3.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum3, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum2.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum2.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum2, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum1.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum1.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum1, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.TextLength == 8)
                {
                    errorProvider.SetError(tbUser, "La cedula puede ser de maximo 8 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum0.Text, tbUser);
                }
            }
            else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.TextLength == 4)
                {
                    errorProvider.SetError(tbPassword, "El pin puede ser de maximo 4 digitos");
                }
                else
                {
                    errorProvider.Clear();
                    agregarNumero(btnNum0.Text, tbPassword);
                }
            }
=======
            NumPad.AccionBoton(btnNum0, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (textBoxSeleccionado == 1)
            {
                if (tbUser.Text == "")
                {
                    tbUser.Text = "User";
                    tbUser.ForeColor = Color.DimGray;
                    //PanelNumPad.Visible = false;
                }
            }else if (textBoxSeleccionado == 2)
            {
                if (tbPassword.Text == "")
                {
                    tbPassword.Text = "Password";
                    tbPassword.ForeColor = Color.DimGray;
                    //Vuelven a ser visibles los datos
                    tbPassword.UseSystemPasswordChar = false;
                }
            }
            NumPadTimer.Start();           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxSeleccionado == 1)
            {
                if (!string.IsNullOrEmpty(tbUser.Text) && tbUser.Text.Length > 0)
                {
                    tbUser.Text = tbUser.Text.Substring(0, tbUser.Text.Length - 1);
                    //  Poner el caret (simbolo que parpadea) despues del ultimo caracter
                    //  Esto debido a que al pulsar cualquier boton en el NumPad causa que se quite el foco del textbox, generando conflictos con el timer
                    tbUser.Select(tbUser.Text.Length, 0);
                    tbUser.Focus();
                    tbUser.ScrollToCaret();
                }
                else
                {
                    tbUser.Focus();
<<<<<<< HEAD
                }
=======
                }   
>>>>>>> f79831a914cd2789c79f8edf6db46cce408f505a
            }else if (textBoxSeleccionado == 2)
            {
                if (!string.IsNullOrEmpty(tbPassword.Text) && tbPassword.Text.Length > 0)
                {
                    tbPassword.Text = tbPassword.Text.Substring(0, tbPassword.Text.Length - 1);
                    //  Poner el caret (simbolo que parpadea) despues del ultimo caracter
                    //  Esto debido a que al pulsar cualquier boton en el NumPad causa que se quite el foco del textbox, generando conflictos con el timer
                    tbPassword.Select(tbPassword.Text.Length, 0);
                    tbPassword.Focus();
                    tbPassword.ScrollToCaret();
                }
                else
                {
                    tbPassword.Focus();
                }
            }  
        }
    }
}
