namespace FactuxD
{
    partial class ReporteNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteNotas));
            this.checkConsultaporNotas = new System.Windows.Forms.CheckBox();
            this.DataGrivNOtas = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butimage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivNOtas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkConsultaporNotas
            // 
            this.checkConsultaporNotas.AutoSize = true;
            this.checkConsultaporNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.checkConsultaporNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConsultaporNotas.ForeColor = System.Drawing.Color.White;
            this.checkConsultaporNotas.Location = new System.Drawing.Point(451, 17);
            this.checkConsultaporNotas.Name = "checkConsultaporNotas";
            this.checkConsultaporNotas.Size = new System.Drawing.Size(96, 24);
            this.checkConsultaporNotas.TabIndex = 12;
            this.checkConsultaporNotas.Text = "Consultar";
            this.checkConsultaporNotas.UseVisualStyleBackColor = false;
            this.checkConsultaporNotas.CheckedChanged += new System.EventHandler(this.checkConsultaporNotas_CheckedChanged);
            // 
            // DataGrivNOtas
            // 
            this.DataGrivNOtas.AllowUserToAddRows = false;
            this.DataGrivNOtas.AllowUserToDeleteRows = false;
            this.DataGrivNOtas.AllowUserToResizeColumns = false;
            this.DataGrivNOtas.AllowUserToResizeRows = false;
            this.DataGrivNOtas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGrivNOtas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrivNOtas.BackgroundColor = System.Drawing.Color.White;
            this.DataGrivNOtas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrivNOtas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrivNOtas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrivNOtas.ColumnHeadersHeight = 30;
            this.DataGrivNOtas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrivNOtas.EnableHeadersVisualStyles = false;
            this.DataGrivNOtas.Location = new System.Drawing.Point(0, 3);
            this.DataGrivNOtas.Name = "DataGrivNOtas";
            this.DataGrivNOtas.Size = new System.Drawing.Size(833, 264);
            this.DataGrivNOtas.TabIndex = 11;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(553, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(84, 33);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar ";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(672, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 30);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DataGrivNOtas);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 270);
            this.panel1.TabIndex = 15;
            // 
            // butimage
            // 
            this.butimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butimage.BackgroundImage")));
            this.butimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butimage.Location = new System.Drawing.Point(12, 9);
            this.butimage.Name = "butimage";
            this.butimage.Size = new System.Drawing.Size(50, 47);
            this.butimage.TabIndex = 16;
            this.butimage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reporte de Notas";
            // 
            // ReporteNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(857, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butimage);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.checkConsultaporNotas);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteNotas";
            this.Text = "ReporteNotas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivNOtas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkConsultaporNotas;
        private System.Windows.Forms.DataGridView DataGrivNOtas;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butimage;
        private System.Windows.Forms.Label label1;
    }
}