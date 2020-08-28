using System;
using System.Windows.Forms;

namespace FactuxD
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.txtAccount = new MyLibreri.ErrorTexbox();
            this.txtPassword = new MyLibreri.ErrorTexbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecuperarContraseña = new System.Windows.Forms.Label();
            this.RecuperarContraseña = new System.Windows.Forms.Panel();
            this.lBLcerra = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridviewContraseña = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.RecuperarContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.btnIniciar.ForeColor = System.Drawing.Color.Gray;
            this.btnIniciar.Location = new System.Drawing.Point(145, 267);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(155, 32);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Ingresar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnNuevoRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoRegistro.BackgroundImage")));
            this.btnNuevoRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoRegistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevoRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnNuevoRegistro.FlatAppearance.BorderSize = 0;
            this.btnNuevoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistro.ForeColor = System.Drawing.Color.Gray;
            this.btnNuevoRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(350, 267);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(153, 32);
            this.btnNuevoRegistro.TabIndex = 9;
            this.btnNuevoRegistro.Text = "Nuevo";
            this.btnNuevoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistro.UseVisualStyleBackColor = false;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.ForeColor = System.Drawing.Color.Gray;
            this.txtAccount.Location = new System.Drawing.Point(317, 132);
            this.txtAccount.Multiline = true;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(114, 28);
            this.txtAccount.TabIndex = 10;
            this.txtAccount.Validar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(317, 193);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(114, 22);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Validar = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(659, 401);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(152, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 72);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(152, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 71);
            this.label2.TabIndex = 13;
            // 
            // lblRecuperarContraseña
            // 
            this.lblRecuperarContraseña.BackColor = System.Drawing.Color.Silver;
            this.lblRecuperarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarContraseña.ForeColor = System.Drawing.Color.Blue;
            this.lblRecuperarContraseña.Location = new System.Drawing.Point(145, 340);
            this.lblRecuperarContraseña.Name = "lblRecuperarContraseña";
            this.lblRecuperarContraseña.Size = new System.Drawing.Size(341, 22);
            this.lblRecuperarContraseña.TabIndex = 14;
            this.lblRecuperarContraseña.Text = "¿Olvidaste tu contraseña?";
            this.lblRecuperarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecuperarContraseña.Click += new System.EventHandler(this.lblRecuperarContraseña_Click);
            // 
            // RecuperarContraseña
            // 
            this.RecuperarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.RecuperarContraseña.Controls.Add(this.lBLcerra);
            this.RecuperarContraseña.Controls.Add(this.txtIdUsuario);
            this.RecuperarContraseña.Controls.Add(this.label3);
            this.RecuperarContraseña.Controls.Add(this.datagridviewContraseña);
            this.RecuperarContraseña.Location = new System.Drawing.Point(22, 62);
            this.RecuperarContraseña.Name = "RecuperarContraseña";
            this.RecuperarContraseña.Size = new System.Drawing.Size(289, 116);
            this.RecuperarContraseña.TabIndex = 15;
            this.RecuperarContraseña.Visible = false;
            // 
            // lBLcerra
            // 
            this.lBLcerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLcerra.ForeColor = System.Drawing.Color.DimGray;
            this.lBLcerra.Location = new System.Drawing.Point(253, 0);
            this.lBLcerra.Name = "lBLcerra";
            this.lBLcerra.Size = new System.Drawing.Size(33, 23);
            this.lBLcerra.TabIndex = 3;
            this.lBLcerra.Text = "X";
            this.lBLcerra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lBLcerra.Click += new System.EventHandler(this.lBLcerra_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(109, 24);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(138, 20);
            this.txtIdUsuario.TabIndex = 2;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID USUARIO:";
            // 
            // datagridviewContraseña
            // 
            this.datagridviewContraseña.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewContraseña.BackgroundColor = System.Drawing.Color.White;
            this.datagridviewContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewContraseña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewContraseña.Location = new System.Drawing.Point(13, 56);
            this.datagridviewContraseña.Name = "datagridviewContraseña";
            this.datagridviewContraseña.Size = new System.Drawing.Size(234, 72);
            this.datagridviewContraseña.TabIndex = 0;
            this.datagridviewContraseña.Visible = false;
            // 
            // VentanaLogin
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 401);
            this.Controls.Add(this.RecuperarContraseña);
            this.Controls.Add(this.lblRecuperarContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.RecuperarContraseña.ResumeLayout(false);
            this.RecuperarContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private Button btnNuevoRegistro;
        private MyLibreri.ErrorTexbox txtAccount;
        private MyLibreri.ErrorTexbox txtPassword;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label lblRecuperarContraseña;
        private Panel RecuperarContraseña;
        private TextBox txtIdUsuario;
        private Label label3;
        private DataGridView datagridviewContraseña;
        private Label lBLcerra;
    }
}

