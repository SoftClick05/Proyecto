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

        bool numPadVisible = false;
        private void NumPadTimer_Tick(object sender, EventArgs e)
        {
            if (numPadVisible == false)
            {
                PanelNumPad.BringToFront();
                PanelNumPad.Top -= 60;
                PanelNumPad.Height += 60;
                if (PanelNumPad.Size == PanelNumPad.MaximumSize)
                {                   
                    numPadVisible = true;
                    panel3.Location();
                    NumPadTimer.Stop();
                }
            }
            else
            {
                PanelNumPad.Top += 60;
                PanelNumPad.Height -= 60;
                if (PanelNumPad.Size == PanelNumPad.MinimumSize)
                {
                    NumPadTimer.Stop();
                    numPadVisible = false;
                    PanelNumPad.SendToBack();
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
                NumPadTimer.Start();
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if(tbUser.Text == "")
            {
                tbUser.Text = "User";
                tbUser.ForeColor = Color.DimGray;
                //PanelNumPad.Visible = false;
                NumPadTimer.Start();
            }
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
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.DimGray;
                //Vuelven a ser visibles los datos
                tbPassword.UseSystemPasswordChar = false;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            NumPadTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NumPadTimer.Start();
        }
    }
}
