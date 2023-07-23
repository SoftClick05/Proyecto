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
using System.Xml.Linq;

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


        private int posicionActualPanelXUser = 0;
        private int posicionActualPanelYUser = 0;

        private int posicionActualPanelXPasswd = 0;
        private int posicionActualPanelYPasswd = 0;

        private bool numPadVisible = false;

        private int textBoxSeleccionado = 0;
        // 1=User
        // 2=Passwd
        private void NumPadTimer_Tick(object sender, EventArgs e)
        {
            if (numPadVisible == false)
            {
                posicionActualPanelYUser = panelTxtUser.Location.Y;

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
                    
                }
                else if (PanelNumPad.Size == PanelNumPad.MaximumSize && tbPassword.Focused == true)
                {
                    numPadVisible = true;
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
                    panelConjunto.Location = new System.Drawing.Point(panelConjunto.Location.X, posicionActualPanelYPasswd);
                    textBoxSeleccionado = 0;
                }
            }
        }

        

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
            NumPad.AccionBoton(btnNum9, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum8, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum7, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum6, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum5, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum4, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum3, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum2, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum1, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            NumPad.AccionBoton(btnNum0, tbUser, tbPassword, errorProvider, errorProvider2, textBoxSeleccionado);
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
                }   
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
