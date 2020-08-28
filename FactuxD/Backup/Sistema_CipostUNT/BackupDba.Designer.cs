namespace FactuxD
{
    partial class BackupDba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDba));
            this.btnBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.btnBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.BackgroundImage")));
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.btnBackup.Location = new System.Drawing.Point(149, 55);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(114, 137);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar Backup de la DBA";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.btnHabilitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHabilitar.BackgroundImage")));
            this.btnHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.ForeColor = System.Drawing.Color.White;
            this.btnHabilitar.Location = new System.Drawing.Point(44, 224);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(96, 50);
            this.btnHabilitar.TabIndex = 2;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.btnDeshabilitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeshabilitar.BackgroundImage")));
            this.btnDeshabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Location = new System.Drawing.Point(273, 224);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(114, 57);
            this.btnDeshabilitar.TabIndex = 3;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(387, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackupDba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(450, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupDba";
            this.Text = "BackupDba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button button1;
    }
}