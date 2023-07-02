using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersionUno.Clases;
using VersionUno.Ventanas;

namespace VersionUno.Ventanas
{
    public partial class frmInvitado : Form
    {
        public frmInvitado()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new Totem().Show();
        }
    }
}
