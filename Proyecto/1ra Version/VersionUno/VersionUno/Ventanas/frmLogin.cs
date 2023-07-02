﻿using System;
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

namespace VersionUno
{
    public partial class Totem : Form
    {
        public Totem()
        {
            InitializeComponent();
        }

        //Movilidad de ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        //Visivilidad de texto en los textbox
        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "User")
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.LightGray;
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if(tbUser.Text == "")
            {
                tbUser.Text = "User";
                tbUser.ForeColor = Color.DimGray;
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
        
        //Modificaciones de diseño
        private void Totem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Fin - Modificaciones de diseño

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Session.loggear(tbUser.Text, tbPassword.Text, this);
            
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.validarNumerico(e, tbUser, errorProvider);
            Controles.validarLargo(e, errorProvider2, tbUser, 8);
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controles.validarNumerico(e, tbPassword, errorProvider);
            Controles.validarLargo(e, errorProvider2, tbPassword, 4);
        }

        private void lilblOlvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}