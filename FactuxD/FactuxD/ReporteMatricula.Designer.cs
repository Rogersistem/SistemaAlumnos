namespace FactuxD
{
    partial class ReporteMatricula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMatricula));
            this.ReporMatricula = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExporta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butimage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReporMatricula)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReporMatricula
            // 
            this.ReporMatricula.AllowUserToAddRows = false;
            this.ReporMatricula.AllowUserToDeleteRows = false;
            this.ReporMatricula.AllowUserToResizeColumns = false;
            this.ReporMatricula.AllowUserToResizeRows = false;
            this.ReporMatricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ReporMatricula.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReporMatricula.BackgroundColor = System.Drawing.Color.White;
            this.ReporMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReporMatricula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReporMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReporMatricula.ColumnHeadersHeight = 25;
            this.ReporMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReporMatricula.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReporMatricula.EnableHeadersVisualStyles = false;
            this.ReporMatricula.Location = new System.Drawing.Point(12, 58);
            this.ReporMatricula.Name = "ReporMatricula";
            this.ReporMatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReporMatricula.Size = new System.Drawing.Size(1054, 267);
            this.ReporMatricula.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(753, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 34);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar\r\n";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExporta
            // 
            this.btnExporta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.btnExporta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExporta.BackgroundImage")));
            this.btnExporta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExporta.ForeColor = System.Drawing.Color.White;
            this.btnExporta.Location = new System.Drawing.Point(852, 14);
            this.btnExporta.Name = "btnExporta";
            this.btnExporta.Size = new System.Drawing.Size(91, 34);
            this.btnExporta.TabIndex = 3;
            this.btnExporta.Text = "Exportar ";
            this.btnExporta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExporta.UseVisualStyleBackColor = false;
            this.btnExporta.Click += new System.EventHandler(this.btnExporta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.butimage);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnExporta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 52);
            this.panel1.TabIndex = 4;
            // 
            // butimage
            // 
            this.butimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butimage.BackgroundImage")));
            this.butimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butimage.Location = new System.Drawing.Point(3, 3);
            this.butimage.Name = "butimage";
            this.butimage.Size = new System.Drawing.Size(62, 43);
            this.butimage.TabIndex = 5;
            this.butimage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1017, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Matrícula";
            // 
            // ReporteMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1074, 331);
            this.Controls.Add(this.ReporMatricula);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReporteMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.ReporMatricula)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReporMatricula;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExporta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butimage;
    }
}