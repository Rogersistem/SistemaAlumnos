namespace FactuxD
{
    partial class RegistroAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAlumnos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new MyLibreri.ErrorTexbox();
            this.txtDNI = new MyLibreri.ErrorTexbox();
            this.txtApellidos = new MyLibreri.ErrorTexbox();
            this.txtNombre = new MyLibreri.ErrorTexbox();
            this.txtCelular = new MyLibreri.ErrorTexbox();
            this.txtEMail = new MyLibreri.ErrorTexbox();
            this.txtDirecc = new MyLibreri.ErrorTexbox();
            this.txtPais = new MyLibreri.ErrorTexbox();
            this.txtDepto = new MyLibreri.ErrorTexbox();
            this.txtDistrito = new MyLibreri.ErrorTexbox();
            this.txtCodPrograma = new MyLibreri.ErrorTexbox();
            this.txtDepartamento = new System.Windows.Forms.Label();
            this.DatefechaNac = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridRegistro = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaAlumno = new System.Windows.Forms.TextBox();
            this.GridviewbuscaAlumnos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewbuscaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(49)))), ((int)(((byte)(39)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1157, 12);
            this.btnSalir.Size = new System.Drawing.Size(44, 27);
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(740, 82);
            this.btnConsultar.Size = new System.Drawing.Size(173, 32);
            this.btnConsultar.Text = "Consultar Programa";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(646, 84);
            this.btnGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(943, 511);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(919, 82);
            this.btnNuevo.Size = new System.Drawing.Size(76, 32);
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(367, 88);
            this.btnExportar.Size = new System.Drawing.Size(43, 34);
            this.btnExportar.Text = "";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.cboSexo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtEMail);
            this.groupBox1.Controls.Add(this.txtDirecc);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.txtDepto);
            this.groupBox1.Controls.Add(this.txtDistrito);
            this.groupBox1.Controls.Add(this.txtCodPrograma);
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(this.DatefechaNac);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(16, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 430);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "---Seleccionar---",
            "Masculino",
            "Femenino"});
            this.cboSexo.Location = new System.Drawing.Point(134, 152);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(145, 24);
            this.cboSexo.TabIndex = 54;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(134, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 22);
            this.txtCodigo.TabIndex = 41;
            this.txtCodigo.Validar = true;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.White;
            this.txtDNI.Location = new System.Drawing.Point(134, 64);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(109, 22);
            this.txtDNI.TabIndex = 40;
            this.txtDNI.Validar = true;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(134, 91);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(149, 22);
            this.txtApellidos.TabIndex = 39;
            this.txtApellidos.Validar = true;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(134, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.Validar = true;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.Location = new System.Drawing.Point(134, 178);
            this.txtCelular.MaxLength = 9;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(109, 22);
            this.txtCelular.TabIndex = 37;
            this.txtCelular.Validar = true;
            // 
            // txtEMail
            // 
            this.txtEMail.BackColor = System.Drawing.Color.White;
            this.txtEMail.Location = new System.Drawing.Point(134, 206);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(145, 22);
            this.txtEMail.TabIndex = 36;
            this.txtEMail.Validar = true;
            // 
            // txtDirecc
            // 
            this.txtDirecc.BackColor = System.Drawing.Color.White;
            this.txtDirecc.Location = new System.Drawing.Point(134, 234);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(145, 22);
            this.txtDirecc.TabIndex = 35;
            this.txtDirecc.Validar = true;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.White;
            this.txtPais.Location = new System.Drawing.Point(148, 290);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(135, 22);
            this.txtPais.TabIndex = 34;
            this.txtPais.Validar = true;
            // 
            // txtDepto
            // 
            this.txtDepto.BackColor = System.Drawing.Color.White;
            this.txtDepto.Location = new System.Drawing.Point(148, 320);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(131, 22);
            this.txtDepto.TabIndex = 33;
            this.txtDepto.Validar = true;
            // 
            // txtDistrito
            // 
            this.txtDistrito.BackColor = System.Drawing.Color.White;
            this.txtDistrito.Location = new System.Drawing.Point(148, 348);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(131, 22);
            this.txtDistrito.TabIndex = 32;
            this.txtDistrito.Validar = true;
            // 
            // txtCodPrograma
            // 
            this.txtCodPrograma.BackColor = System.Drawing.Color.White;
            this.txtCodPrograma.Location = new System.Drawing.Point(148, 376);
            this.txtCodPrograma.Name = "txtCodPrograma";
            this.txtCodPrograma.Size = new System.Drawing.Size(131, 22);
            this.txtCodPrograma.TabIndex = 31;
            this.txtCodPrograma.Validar = true;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AutoSize = true;
            this.txtDepartamento.ForeColor = System.Drawing.Color.Navy;
            this.txtDepartamento.Location = new System.Drawing.Point(42, 326);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(94, 16);
            this.txtDepartamento.TabIndex = 30;
            this.txtDepartamento.Text = "Departamento";
            // 
            // DatefechaNac
            // 
            this.DatefechaNac.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DatefechaNac.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.DatefechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatefechaNac.Location = new System.Drawing.Point(134, 262);
            this.DatefechaNac.Name = "DatefechaNac";
            this.DatefechaNac.Size = new System.Drawing.Size(109, 22);
            this.DatefechaNac.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(35, 379);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Codigo Programa:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(42, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Distrito:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(42, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "País";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(40, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Fecha Nacim:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.ForeColor = System.Drawing.Color.Navy;
            this.txtDireccion.Location = new System.Drawing.Point(40, 237);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(68, 16);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(37, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "E-Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(37, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = " Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(37, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(37, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(40, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apelliodos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridRegistro
            // 
            this.dataGridRegistro.AllowUserToAddRows = false;
            this.dataGridRegistro.AllowUserToDeleteRows = false;
            this.dataGridRegistro.AllowUserToResizeColumns = false;
            this.dataGridRegistro.AllowUserToResizeRows = false;
            this.dataGridRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(254)))), ((int)(((byte)(239)))));
            this.dataGridRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRegistro.ColumnHeadersHeight = 22;
            this.dataGridRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridRegistro.EnableHeadersVisualStyles = false;
            this.dataGridRegistro.Location = new System.Drawing.Point(394, 176);
            this.dataGridRegistro.Name = "dataGridRegistro";
            this.dataGridRegistro.Size = new System.Drawing.Size(357, 139);
            this.dataGridRegistro.TabIndex = 31;
            this.dataGridRegistro.Visible = false;
            this.dataGridRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRegistro_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(254)))), ((int)(((byte)(239)))));
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(351, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 68);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar Alumno por( Apellido y Dni)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 54);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Alumnos";
            // 
            // txtBuscaAlumno
            // 
            this.txtBuscaAlumno.Location = new System.Drawing.Point(416, 94);
            this.txtBuscaAlumno.Name = "txtBuscaAlumno";
            this.txtBuscaAlumno.Size = new System.Drawing.Size(163, 20);
            this.txtBuscaAlumno.TabIndex = 64;
            this.txtBuscaAlumno.TextChanged += new System.EventHandler(this.txtBuscaAlumno_TextChanged);
            // 
            // GridviewbuscaAlumnos
            // 
            this.GridviewbuscaAlumnos.AllowUserToAddRows = false;
            this.GridviewbuscaAlumnos.AllowUserToDeleteRows = false;
            this.GridviewbuscaAlumnos.AllowUserToResizeColumns = false;
            this.GridviewbuscaAlumnos.AllowUserToResizeRows = false;
            this.GridviewbuscaAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridviewbuscaAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridviewbuscaAlumnos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridviewbuscaAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridviewbuscaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridviewbuscaAlumnos.EnableHeadersVisualStyles = false;
            this.GridviewbuscaAlumnos.Location = new System.Drawing.Point(351, 128);
            this.GridviewbuscaAlumnos.Name = "GridviewbuscaAlumnos";
            this.GridviewbuscaAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridviewbuscaAlumnos.Size = new System.Drawing.Size(828, 344);
            this.GridviewbuscaAlumnos.TabIndex = 65;
            this.GridviewbuscaAlumnos.Visible = false;
            this.GridviewbuscaAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridviewbuscaAlumnos_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 456);
            this.panel2.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1194, 14);
            this.panel3.TabIndex = 67;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1192, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 442);
            this.panel4.TabIndex = 68;
            // 
            // RegistroAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 510);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscaAlumno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridviewbuscaAlumnos);
            this.Controls.Add(this.dataGridRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroAlumnos";
            this.Controls.SetChildIndex(this.dataGridRegistro, 0);
            this.Controls.SetChildIndex(this.GridviewbuscaAlumnos, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnExportar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.txtBuscaAlumno, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewbuscaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtDepartamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DatefechaNac;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridRegistro;
        private System.Windows.Forms.GroupBox groupBox2;
        private MyLibreri.ErrorTexbox txtCodigo;
        private MyLibreri.ErrorTexbox txtDNI;
        private MyLibreri.ErrorTexbox txtApellidos;
        private MyLibreri.ErrorTexbox txtNombre;
        private MyLibreri.ErrorTexbox txtCelular;
        private MyLibreri.ErrorTexbox txtEMail;
        private MyLibreri.ErrorTexbox txtDirecc;
        private MyLibreri.ErrorTexbox txtPais;
        private MyLibreri.ErrorTexbox txtDepto;
        private MyLibreri.ErrorTexbox txtDistrito;
        private MyLibreri.ErrorTexbox txtCodPrograma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtBuscaAlumno;
        private System.Windows.Forms.DataGridView GridviewbuscaAlumnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}