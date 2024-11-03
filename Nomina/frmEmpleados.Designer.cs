namespace Nomina
{
    partial class frmEmpleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox3 = new GroupBox();
            chkEstadoEmpleado = new CheckBox();
            label34 = new Label();
            groupBox4 = new GroupBox();
            dtpFechaCierreContrato = new DateTimePicker();
            dtpFechaContratacion = new DateTimePicker();
            txtRuc = new TextBox();
            txtInss = new TextBox();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            groupBox5 = new GroupBox();
            FechaNacimiento = new DateTimePicker();
            label41 = new Label();
            txtCelular = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            cboEstadoCivil = new ComboBox();
            cboSexo = new ComboBox();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            label45 = new Label();
            label46 = new Label();
            groupBox6 = new GroupBox();
            txtCedula = new TextBox();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerNombre = new TextBox();
            label47 = new Label();
            label48 = new Label();
            label49 = new Label();
            label50 = new Label();
            label51 = new Label();
            label52 = new Label();
            BtnAgregar = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEliminar = new Button();
            btnActualizar = new Button();
            BtnExportar = new PictureBox();
            dgvDatosEmpleado = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnExportar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmpleado).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkEstadoEmpleado);
            groupBox3.Controls.Add(label34);
            groupBox3.Font = new Font("Cascadia Mono", 8.25F);
            groupBox3.Location = new Point(691, 56);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(134, 200);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "OTROS DATOS";
            // 
            // chkEstadoEmpleado
            // 
            chkEstadoEmpleado.AutoSize = true;
            chkEstadoEmpleado.Font = new Font("Cascadia Mono", 6.75F);
            chkEstadoEmpleado.Location = new Point(17, 109);
            chkEstadoEmpleado.Name = "chkEstadoEmpleado";
            chkEstadoEmpleado.Size = new Size(71, 20);
            chkEstadoEmpleado.TabIndex = 3;
            chkEstadoEmpleado.Text = "Activo";
            chkEstadoEmpleado.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Arial", 6F, FontStyle.Bold);
            label34.Location = new Point(5, 84);
            label34.Margin = new Padding(2, 0, 2, 0);
            label34.Name = "label34";
            label34.Size = new Size(129, 12);
            label34.TabIndex = 1;
            label34.Text = "ESTADO DEL EMPLEADO";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpFechaCierreContrato);
            groupBox4.Controls.Add(dtpFechaContratacion);
            groupBox4.Controls.Add(txtRuc);
            groupBox4.Controls.Add(txtInss);
            groupBox4.Controls.Add(label36);
            groupBox4.Controls.Add(label37);
            groupBox4.Controls.Add(label38);
            groupBox4.Controls.Add(label39);
            groupBox4.Font = new Font("Cascadia Mono", 8.25F);
            groupBox4.Location = new Point(470, 56);
            groupBox4.Margin = new Padding(2, 1, 2, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 1, 2, 1);
            groupBox4.Size = new Size(210, 200);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "DATOS LABORALES";
            // 
            // dtpFechaCierreContrato
            // 
            dtpFechaCierreContrato.Font = new Font("Arial", 6F, FontStyle.Bold);
            dtpFechaCierreContrato.Format = DateTimePickerFormat.Short;
            dtpFechaCierreContrato.Location = new Point(5, 155);
            dtpFechaCierreContrato.Margin = new Padding(2, 1, 2, 1);
            dtpFechaCierreContrato.Name = "dtpFechaCierreContrato";
            dtpFechaCierreContrato.Size = new Size(195, 19);
            dtpFechaCierreContrato.TabIndex = 9;
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Font = new Font("Arial", 6F, FontStyle.Bold);
            dtpFechaContratacion.Format = DateTimePickerFormat.Short;
            dtpFechaContratacion.Location = new Point(5, 111);
            dtpFechaContratacion.Margin = new Padding(2, 1, 2, 1);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(195, 19);
            dtpFechaContratacion.TabIndex = 8;
            dtpFechaContratacion.ValueChanged += dtpFechaContratacion_ValueChanged;
            // 
            // txtRuc
            // 
            txtRuc.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtRuc.Location = new Point(91, 61);
            txtRuc.Margin = new Padding(2, 1, 2, 1);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(105, 19);
            txtRuc.TabIndex = 7;
            txtRuc.KeyPress += txtRuc_KeyPress;
            // 
            // txtInss
            // 
            txtInss.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtInss.Location = new Point(91, 41);
            txtInss.Margin = new Padding(2, 1, 2, 1);
            txtInss.Name = "txtInss";
            txtInss.Size = new Size(105, 19);
            txtInss.TabIndex = 6;
            txtInss.KeyPress += txtInss_KeyPress;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Cascadia Mono", 6.75F);
            label36.Location = new Point(5, 136);
            label36.Margin = new Padding(2, 0, 2, 0);
            label36.Name = "label36";
            label36.Size = new Size(175, 16);
            label36.TabIndex = 4;
            label36.Text = "FECHA CIERRE DE CONTRATO";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Cascadia Mono", 6.75F);
            label37.Location = new Point(5, 93);
            label37.Margin = new Padding(2, 0, 2, 0);
            label37.Name = "label37";
            label37.Size = new Size(154, 16);
            label37.TabIndex = 3;
            label37.Text = "FECHA DE CONTRATACIÓN";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Cascadia Mono", 6.75F);
            label38.Location = new Point(9, 61);
            label38.Margin = new Padding(2, 0, 2, 0);
            label38.Name = "label38";
            label38.Size = new Size(49, 16);
            label38.TabIndex = 2;
            label38.Text = "No.RUC";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Cascadia Mono", 6.75F);
            label39.Location = new Point(9, 39);
            label39.Margin = new Padding(2, 0, 2, 0);
            label39.Name = "label39";
            label39.Size = new Size(56, 16);
            label39.TabIndex = 1;
            label39.Text = "No.INSS";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(FechaNacimiento);
            groupBox5.Controls.Add(label41);
            groupBox5.Controls.Add(txtCelular);
            groupBox5.Controls.Add(txtTelefono);
            groupBox5.Controls.Add(txtDireccion);
            groupBox5.Controls.Add(cboEstadoCivil);
            groupBox5.Controls.Add(cboSexo);
            groupBox5.Controls.Add(label42);
            groupBox5.Controls.Add(label43);
            groupBox5.Controls.Add(label44);
            groupBox5.Controls.Add(label45);
            groupBox5.Controls.Add(label46);
            groupBox5.Font = new Font("Cascadia Mono", 8.25F);
            groupBox5.Location = new Point(243, 56);
            groupBox5.Margin = new Padding(2, 1, 2, 1);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2, 1, 2, 1);
            groupBox5.Size = new Size(210, 200);
            groupBox5.TabIndex = 30;
            groupBox5.TabStop = false;
            groupBox5.Text = "OTROS DATOS PERSONALES";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Font = new Font("Arial", 6F, FontStyle.Bold);
            FechaNacimiento.Format = DateTimePickerFormat.Short;
            FechaNacimiento.Location = new Point(0, 172);
            FechaNacimiento.Margin = new Padding(2, 1, 2, 1);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(191, 19);
            FechaNacimiento.TabIndex = 11;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Cascadia Mono", 6.75F);
            label41.Location = new Point(-2, 155);
            label41.Margin = new Padding(2, 0, 2, 0);
            label41.Name = "label41";
            label41.Size = new Size(119, 16);
            label41.TabIndex = 10;
            label41.Text = "FECHA NACIMIENTO";
            // 
            // txtCelular
            // 
            txtCelular.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtCelular.Location = new Point(91, 132);
            txtCelular.Margin = new Padding(2, 1, 2, 1);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(115, 19);
            txtCelular.TabIndex = 9;
            txtCelular.KeyPress += txtCelular_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtTelefono.Location = new Point(91, 107);
            txtTelefono.Margin = new Padding(2, 1, 2, 1);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(115, 19);
            txtTelefono.TabIndex = 8;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtDireccion.Location = new Point(91, 81);
            txtDireccion.Margin = new Padding(2, 1, 2, 1);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(114, 19);
            txtDireccion.TabIndex = 7;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.Font = new Font("Arial", 6F, FontStyle.Bold);
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(91, 56);
            cboEstadoCivil.Margin = new Padding(2, 1, 2, 1);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(115, 20);
            cboEstadoCivil.TabIndex = 6;
            // 
            // cboSexo
            // 
            cboSexo.Font = new Font("Arial", 6F, FontStyle.Bold);
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(91, 28);
            cboSexo.Margin = new Padding(2, 1, 2, 1);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(115, 20);
            cboSexo.TabIndex = 5;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Cascadia Mono", 6.75F);
            label42.Location = new Point(5, 132);
            label42.Margin = new Padding(2, 0, 2, 0);
            label42.Name = "label42";
            label42.Size = new Size(56, 16);
            label42.TabIndex = 4;
            label42.Text = "CELULAR";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Cascadia Mono", 6.75F);
            label43.Location = new Point(5, 107);
            label43.Margin = new Padding(2, 0, 2, 0);
            label43.Name = "label43";
            label43.Size = new Size(63, 16);
            label43.TabIndex = 3;
            label43.Text = "TELEFONO";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Cascadia Mono", 6.75F);
            label44.Location = new Point(5, 84);
            label44.Margin = new Padding(2, 0, 2, 0);
            label44.Name = "label44";
            label44.Size = new Size(70, 16);
            label44.TabIndex = 2;
            label44.Text = "DIRECCION";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Cascadia Mono", 6.75F);
            label45.Location = new Point(5, 56);
            label45.Margin = new Padding(2, 0, 2, 0);
            label45.Name = "label45";
            label45.Size = new Size(91, 16);
            label45.TabIndex = 1;
            label45.Text = "ESTADO CIVIL";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Cascadia Mono", 6.75F);
            label46.Location = new Point(5, 32);
            label46.Margin = new Padding(2, 0, 2, 0);
            label46.Name = "label46";
            label46.Size = new Size(35, 16);
            label46.TabIndex = 0;
            label46.Text = "SEXO";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtCedula);
            groupBox6.Controls.Add(txtSegundoApellido);
            groupBox6.Controls.Add(txtPrimerApellido);
            groupBox6.Controls.Add(txtSegundoNombre);
            groupBox6.Controls.Add(txtPrimerNombre);
            groupBox6.Controls.Add(label47);
            groupBox6.Controls.Add(label48);
            groupBox6.Controls.Add(label49);
            groupBox6.Controls.Add(label50);
            groupBox6.Controls.Add(label51);
            groupBox6.Font = new Font("Cascadia Mono", 8.25F);
            groupBox6.Location = new Point(13, 59);
            groupBox6.Margin = new Padding(2, 1, 2, 1);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2, 1, 2, 1);
            groupBox6.Size = new Size(222, 200);
            groupBox6.TabIndex = 29;
            groupBox6.TabStop = false;
            groupBox6.Text = "DATOS DE IDENTIDAD";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtCedula.Location = new Point(129, 141);
            txtCedula.Margin = new Padding(2, 1, 2, 1);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(89, 19);
            txtCedula.TabIndex = 27;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtSegundoApellido.Location = new Point(129, 115);
            txtSegundoApellido.Margin = new Padding(2, 1, 2, 1);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(89, 19);
            txtSegundoApellido.TabIndex = 26;
            txtSegundoApellido.KeyPress += txtSegundoApellido_KeyPress;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtPrimerApellido.Location = new Point(129, 88);
            txtPrimerApellido.Margin = new Padding(2, 1, 2, 1);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(89, 19);
            txtPrimerApellido.TabIndex = 25;
            txtPrimerApellido.KeyPress += txtPrimerApellido_KeyPress;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtSegundoNombre.Location = new Point(129, 61);
            txtSegundoNombre.Margin = new Padding(2, 1, 2, 1);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(89, 19);
            txtSegundoNombre.TabIndex = 24;
            txtSegundoNombre.KeyPress += txtSegundoNombre_KeyPress;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtPrimerNombre.Location = new Point(129, 38);
            txtPrimerNombre.Margin = new Padding(2, 1, 2, 1);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(89, 19);
            txtPrimerNombre.TabIndex = 23;
            txtPrimerNombre.KeyPress += txtPrimerNombre_KeyPress;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Cascadia Mono", 6.75F);
            label47.Location = new Point(5, 141);
            label47.Margin = new Padding(2, 0, 2, 0);
            label47.Name = "label47";
            label47.Size = new Size(70, 16);
            label47.TabIndex = 22;
            label47.Text = "No.CEDULA";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Cascadia Mono", 6.75F);
            label48.Location = new Point(5, 116);
            label48.Margin = new Padding(2, 0, 2, 0);
            label48.Name = "label48";
            label48.Size = new Size(119, 16);
            label48.TabIndex = 21;
            label48.Text = "SEGUNDO APELLIDO";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Cascadia Mono", 6.75F);
            label49.Location = new Point(5, 91);
            label49.Margin = new Padding(2, 0, 2, 0);
            label49.Name = "label49";
            label49.Size = new Size(112, 16);
            label49.TabIndex = 20;
            label49.Text = "PRIMER APELLIDO";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Cascadia Mono", 6.75F);
            label50.Location = new Point(5, 64);
            label50.Margin = new Padding(2, 0, 2, 0);
            label50.Name = "label50";
            label50.Size = new Size(105, 16);
            label50.TabIndex = 19;
            label50.Text = "SEGUNDO NOMBRE";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Cascadia Mono", 6.75F);
            label51.Location = new Point(5, 39);
            label51.Margin = new Padding(2, 0, 2, 0);
            label51.Name = "label51";
            label51.Size = new Size(98, 16);
            label51.TabIndex = 18;
            label51.Text = "PRIMER NOMBRE";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label52.Location = new Point(2, 4);
            label52.Margin = new Padding(2, 0, 2, 0);
            label52.Name = "label52";
            label52.Size = new Size(303, 35);
            label52.TabIndex = 28;
            label52.Text = "DATOS DEL EMPLEADO";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Image = Properties.Resources.A_adirporfa;
            BtnAgregar.Location = new Point(910, 71);
            BtnAgregar.Margin = new Padding(5, 4, 5, 4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(62, 49);
            BtnAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnAgregar.TabIndex = 42;
            BtnAgregar.TabStop = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 13);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1375, 747);
            tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(btnActualizar);
            tabPage1.Controls.Add(BtnExportar);
            tabPage1.Controls.Add(dgvDatosEmpleado);
            tabPage1.Controls.Add(BtnAgregar);
            tabPage1.Controls.Add(label52);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(1367, 714);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos de Empleados";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Cascadia Mono Light", 8.25F);
            btnEliminar.Location = new Point(1034, 139);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 29);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Cascadia Mono Light", 8.25F);
            btnActualizar.Location = new Point(1034, 81);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 29);
            btnActualizar.TabIndex = 48;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // BtnExportar
            // 
            BtnExportar.Image = Properties.Resources.archivo_excel;
            BtnExportar.Location = new Point(910, 144);
            BtnExportar.Margin = new Padding(5, 4, 5, 4);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(62, 45);
            BtnExportar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnExportar.TabIndex = 47;
            BtnExportar.TabStop = false;
            BtnExportar.Click += BtnExportar_Click;
            // 
            // dgvDatosEmpleado
            // 
            dgvDatosEmpleado.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDatosEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosEmpleado.Location = new Point(54, 288);
            dgvDatosEmpleado.Name = "dgvDatosEmpleado";
            dgvDatosEmpleado.ReadOnly = true;
            dgvDatosEmpleado.RowHeadersWidth = 51;
            dgvDatosEmpleado.Size = new Size(1215, 269);
            dgvDatosEmpleado.TabIndex = 43;
            dgvDatosEmpleado.CellClick += dgvDatosEmpleado_CellClick;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1325, 689);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += frmEmpleados_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnExportar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private Label label34;
        private GroupBox groupBox4;
        private DateTimePicker dtpFechaCierreContrato;
        private DateTimePicker dtpFechaContratacion;
        private TextBox txtRuc;
        private TextBox txtInss;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private GroupBox groupBox5;
        private DateTimePicker FechaNacimiento;
        private Label label41;
        private TextBox txtCelular;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private ComboBox cboEstadoCivil;
        private ComboBox cboSexo;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private GroupBox groupBox6;
        private TextBox txtCedula;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerNombre;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private PictureBox BtnAgregar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvDatosEmpleado;
        private PictureBox BtnExportar;
        private Button btnEliminar;
        private Button btnActualizar;
        private CheckBox chkEstadoEmpleado;
    }
}