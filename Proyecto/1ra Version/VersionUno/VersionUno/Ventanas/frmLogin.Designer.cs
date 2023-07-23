namespace VersionUno
{
    partial class Totem
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lilblOlvidar = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NumPadTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelNumPad = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.panelTxtUser = new System.Windows.Forms.Panel();
            this.panelTxtPasswd = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.PanelNumPad.SuspendLayout();
            this.panelTxtUser.SuspendLayout();
            this.panelTxtPasswd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(148)))), ((int)(((byte)(201)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 114);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbPassword.Location = new System.Drawing.Point(12, 7);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(364, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIngresar.Location = new System.Drawing.Point(127, 397);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(221, 36);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lilblOlvidar
            // 
            this.lilblOlvidar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(148)))), ((int)(((byte)(201)))));
            this.lilblOlvidar.AutoSize = true;
            this.lilblOlvidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilblOlvidar.LinkColor = System.Drawing.Color.DimGray;
            this.lilblOlvidar.Location = new System.Drawing.Point(213, 445);
            this.lilblOlvidar.Name = "lilblOlvidar";
            this.lilblOlvidar.Size = new System.Drawing.Size(45, 13);
            this.lilblOlvidar.TabIndex = 0;
            this.lilblOlvidar.TabStop = true;
            this.lilblOlvidar.Text = "Invitado";
            this.lilblOlvidar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lilblOlvidar.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.lilblOlvidar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilblOlvidar_LinkClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // NumPadTimer
            // 
            this.NumPadTimer.Interval = 1;
            this.NumPadTimer.Tick += new System.EventHandler(this.NumPadTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(148)))), ((int)(((byte)(201)))));
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 89);
            this.panel1.TabIndex = 0;
            // 
            // PanelNumPad
            // 
            this.PanelNumPad.BackColor = System.Drawing.Color.White;
            this.PanelNumPad.Controls.Add(this.btnEnter);
            this.PanelNumPad.Controls.Add(this.btnNum0);
            this.PanelNumPad.Controls.Add(this.btnDelete);
            this.PanelNumPad.Controls.Add(this.btnNum3);
            this.PanelNumPad.Controls.Add(this.btnNum6);
            this.PanelNumPad.Controls.Add(this.btnNum9);
            this.PanelNumPad.Controls.Add(this.btnNum2);
            this.PanelNumPad.Controls.Add(this.btnNum5);
            this.PanelNumPad.Controls.Add(this.btnNum8);
            this.PanelNumPad.Controls.Add(this.btnNum1);
            this.PanelNumPad.Controls.Add(this.btnNum4);
            this.PanelNumPad.Controls.Add(this.btnNum7);
            this.PanelNumPad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelNumPad.Location = new System.Drawing.Point(0, 517);
            this.PanelNumPad.MaximumSize = new System.Drawing.Size(503, 415);
            this.PanelNumPad.MinimumSize = new System.Drawing.Size(503, 72);
            this.PanelNumPad.Name = "PanelNumPad";
            this.PanelNumPad.Size = new System.Drawing.Size(503, 72);
            this.PanelNumPad.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(372, 281);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 127);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(372, 148);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(119, 127);
            this.btnNum0.TabIndex = 21;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 127);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "<--";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(252, 281);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(114, 127);
            this.btnNum3.TabIndex = 19;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(252, 148);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(114, 127);
            this.btnNum6.TabIndex = 18;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(252, 15);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(114, 127);
            this.btnNum9.TabIndex = 17;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(132, 281);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(114, 127);
            this.btnNum2.TabIndex = 16;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(132, 148);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(114, 127);
            this.btnNum5.TabIndex = 15;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(132, 15);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(114, 127);
            this.btnNum8.TabIndex = 14;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(12, 281);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(114, 127);
            this.btnNum1.TabIndex = 13;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(12, 148);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(114, 127);
            this.btnNum4.TabIndex = 12;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(12, 15);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(114, 127);
            this.btnNum7.TabIndex = 11;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Location = new System.Drawing.Point(12, 14);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(364, 22);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "User";
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUser_KeyPress);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // panelTxtUser
            // 
            this.panelTxtUser.Controls.Add(this.tbUser);
            this.panelTxtUser.Controls.Add(this.label2);
            this.panelTxtUser.Location = new System.Drawing.Point(41, 189);
            this.panelTxtUser.Name = "panelTxtUser";
            this.panelTxtUser.Size = new System.Drawing.Size(397, 54);
            this.panelTxtUser.TabIndex = 7;
            // 
            // panelTxtPasswd
            // 
            this.panelTxtPasswd.Controls.Add(this.tbPassword);
            this.panelTxtPasswd.Controls.Add(this.label3);
            this.panelTxtPasswd.Location = new System.Drawing.Point(41, 287);
            this.panelTxtPasswd.Name = "panelTxtPasswd";
            this.panelTxtPasswd.Size = new System.Drawing.Size(397, 54);
            this.panelTxtPasswd.TabIndex = 8;
            // 
            // Totem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(503, 589);
            this.Controls.Add(this.lilblOlvidar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTxtUser);
            this.Controls.Add(this.panelTxtPasswd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelNumPad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Totem";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totem";
            this.Click += new System.EventHandler(this.Totem_Click);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.PanelNumPad.ResumeLayout(false);
            this.panelTxtUser.ResumeLayout(false);
            this.panelTxtUser.PerformLayout();
            this.panelTxtPasswd.ResumeLayout(false);
            this.panelTxtPasswd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lilblOlvidar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Timer NumPadTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelNumPad;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Panel panelTxtUser;
        private System.Windows.Forms.Panel panelTxtPasswd;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum8;
    }
}

