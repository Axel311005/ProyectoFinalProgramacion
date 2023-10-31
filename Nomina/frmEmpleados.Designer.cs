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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            DatosIdentidad = new GroupBox();
            txtCedula = new TextBox();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            OtrosDatosPersonales = new GroupBox();
            FechaNacimiento = new DateTimePicker();
            label12 = new Label();
            txtCelular = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            cboEstadoCivil = new ComboBox();
            cboSexo = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            DatosLaborales = new GroupBox();
            FechaCierreContrato = new DateTimePicker();
            FechaContratacion = new DateTimePicker();
            txtRuc = new TextBox();
            txtInss = new TextBox();
            txtNoEmpleado = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            OtrosDatos = new GroupBox();
            cboEstadoEmpleado = new ComboBox();
            txtSalarioBase = new TextBox();
            label19 = new Label();
            label18 = new Label();
            btnAgregarEmpleado = new Button();
            btnSalir = new Button();
            btnExportar = new Button();
            Ingresos = new GroupBox();
            label20 = new Label();
            label21 = new Label();
            txtMontoOtrosIngresos = new TextBox();
            txtConceptoOtrosIngresos = new TextBox();
            txtHorasExtras = new TextBox();
            label22 = new Label();
            label23 = new Label();
            Deducciones = new GroupBox();
            txtConceptoOtrasDeducciones = new TextBox();
            label24 = new Label();
            label25 = new Label();
            txtMontoOtrasDeducciones = new TextBox();
            label26 = new Label();
            dgvDatosEmpleado = new DataGridView();
            NumeroEmpleado = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            NoInss = new DataGridViewTextBoxColumn();
            NoRuc = new DataGridViewTextBoxColumn();
            PNombre = new DataGridViewTextBoxColumn();
            SNombre = new DataGridViewTextBoxColumn();
            PApellido = new DataGridViewTextBoxColumn();
            SApellido = new DataGridViewTextBoxColumn();
            Nacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            EstadoCivil = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            InicioContrato = new DataGridViewTextBoxColumn();
            CierreContrato = new DataGridViewTextBoxColumn();
            SalarioBase = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnPlanilla = new Button();
            DatosIdentidad.SuspendLayout();
            OtrosDatosPersonales.SuspendLayout();
            DatosLaborales.SuspendLayout();
            OtrosDatos.SuspendLayout();
            Ingresos.SuspendLayout();
            Deducciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(565, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 27);
            label1.TabIndex = 0;
            label1.Text = "DATOS DEL EMPLEADO";
            // 
            // DatosIdentidad
            // 
            DatosIdentidad.Controls.Add(txtCedula);
            DatosIdentidad.Controls.Add(txtSegundoApellido);
            DatosIdentidad.Controls.Add(txtPrimerApellido);
            DatosIdentidad.Controls.Add(txtSegundoNombre);
            DatosIdentidad.Controls.Add(txtPrimerNombre);
            DatosIdentidad.Controls.Add(label6);
            DatosIdentidad.Controls.Add(label5);
            DatosIdentidad.Controls.Add(label4);
            DatosIdentidad.Controls.Add(label3);
            DatosIdentidad.Controls.Add(label2);
            DatosIdentidad.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            DatosIdentidad.Location = new Point(17, 34);
            DatosIdentidad.Margin = new Padding(2, 1, 2, 1);
            DatosIdentidad.Name = "DatosIdentidad";
            DatosIdentidad.Padding = new Padding(2, 1, 2, 1);
            DatosIdentidad.Size = new Size(194, 150);
            DatosIdentidad.TabIndex = 2;
            DatosIdentidad.TabStop = false;
            DatosIdentidad.Text = "DATOS DE IDENTIDAD";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtCedula.Location = new Point(102, 99);
            txtCedula.Margin = new Padding(2, 1, 2, 1);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(78, 17);
            txtCedula.TabIndex = 27;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(102, 81);
            txtSegundoApellido.Margin = new Padding(2, 1, 2, 1);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(78, 17);
            txtSegundoApellido.TabIndex = 26;
            txtSegundoApellido.KeyPress += txtSegundoApellido_KeyPress;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerApellido.Location = new Point(102, 60);
            txtPrimerApellido.Margin = new Padding(2, 1, 2, 1);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(78, 17);
            txtPrimerApellido.TabIndex = 25;
            txtPrimerApellido.KeyPress += txtPrimerApellido_KeyPress;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoNombre.Location = new Point(102, 42);
            txtSegundoNombre.Margin = new Padding(2, 1, 2, 1);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(78, 17);
            txtSegundoNombre.TabIndex = 24;
            txtSegundoNombre.KeyPress += txtSegundoNombre_KeyPress;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerNombre.Location = new Point(102, 23);
            txtPrimerNombre.Margin = new Padding(2, 1, 2, 1);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(78, 17);
            txtPrimerNombre.TabIndex = 23;
            txtPrimerNombre.KeyPress += txtPrimerNombre_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 101);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 10);
            label6.TabIndex = 22;
            label6.Text = "No.CEDULA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 82);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 10);
            label5.TabIndex = 21;
            label5.Text = "SEGUNDO APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 63);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 10);
            label4.TabIndex = 20;
            label4.Text = "PRIMER APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 43);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 10);
            label3.TabIndex = 19;
            label3.Text = "SEGUNDO NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 10);
            label2.TabIndex = 18;
            label2.Text = "PRIMER NOMBRE";
            // 
            // OtrosDatosPersonales
            // 
            OtrosDatosPersonales.Controls.Add(FechaNacimiento);
            OtrosDatosPersonales.Controls.Add(label12);
            OtrosDatosPersonales.Controls.Add(txtCelular);
            OtrosDatosPersonales.Controls.Add(txtTelefono);
            OtrosDatosPersonales.Controls.Add(txtDireccion);
            OtrosDatosPersonales.Controls.Add(cboEstadoCivil);
            OtrosDatosPersonales.Controls.Add(cboSexo);
            OtrosDatosPersonales.Controls.Add(label11);
            OtrosDatosPersonales.Controls.Add(label10);
            OtrosDatosPersonales.Controls.Add(label9);
            OtrosDatosPersonales.Controls.Add(label8);
            OtrosDatosPersonales.Controls.Add(label7);
            OtrosDatosPersonales.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            OtrosDatosPersonales.Location = new Point(221, 34);
            OtrosDatosPersonales.Margin = new Padding(2, 1, 2, 1);
            OtrosDatosPersonales.Name = "OtrosDatosPersonales";
            OtrosDatosPersonales.Padding = new Padding(2, 1, 2, 1);
            OtrosDatosPersonales.Size = new Size(184, 150);
            OtrosDatosPersonales.TabIndex = 3;
            OtrosDatosPersonales.TabStop = false;
            OtrosDatosPersonales.Text = "OTROS DATOS PERSONALES";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            FechaNacimiento.Format = DateTimePickerFormat.Short;
            FechaNacimiento.Location = new Point(0, 133);
            FechaNacimiento.Margin = new Padding(2, 1, 2, 1);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(169, 17);
            FechaNacimiento.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(0, 120);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(84, 10);
            label12.TabIndex = 10;
            label12.Text = "FECHA NACIMIENTO";
            // 
            // txtCelular
            // 
            txtCelular.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtCelular.Location = new Point(68, 99);
            txtCelular.Margin = new Padding(2, 1, 2, 1);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(101, 17);
            txtCelular.TabIndex = 9;
            txtCelular.KeyPress += txtCelular_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(68, 82);
            txtTelefono.Margin = new Padding(2, 1, 2, 1);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(101, 17);
            txtTelefono.TabIndex = 8;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(68, 61);
            txtDireccion.Margin = new Padding(2, 1, 2, 1);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 17);
            txtDireccion.TabIndex = 7;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(68, 42);
            cboEstadoCivil.Margin = new Padding(2, 1, 2, 1);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(101, 18);
            cboEstadoCivil.TabIndex = 6;
            // 
            // cboSexo
            // 
            cboSexo.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(68, 22);
            cboSexo.Margin = new Padding(2, 1, 2, 1);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(101, 18);
            cboSexo.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(0, 101);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(43, 10);
            label11.TabIndex = 4;
            label11.Text = "CELULAR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 82);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(48, 10);
            label10.TabIndex = 3;
            label10.Text = "TELEFONO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(0, 65);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 10);
            label9.TabIndex = 2;
            label9.Text = "DIRECCION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 45);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 10);
            label8.TabIndex = 1;
            label8.Text = "ESTADO CIVIL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 26);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(26, 10);
            label7.TabIndex = 0;
            label7.Text = "SEXO";
            // 
            // DatosLaborales
            // 
            DatosLaborales.Controls.Add(FechaCierreContrato);
            DatosLaborales.Controls.Add(FechaContratacion);
            DatosLaborales.Controls.Add(txtRuc);
            DatosLaborales.Controls.Add(txtInss);
            DatosLaborales.Controls.Add(txtNoEmpleado);
            DatosLaborales.Controls.Add(label17);
            DatosLaborales.Controls.Add(label16);
            DatosLaborales.Controls.Add(label15);
            DatosLaborales.Controls.Add(label14);
            DatosLaborales.Controls.Add(label13);
            DatosLaborales.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DatosLaborales.Location = new Point(419, 34);
            DatosLaborales.Margin = new Padding(2, 1, 2, 1);
            DatosLaborales.Name = "DatosLaborales";
            DatosLaborales.Padding = new Padding(2, 1, 2, 1);
            DatosLaborales.Size = new Size(184, 150);
            DatosLaborales.TabIndex = 4;
            DatosLaborales.TabStop = false;
            DatosLaborales.Text = "DATOS LABORALES";
            // 
            // FechaCierreContrato
            // 
            FechaCierreContrato.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            FechaCierreContrato.Format = DateTimePickerFormat.Short;
            FechaCierreContrato.Location = new Point(0, 133);
            FechaCierreContrato.Margin = new Padding(2, 1, 2, 1);
            FechaCierreContrato.Name = "FechaCierreContrato";
            FechaCierreContrato.Size = new Size(171, 17);
            FechaCierreContrato.TabIndex = 9;
            // 
            // FechaContratacion
            // 
            FechaContratacion.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            FechaContratacion.Format = DateTimePickerFormat.Short;
            FechaContratacion.Location = new Point(0, 98);
            FechaContratacion.Margin = new Padding(2, 1, 2, 1);
            FechaContratacion.Name = "FechaContratacion";
            FechaContratacion.Size = new Size(171, 17);
            FechaContratacion.TabIndex = 8;
            FechaContratacion.ValueChanged += FechaContratacion_ValueChanged;
            // 
            // txtRuc
            // 
            txtRuc.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtRuc.Location = new Point(81, 65);
            txtRuc.Margin = new Padding(2, 1, 2, 1);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(91, 17);
            txtRuc.TabIndex = 7;
            txtRuc.KeyPress += txtRuc_KeyPress;
            // 
            // txtInss
            // 
            txtInss.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtInss.Location = new Point(81, 45);
            txtInss.Margin = new Padding(2, 1, 2, 1);
            txtInss.Name = "txtInss";
            txtInss.Size = new Size(91, 17);
            txtInss.TabIndex = 6;
            txtInss.KeyPress += txtInss_KeyPress;
            // 
            // txtNoEmpleado
            // 
            txtNoEmpleado.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoEmpleado.Location = new Point(81, 22);
            txtNoEmpleado.Margin = new Padding(2, 1, 2, 1);
            txtNoEmpleado.Name = "txtNoEmpleado";
            txtNoEmpleado.Size = new Size(91, 17);
            txtNoEmpleado.TabIndex = 5;
            txtNoEmpleado.KeyPress += txtNoEmpleado_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(0, 120);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(123, 10);
            label17.TabIndex = 4;
            label17.Text = "FECHA CIERRE DE CONTRATO";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(0, 84);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(109, 10);
            label16.TabIndex = 3;
            label16.Text = "FECHA DE CONTRATACIÓN";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(0, 65);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 10);
            label15.TabIndex = 2;
            label15.Text = "No.RUC";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(0, 45);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(36, 10);
            label14.TabIndex = 1;
            label14.Text = "No.INSS";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(0, 26);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 10);
            label13.TabIndex = 0;
            label13.Text = "No.EMPLEADO";
            // 
            // OtrosDatos
            // 
            OtrosDatos.Controls.Add(cboEstadoEmpleado);
            OtrosDatos.Controls.Add(txtSalarioBase);
            OtrosDatos.Controls.Add(label19);
            OtrosDatos.Controls.Add(label18);
            OtrosDatos.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OtrosDatos.Location = new Point(613, 34);
            OtrosDatos.Margin = new Padding(2, 1, 2, 1);
            OtrosDatos.Name = "OtrosDatos";
            OtrosDatos.Padding = new Padding(2, 1, 2, 1);
            OtrosDatos.Size = new Size(117, 150);
            OtrosDatos.TabIndex = 5;
            OtrosDatos.TabStop = false;
            OtrosDatos.Text = "OTROS DATOS";
            // 
            // cboEstadoEmpleado
            // 
            cboEstadoEmpleado.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            cboEstadoEmpleado.FormattingEnabled = true;
            cboEstadoEmpleado.Location = new Point(15, 75);
            cboEstadoEmpleado.Margin = new Padding(2, 1, 2, 1);
            cboEstadoEmpleado.Name = "cboEstadoEmpleado";
            cboEstadoEmpleado.Size = new Size(83, 18);
            cboEstadoEmpleado.TabIndex = 3;
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalarioBase.Location = new Point(15, 40);
            txtSalarioBase.Margin = new Padding(2, 1, 2, 1);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(79, 17);
            txtSalarioBase.TabIndex = 2;
            txtSalarioBase.KeyPress += txtSalarioBase_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(0, 61);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(100, 10);
            label19.TabIndex = 1;
            label19.Text = "ESTADO DEL EMPLEADO";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(15, 24);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(62, 10);
            label18.TabIndex = 0;
            label18.Text = "SALARIO BASE";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.Red;
            btnAgregarEmpleado.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEmpleado.ForeColor = Color.White;
            btnAgregarEmpleado.Location = new Point(1005, 44);
            btnAgregarEmpleado.Margin = new Padding(2, 1, 2, 1);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(92, 22);
            btnAgregarEmpleado.TabIndex = 6;
            btnAgregarEmpleado.Text = "AGREGAR EMPLEADO";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1005, 74);
            btnSalir.Margin = new Padding(2, 1, 2, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 22);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Red;
            btnExportar.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(1005, 107);
            btnExportar.Margin = new Padding(2, 1, 2, 1);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(92, 22);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // Ingresos
            // 
            Ingresos.Controls.Add(label20);
            Ingresos.Controls.Add(label21);
            Ingresos.Controls.Add(txtMontoOtrosIngresos);
            Ingresos.Controls.Add(txtConceptoOtrosIngresos);
            Ingresos.Controls.Add(txtHorasExtras);
            Ingresos.Controls.Add(label22);
            Ingresos.Controls.Add(label23);
            Ingresos.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ingresos.Location = new Point(741, 34);
            Ingresos.Margin = new Padding(2, 1, 2, 1);
            Ingresos.Name = "Ingresos";
            Ingresos.Padding = new Padding(2, 1, 2, 1);
            Ingresos.Size = new Size(101, 150);
            Ingresos.TabIndex = 10;
            Ingresos.TabStop = false;
            Ingresos.Text = "INGRESOS";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(30, 111);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(35, 10);
            label20.TabIndex = 6;
            label20.Text = "MONTO";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(22, 83);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(50, 10);
            label21.TabIndex = 5;
            label21.Text = "CONCEPTO";
            // 
            // txtMontoOtrosIngresos
            // 
            txtMontoOtrosIngresos.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtMontoOtrosIngresos.Location = new Point(12, 121);
            txtMontoOtrosIngresos.Margin = new Padding(2, 1, 2, 1);
            txtMontoOtrosIngresos.Name = "txtMontoOtrosIngresos";
            txtMontoOtrosIngresos.Size = new Size(76, 17);
            txtMontoOtrosIngresos.TabIndex = 4;
            txtMontoOtrosIngresos.KeyPress += txtMontoOtrosIngresos_KeyPress;
            // 
            // txtConceptoOtrosIngresos
            // 
            txtConceptoOtrosIngresos.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtConceptoOtrosIngresos.Location = new Point(12, 98);
            txtConceptoOtrosIngresos.Margin = new Padding(2, 1, 2, 1);
            txtConceptoOtrosIngresos.Name = "txtConceptoOtrosIngresos";
            txtConceptoOtrosIngresos.Size = new Size(76, 17);
            txtConceptoOtrosIngresos.TabIndex = 3;
            txtConceptoOtrosIngresos.KeyPress += txtConceptoOtrosIngresos_KeyPress;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtHorasExtras.Location = new Point(12, 41);
            txtHorasExtras.Margin = new Padding(2, 1, 2, 1);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(76, 17);
            txtHorasExtras.TabIndex = 2;
            txtHorasExtras.KeyPress += txtHorasExtras_KeyPress;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(0, 61);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(92, 10);
            label22.TabIndex = 1;
            label22.Text = "OTROS INGRESOS(O.I)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(12, 26);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(66, 10);
            label23.TabIndex = 0;
            label23.Text = "HORAS EXTRAS";
            // 
            // Deducciones
            // 
            Deducciones.Controls.Add(txtConceptoOtrasDeducciones);
            Deducciones.Controls.Add(label24);
            Deducciones.Controls.Add(label25);
            Deducciones.Controls.Add(txtMontoOtrasDeducciones);
            Deducciones.Controls.Add(label26);
            Deducciones.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Deducciones.Location = new Point(857, 34);
            Deducciones.Margin = new Padding(2, 1, 2, 1);
            Deducciones.Name = "Deducciones";
            Deducciones.Padding = new Padding(2, 1, 2, 1);
            Deducciones.Size = new Size(124, 150);
            Deducciones.TabIndex = 11;
            Deducciones.TabStop = false;
            Deducciones.Text = "DEDUCIONES";
            // 
            // txtConceptoOtrasDeducciones
            // 
            txtConceptoOtrasDeducciones.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtConceptoOtrasDeducciones.Location = new Point(20, 55);
            txtConceptoOtrasDeducciones.Margin = new Padding(2, 1, 2, 1);
            txtConceptoOtrasDeducciones.Name = "txtConceptoOtrasDeducciones";
            txtConceptoOtrasDeducciones.Size = new Size(84, 17);
            txtConceptoOtrasDeducciones.TabIndex = 4;
            txtConceptoOtrasDeducciones.KeyPress += txtConceptoOtrasDeducciones_KeyPress;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(42, 80);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(35, 10);
            label24.TabIndex = 3;
            label24.Text = "MONTO";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(33, 42);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(50, 10);
            label25.TabIndex = 2;
            label25.Text = "CONCEPTO";
            // 
            // txtMontoOtrasDeducciones
            // 
            txtMontoOtrasDeducciones.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtMontoOtrasDeducciones.Location = new Point(17, 90);
            txtMontoOtrasDeducciones.Margin = new Padding(2, 1, 2, 1);
            txtMontoOtrasDeducciones.Name = "txtMontoOtrasDeducciones";
            txtMontoOtrasDeducciones.Size = new Size(87, 17);
            txtMontoOtrasDeducciones.TabIndex = 1;
            txtMontoOtrasDeducciones.KeyPress += txtMontoOtrasDeducciones_KeyPress;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(3, 23);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(113, 10);
            label26.TabIndex = 0;
            label26.Text = "OTRAS DEDUCCIONES(O.D)";
            // 
            // dgvDatosEmpleado
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatosEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosEmpleado.Columns.AddRange(new DataGridViewColumn[] { NumeroEmpleado, Cedula, NoInss, NoRuc, PNombre, SNombre, PApellido, SApellido, Nacimiento, Sexo, EstadoCivil, Dirección, Teléfono, Celular, InicioContrato, CierreContrato, SalarioBase, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDatosEmpleado.Location = new Point(9, 207);
            dgvDatosEmpleado.Margin = new Padding(2, 1, 2, 1);
            dgvDatosEmpleado.Name = "dgvDatosEmpleado";
            dgvDatosEmpleado.RowHeadersWidth = 82;
            dgvDatosEmpleado.RowTemplate.Height = 41;
            dgvDatosEmpleado.Size = new Size(1113, 124);
            dgvDatosEmpleado.TabIndex = 12;
            // 
            // NumeroEmpleado
            // 
            NumeroEmpleado.HeaderText = "Numero Empleado";
            NumeroEmpleado.MinimumWidth = 10;
            NumeroEmpleado.Name = "NumeroEmpleado";
            NumeroEmpleado.Width = 110;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "No.Cedula";
            Cedula.MinimumWidth = 10;
            Cedula.Name = "Cedula";
            Cedula.Width = 110;
            // 
            // NoInss
            // 
            NoInss.HeaderText = "No.Inss";
            NoInss.MinimumWidth = 10;
            NoInss.Name = "NoInss";
            NoInss.Width = 110;
            // 
            // NoRuc
            // 
            NoRuc.HeaderText = "No.Ruc";
            NoRuc.MinimumWidth = 10;
            NoRuc.Name = "NoRuc";
            NoRuc.Width = 110;
            // 
            // PNombre
            // 
            PNombre.HeaderText = "Primer Nombre";
            PNombre.MinimumWidth = 10;
            PNombre.Name = "PNombre";
            PNombre.Width = 120;
            // 
            // SNombre
            // 
            SNombre.HeaderText = "Segundo Nombre";
            SNombre.MinimumWidth = 10;
            SNombre.Name = "SNombre";
            SNombre.Width = 120;
            // 
            // PApellido
            // 
            PApellido.HeaderText = "Primer Apellido";
            PApellido.MinimumWidth = 10;
            PApellido.Name = "PApellido";
            PApellido.Width = 120;
            // 
            // SApellido
            // 
            SApellido.HeaderText = "Segundo Apellido";
            SApellido.MinimumWidth = 10;
            SApellido.Name = "SApellido";
            SApellido.Width = 120;
            // 
            // Nacimiento
            // 
            Nacimiento.HeaderText = "Fecha Nacimiento";
            Nacimiento.MinimumWidth = 10;
            Nacimiento.Name = "Nacimiento";
            Nacimiento.Width = 120;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 10;
            Sexo.Name = "Sexo";
            Sexo.Width = 50;
            // 
            // EstadoCivil
            // 
            EstadoCivil.HeaderText = "Estado Civil";
            EstadoCivil.MinimumWidth = 10;
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.Width = 90;
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.MinimumWidth = 10;
            Dirección.Name = "Dirección";
            Dirección.Width = 160;
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 10;
            Teléfono.Name = "Teléfono";
            Teléfono.Width = 90;
            // 
            // Celular
            // 
            Celular.HeaderText = "Celular";
            Celular.MinimumWidth = 10;
            Celular.Name = "Celular";
            Celular.Width = 90;
            // 
            // InicioContrato
            // 
            InicioContrato.HeaderText = "Inicio Contrato";
            InicioContrato.MinimumWidth = 10;
            InicioContrato.Name = "InicioContrato";
            InicioContrato.Width = 120;
            // 
            // CierreContrato
            // 
            CierreContrato.HeaderText = "Cierre Contrato";
            CierreContrato.MinimumWidth = 10;
            CierreContrato.Name = "CierreContrato";
            CierreContrato.Width = 120;
            // 
            // SalarioBase
            // 
            SalarioBase.HeaderText = "Salario Base";
            SalarioBase.MinimumWidth = 10;
            SalarioBase.Name = "SalarioBase";
            SalarioBase.Width = 120;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            // 
            // btnPlanilla
            // 
            btnPlanilla.Location = new Point(1005, 145);
            btnPlanilla.Margin = new Padding(2, 1, 2, 1);
            btnPlanilla.Name = "btnPlanilla";
            btnPlanilla.Size = new Size(108, 22);
            btnPlanilla.TabIndex = 15;
            btnPlanilla.Text = "Calcular Planilla";
            btnPlanilla.UseVisualStyleBackColor = true;
            btnPlanilla.Click += btnPlanilla_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(979, 351);
            Controls.Add(btnPlanilla);
            Controls.Add(dgvDatosEmpleado);
            Controls.Add(Deducciones);
            Controls.Add(Ingresos);
            Controls.Add(btnExportar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(OtrosDatos);
            Controls.Add(DatosLaborales);
            Controls.Add(OtrosDatosPersonales);
            Controls.Add(DatosIdentidad);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += frmEmpleados_Load;
            DatosIdentidad.ResumeLayout(false);
            DatosIdentidad.PerformLayout();
            OtrosDatosPersonales.ResumeLayout(false);
            OtrosDatosPersonales.PerformLayout();
            DatosLaborales.ResumeLayout(false);
            DatosLaborales.PerformLayout();
            OtrosDatos.ResumeLayout(false);
            OtrosDatos.PerformLayout();
            Ingresos.ResumeLayout(false);
            Ingresos.PerformLayout();
            Deducciones.ResumeLayout(false);
            Deducciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox DatosIdentidad;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCedula;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerNombre;
        private GroupBox OtrosDatosPersonales;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label12;
        private TextBox txtCelular;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private ComboBox cboEstadoCivil;
        private ComboBox cboSexo;
        private GroupBox DatosLaborales;
        private TextBox txtRuc;
        private TextBox txtInss;
        private TextBox txtNoEmpleado;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private DateTimePicker FechaNacimiento;
        private DateTimePicker FechaCierreContrato;
        private DateTimePicker FechaContratacion;
        private GroupBox OtrosDatos;
        private ComboBox cboEstadoEmpleado;
        private TextBox txtSalarioBase;
        private Label label19;
        private Label label18;
        private Button btnAgregarEmpleado;
        private Button btnSalir;
        private Button btnExportar;
        private GroupBox Ingresos;
        private Label label20;
        private Label label21;
        private TextBox txtMontoOtrosIngresos;
        private TextBox txtConceptoOtrosIngresos;
        private TextBox txtHorasExtras;
        private Label label22;
        private Label label23;
        private GroupBox Deducciones;
        private TextBox txtConceptoOtrasDeducciones;
        private Label label24;
        private Label label25;
        private TextBox txtMontoOtrasDeducciones;
        private Label label26;
        private DataGridView dgvDatosEmpleado;
        private Button btnPlanilla;
        private DataGridViewTextBoxColumn NumeroEmpleado;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn NoInss;
        private DataGridViewTextBoxColumn NoRuc;
        private DataGridViewTextBoxColumn PNombre;
        private DataGridViewTextBoxColumn SNombre;
        private DataGridViewTextBoxColumn PApellido;
        private DataGridViewTextBoxColumn SApellido;
        private DataGridViewTextBoxColumn Nacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn EstadoCivil;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn InicioContrato;
        private DataGridViewTextBoxColumn CierreContrato;
        private DataGridViewTextBoxColumn SalarioBase;
        private DataGridViewTextBoxColumn Estado;
    }
}