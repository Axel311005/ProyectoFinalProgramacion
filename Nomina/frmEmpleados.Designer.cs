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
            dgvNomina = new DataGridView();
            NoEmpleado2 = new DataGridViewTextBoxColumn();
            PNombre2 = new DataGridViewTextBoxColumn();
            sNombre2 = new DataGridViewTextBoxColumn();
            pApellido2 = new DataGridViewTextBoxColumn();
            SApellido2 = new DataGridViewTextBoxColumn();
            SalarioBase2 = new DataGridViewTextBoxColumn();
            Antiguedad = new DataGridViewTextBoxColumn();
            RiesgoLaboral = new DataGridViewTextBoxColumn();
            Nocturnidad = new DataGridViewTextBoxColumn();
            ConceptoOI = new DataGridViewTextBoxColumn();
            MontoOI = new DataGridViewTextBoxColumn();
            HorasExtras = new DataGridViewTextBoxColumn();
            TotalIngresos = new DataGridViewTextBoxColumn();
            Inss = new DataGridViewTextBoxColumn();
            IR = new DataGridViewTextBoxColumn();
            ConceptoOD = new DataGridViewTextBoxColumn();
            MontoOD = new DataGridViewTextBoxColumn();
            Deducciones2 = new DataGridViewTextBoxColumn();
            SalarioNeto = new DataGridViewTextBoxColumn();
            cboTipoPlanilla = new ComboBox();
            DatosIdentidad.SuspendLayout();
            OtrosDatosPersonales.SuspendLayout();
            DatosLaborales.SuspendLayout();
            OtrosDatos.SuspendLayout();
            Ingresos.SuspendLayout();
            Deducciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1050, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 52);
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
            DatosIdentidad.Location = new Point(32, 72);
            DatosIdentidad.Name = "DatosIdentidad";
            DatosIdentidad.Size = new Size(453, 309);
            DatosIdentidad.TabIndex = 2;
            DatosIdentidad.TabStop = false;
            DatosIdentidad.Text = "DATOS DE IDENTIDAD";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtCedula.Location = new Point(189, 212);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(174, 26);
            txtCedula.TabIndex = 27;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(189, 173);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(174, 26);
            txtSegundoApellido.TabIndex = 26;
            txtSegundoApellido.KeyPress += txtSegundoApellido_KeyPress;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerApellido.Location = new Point(189, 127);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(174, 26);
            txtPrimerApellido.TabIndex = 25;
            txtPrimerApellido.KeyPress += txtPrimerApellido_KeyPress;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtSegundoNombre.Location = new Point(189, 89);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(174, 26);
            txtSegundoNombre.TabIndex = 24;
            txtSegundoNombre.KeyPress += txtSegundoNombre_KeyPress;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrimerNombre.Location = new Point(189, 49);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(174, 26);
            txtPrimerNombre.TabIndex = 23;
            txtPrimerNombre.KeyPress += txtPrimerNombre_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 215);
            label6.Name = "label6";
            label6.Size = new Size(103, 19);
            label6.TabIndex = 22;
            label6.Text = "No.CEDULA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 176);
            label5.Name = "label5";
            label5.Size = new Size(175, 19);
            label5.TabIndex = 21;
            label5.Text = "SEGUNDO APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 134);
            label4.Name = "label4";
            label4.Size = new Size(156, 19);
            label4.TabIndex = 20;
            label4.Text = "PRIMER APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(167, 19);
            label3.TabIndex = 19;
            label3.Text = "SEGUNDO NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(148, 19);
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
            OtrosDatosPersonales.Location = new Point(514, 72);
            OtrosDatosPersonales.Name = "OtrosDatosPersonales";
            OtrosDatosPersonales.Size = new Size(445, 320);
            OtrosDatosPersonales.TabIndex = 3;
            OtrosDatosPersonales.TabStop = false;
            OtrosDatosPersonales.Text = "OTROS DATOS PERSONALES";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            FechaNacimiento.Format = DateTimePickerFormat.Short;
            FechaNacimiento.Location = new Point(0, 283);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(335, 26);
            FechaNacimiento.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(0, 255);
            label12.Name = "label12";
            label12.Size = new Size(169, 19);
            label12.TabIndex = 10;
            label12.Text = "FECHA NACIMIENTO";
            // 
            // txtCelular
            // 
            txtCelular.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtCelular.Location = new Point(126, 212);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(208, 26);
            txtCelular.TabIndex = 9;
            txtCelular.KeyPress += txtCelular_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(127, 176);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(208, 26);
            txtTelefono.TabIndex = 8;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(127, 131);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(183, 26);
            txtDireccion.TabIndex = 7;
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(126, 89);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(184, 27);
            cboEstadoCivil.TabIndex = 6;
            // 
            // cboSexo
            // 
            cboSexo.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(126, 48);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(184, 27);
            cboSexo.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(0, 215);
            label11.Name = "label11";
            label11.Size = new Size(87, 19);
            label11.TabIndex = 4;
            label11.Text = "CELULAR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 176);
            label10.Name = "label10";
            label10.Size = new Size(97, 19);
            label10.TabIndex = 3;
            label10.Text = "TELEFONO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(0, 138);
            label9.Name = "label9";
            label9.Size = new Size(100, 19);
            label9.TabIndex = 2;
            label9.Text = "DIRECCION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 97);
            label8.Name = "label8";
            label8.Size = new Size(120, 19);
            label8.TabIndex = 1;
            label8.Text = "ESTADO CIVIL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 55);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
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
            DatosLaborales.Location = new Point(973, 72);
            DatosLaborales.Name = "DatosLaborales";
            DatosLaborales.Size = new Size(441, 320);
            DatosLaborales.TabIndex = 4;
            DatosLaborales.TabStop = false;
            DatosLaborales.Text = "DATOS LABORALES";
            // 
            // FechaCierreContrato
            // 
            FechaCierreContrato.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            FechaCierreContrato.Format = DateTimePickerFormat.Short;
            FechaCierreContrato.Location = new Point(0, 283);
            FechaCierreContrato.Name = "FechaCierreContrato";
            FechaCierreContrato.Size = new Size(315, 26);
            FechaCierreContrato.TabIndex = 9;
            // 
            // FechaContratacion
            // 
            FechaContratacion.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            FechaContratacion.Format = DateTimePickerFormat.Short;
            FechaContratacion.Location = new Point(0, 209);
            FechaContratacion.Name = "FechaContratacion";
            FechaContratacion.Size = new Size(315, 26);
            FechaContratacion.TabIndex = 8;
            FechaContratacion.ValueChanged += FechaContratacion_ValueChanged;
            // 
            // txtRuc
            // 
            txtRuc.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtRuc.Location = new Point(150, 138);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(165, 26);
            txtRuc.TabIndex = 7;
            txtRuc.KeyPress += txtRuc_KeyPress;
            // 
            // txtInss
            // 
            txtInss.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtInss.Location = new Point(150, 97);
            txtInss.Name = "txtInss";
            txtInss.Size = new Size(165, 26);
            txtInss.TabIndex = 6;
            txtInss.KeyPress += txtInss_KeyPress;
            // 
            // txtNoEmpleado
            // 
            txtNoEmpleado.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoEmpleado.Location = new Point(150, 48);
            txtNoEmpleado.Name = "txtNoEmpleado";
            txtNoEmpleado.Size = new Size(165, 26);
            txtNoEmpleado.TabIndex = 5;
            txtNoEmpleado.KeyPress += txtNoEmpleado_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(0, 255);
            label17.Name = "label17";
            label17.Size = new Size(251, 19);
            label17.TabIndex = 4;
            label17.Text = "FECHA CIERRE DE CONTRATO";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(0, 180);
            label16.Name = "label16";
            label16.Size = new Size(223, 19);
            label16.TabIndex = 3;
            label16.Text = "FECHA DE CONTRATACIÓN";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(0, 138);
            label15.Name = "label15";
            label15.Size = new Size(71, 19);
            label15.TabIndex = 2;
            label15.Text = "No.RUC";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(0, 96);
            label14.Name = "label14";
            label14.Size = new Size(73, 19);
            label14.TabIndex = 1;
            label14.Text = "No.INSS";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(0, 55);
            label13.Name = "label13";
            label13.Size = new Size(126, 19);
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
            OtrosDatos.Location = new Point(1429, 72);
            OtrosDatos.Name = "OtrosDatos";
            OtrosDatos.Size = new Size(224, 320);
            OtrosDatos.TabIndex = 5;
            OtrosDatos.TabStop = false;
            OtrosDatos.Text = "OTROS DATOS";
            // 
            // cboEstadoEmpleado
            // 
            cboEstadoEmpleado.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            cboEstadoEmpleado.FormattingEnabled = true;
            cboEstadoEmpleado.Location = new Point(-1, 135);
            cboEstadoEmpleado.Name = "cboEstadoEmpleado";
            cboEstadoEmpleado.Size = new Size(196, 27);
            cboEstadoEmpleado.TabIndex = 3;
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalarioBase.Location = new Point(1, 73);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(194, 26);
            txtSalarioBase.TabIndex = 2;
            txtSalarioBase.KeyPress += txtSalarioBase_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(-1, 111);
            label19.Name = "label19";
            label19.Size = new Size(207, 19);
            label19.TabIndex = 1;
            label19.Text = "ESTADO DEL EMPLEADO";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(0, 51);
            label18.Name = "label18";
            label18.Size = new Size(129, 19);
            label18.TabIndex = 0;
            label18.Text = "SALARIO BASE";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.Red;
            btnAgregarEmpleado.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEmpleado.ForeColor = Color.White;
            btnAgregarEmpleado.Location = new Point(2382, 72);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(170, 46);
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
            btnSalir.Location = new Point(2382, 154);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 46);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Red;
            btnExportar.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(2382, 234);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(159, 46);
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
            Ingresos.Location = new Point(1670, 72);
            Ingresos.Name = "Ingresos";
            Ingresos.Size = new Size(202, 320);
            Ingresos.TabIndex = 10;
            Ingresos.TabStop = false;
            Ingresos.Text = "INGRESOS";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(56, 237);
            label20.Name = "label20";
            label20.Size = new Size(65, 18);
            label20.TabIndex = 6;
            label20.Text = "MONTO";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(43, 176);
            label21.Name = "label21";
            label21.Size = new Size(98, 18);
            label21.TabIndex = 5;
            label21.Text = "CONCEPTO";
            // 
            // txtMontoOtrosIngresos
            // 
            txtMontoOtrosIngresos.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtMontoOtrosIngresos.Location = new Point(23, 258);
            txtMontoOtrosIngresos.Name = "txtMontoOtrosIngresos";
            txtMontoOtrosIngresos.Size = new Size(138, 26);
            txtMontoOtrosIngresos.TabIndex = 4;
            txtMontoOtrosIngresos.KeyPress += txtMontoOtrosIngresos_KeyPress;
            // 
            // txtConceptoOtrosIngresos
            // 
            txtConceptoOtrosIngresos.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtConceptoOtrosIngresos.Location = new Point(23, 208);
            txtConceptoOtrosIngresos.Name = "txtConceptoOtrosIngresos";
            txtConceptoOtrosIngresos.Size = new Size(138, 26);
            txtConceptoOtrosIngresos.TabIndex = 3;
            txtConceptoOtrosIngresos.KeyPress += txtConceptoOtrosIngresos_KeyPress;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtHorasExtras.Location = new Point(9, 87);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(138, 26);
            txtHorasExtras.TabIndex = 2;
            txtHorasExtras.KeyPress += txtHorasExtras_KeyPress;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(0, 131);
            label22.Name = "label22";
            label22.Size = new Size(185, 19);
            label22.TabIndex = 1;
            label22.Text = "OTROS INGRESOS(O.I)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(9, 57);
            label23.Name = "label23";
            label23.Size = new Size(137, 19);
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
            Deducciones.Location = new Point(1878, 72);
            Deducciones.Name = "Deducciones";
            Deducciones.Size = new Size(241, 320);
            Deducciones.TabIndex = 11;
            Deducciones.TabStop = false;
            Deducciones.Text = "DEDUCIONES";
            // 
            // txtConceptoOtrasDeducciones
            // 
            txtConceptoOtrasDeducciones.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtConceptoOtrasDeducciones.Location = new Point(38, 118);
            txtConceptoOtrasDeducciones.Name = "txtConceptoOtrasDeducciones";
            txtConceptoOtrasDeducciones.Size = new Size(153, 26);
            txtConceptoOtrasDeducciones.TabIndex = 4;
            txtConceptoOtrasDeducciones.KeyPress += txtConceptoOtrasDeducciones_KeyPress;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(78, 170);
            label24.Name = "label24";
            label24.Size = new Size(65, 18);
            label24.TabIndex = 3;
            label24.Text = "MONTO";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(61, 89);
            label25.Name = "label25";
            label25.Size = new Size(98, 18);
            label25.TabIndex = 2;
            label25.Text = "CONCEPTO";
            // 
            // txtMontoOtrasDeducciones
            // 
            txtMontoOtrasDeducciones.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtMontoOtrasDeducciones.Location = new Point(32, 191);
            txtMontoOtrasDeducciones.Name = "txtMontoOtrasDeducciones";
            txtMontoOtrasDeducciones.Size = new Size(159, 26);
            txtMontoOtrasDeducciones.TabIndex = 1;
            txtMontoOtrasDeducciones.KeyPress += txtMontoOtrasDeducciones_KeyPress;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(6, 49);
            label26.Name = "label26";
            label26.Size = new Size(228, 19);
            label26.TabIndex = 0;
            label26.Text = "OTRAS DEDUCCIONES(O.D)";
            // 
            // dgvDatosEmpleado
            // 
            dgvDatosEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosEmpleado.Columns.AddRange(new DataGridViewColumn[] { NumeroEmpleado, Cedula, NoInss, NoRuc, PNombre, SNombre, PApellido, SApellido, Nacimiento, Sexo, EstadoCivil, Dirección, Teléfono, Celular, InicioContrato, CierreContrato, SalarioBase, Estado });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosEmpleado.Location = new Point(1, 398);
            dgvDatosEmpleado.Name = "dgvDatosEmpleado";
            dgvDatosEmpleado.RowHeadersWidth = 82;
            dgvDatosEmpleado.RowTemplate.Height = 41;
            dgvDatosEmpleado.Size = new Size(2564, 300);
            dgvDatosEmpleado.TabIndex = 12;
            // 
            // NumeroEmpleado
            // 
            NumeroEmpleado.HeaderText = "Numero Empleado";
            NumeroEmpleado.MinimumWidth = 10;
            NumeroEmpleado.Name = "NumeroEmpleado";
            NumeroEmpleado.Width = 120;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "No.Cedula";
            Cedula.MinimumWidth = 10;
            Cedula.Name = "Cedula";
            Cedula.Width = 170;
            // 
            // NoInss
            // 
            NoInss.HeaderText = "No.Inss";
            NoInss.MinimumWidth = 10;
            NoInss.Name = "NoInss";
            NoInss.Width = 120;
            // 
            // NoRuc
            // 
            NoRuc.HeaderText = "No.Ruc";
            NoRuc.MinimumWidth = 10;
            NoRuc.Name = "NoRuc";
            NoRuc.Width = 120;
            // 
            // PNombre
            // 
            PNombre.HeaderText = "Primer Nombre";
            PNombre.MinimumWidth = 10;
            PNombre.Name = "PNombre";
            PNombre.Width = 160;
            // 
            // SNombre
            // 
            SNombre.HeaderText = "Segundo Nombre";
            SNombre.MinimumWidth = 10;
            SNombre.Name = "SNombre";
            SNombre.Width = 160;
            // 
            // PApellido
            // 
            PApellido.HeaderText = "Primer Apellido";
            PApellido.MinimumWidth = 10;
            PApellido.Name = "PApellido";
            PApellido.Width = 160;
            // 
            // SApellido
            // 
            SApellido.HeaderText = "Segundo Apellido";
            SApellido.MinimumWidth = 10;
            SApellido.Name = "SApellido";
            SApellido.Width = 160;
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
            Sexo.Width = 90;
            // 
            // EstadoCivil
            // 
            EstadoCivil.HeaderText = "Estado Civil";
            EstadoCivil.MinimumWidth = 10;
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.Width = 130;
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.MinimumWidth = 10;
            Dirección.Name = "Dirección";
            Dirección.Width = 200;
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 10;
            Teléfono.Name = "Teléfono";
            Teléfono.Width = 130;
            // 
            // Celular
            // 
            Celular.HeaderText = "Celular";
            Celular.MinimumWidth = 10;
            Celular.Name = "Celular";
            Celular.Width = 130;
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
            SalarioBase.Width = 160;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 10;
            Estado.Name = "Estado";
            Estado.Width = 120;
            // 
            // dgvNomina
            // 
            dgvNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNomina.Columns.AddRange(new DataGridViewColumn[] { NoEmpleado2, PNombre2, sNombre2, pApellido2, SApellido2, SalarioBase2, Antiguedad, RiesgoLaboral, Nocturnidad, ConceptoOI, MontoOI, HorasExtras, TotalIngresos, Inss, IR, ConceptoOD, MontoOD, Deducciones2, SalarioNeto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNomina.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNomina.Location = new Point(1, 842);
            dgvNomina.Name = "dgvNomina";
            dgvNomina.RowHeadersWidth = 82;
            dgvNomina.RowTemplate.Height = 41;
            dgvNomina.Size = new Size(2564, 300);
            dgvNomina.TabIndex = 13;
            // 
            // NoEmpleado2
            // 
            NoEmpleado2.HeaderText = "Numero Empleado";
            NoEmpleado2.MinimumWidth = 10;
            NoEmpleado2.Name = "NoEmpleado2";
            NoEmpleado2.Width = 120;
            // 
            // PNombre2
            // 
            PNombre2.HeaderText = "Primer Nombre";
            PNombre2.MinimumWidth = 10;
            PNombre2.Name = "PNombre2";
            PNombre2.Width = 150;
            // 
            // sNombre2
            // 
            sNombre2.HeaderText = "Segundo Nombre";
            sNombre2.MinimumWidth = 10;
            sNombre2.Name = "sNombre2";
            sNombre2.Width = 150;
            // 
            // pApellido2
            // 
            pApellido2.HeaderText = "Primer Apellido";
            pApellido2.MinimumWidth = 10;
            pApellido2.Name = "pApellido2";
            pApellido2.Width = 150;
            // 
            // SApellido2
            // 
            SApellido2.HeaderText = "Segundo Apellido";
            SApellido2.MinimumWidth = 10;
            SApellido2.Name = "SApellido2";
            SApellido2.Width = 150;
            // 
            // SalarioBase2
            // 
            SalarioBase2.HeaderText = "Salario Base";
            SalarioBase2.MinimumWidth = 10;
            SalarioBase2.Name = "SalarioBase2";
            SalarioBase2.Width = 140;
            // 
            // Antiguedad
            // 
            Antiguedad.HeaderText = "Antiguedad";
            Antiguedad.MinimumWidth = 10;
            Antiguedad.Name = "Antiguedad";
            Antiguedad.Width = 120;
            // 
            // RiesgoLaboral
            // 
            RiesgoLaboral.HeaderText = "Riesgo Laboral";
            RiesgoLaboral.MinimumWidth = 10;
            RiesgoLaboral.Name = "RiesgoLaboral";
            RiesgoLaboral.Width = 120;
            // 
            // Nocturnidad
            // 
            Nocturnidad.HeaderText = "Nocturnidad";
            Nocturnidad.MinimumWidth = 10;
            Nocturnidad.Name = "Nocturnidad";
            Nocturnidad.Width = 120;
            // 
            // ConceptoOI
            // 
            ConceptoOI.HeaderText = "Concepto O.I";
            ConceptoOI.MinimumWidth = 10;
            ConceptoOI.Name = "ConceptoOI";
            ConceptoOI.Width = 140;
            // 
            // MontoOI
            // 
            MontoOI.HeaderText = "Monto O.I";
            MontoOI.MinimumWidth = 10;
            MontoOI.Name = "MontoOI";
            MontoOI.Width = 120;
            // 
            // HorasExtras
            // 
            HorasExtras.HeaderText = "Horas Extras";
            HorasExtras.MinimumWidth = 10;
            HorasExtras.Name = "HorasExtras";
            HorasExtras.Width = 120;
            // 
            // TotalIngresos
            // 
            TotalIngresos.HeaderText = "Total Ingresos";
            TotalIngresos.MinimumWidth = 10;
            TotalIngresos.Name = "TotalIngresos";
            TotalIngresos.Width = 130;
            // 
            // Inss
            // 
            Inss.HeaderText = "Inss";
            Inss.MinimumWidth = 10;
            Inss.Name = "Inss";
            Inss.Width = 120;
            // 
            // IR
            // 
            IR.HeaderText = "IR";
            IR.MinimumWidth = 10;
            IR.Name = "IR";
            IR.Width = 120;
            // 
            // ConceptoOD
            // 
            ConceptoOD.HeaderText = "Concepto O.D";
            ConceptoOD.MinimumWidth = 10;
            ConceptoOD.Name = "ConceptoOD";
            ConceptoOD.Width = 140;
            // 
            // MontoOD
            // 
            MontoOD.HeaderText = "Monto O.D";
            MontoOD.MinimumWidth = 10;
            MontoOD.Name = "MontoOD";
            MontoOD.Width = 120;
            // 
            // Deducciones2
            // 
            Deducciones2.HeaderText = "Total Deducciones";
            Deducciones2.MinimumWidth = 10;
            Deducciones2.Name = "Deducciones2";
            Deducciones2.Width = 130;
            // 
            // SalarioNeto
            // 
            SalarioNeto.HeaderText = "Salario Neto";
            SalarioNeto.MinimumWidth = 10;
            SalarioNeto.Name = "SalarioNeto";
            SalarioNeto.Width = 130;
            // 
            // cboTipoPlanilla
            // 
            cboTipoPlanilla.FormattingEnabled = true;
            cboTipoPlanilla.Location = new Point(2135, 196);
            cboTipoPlanilla.Name = "cboTipoPlanilla";
            cboTipoPlanilla.Size = new Size(205, 40);
            cboTipoPlanilla.TabIndex = 14;
            cboTipoPlanilla.Text = "Seleccione";
            cboTipoPlanilla.SelectedIndexChanged += cboTipoPlanilla_SelectedIndexChanged;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(2564, 1354);
            Controls.Add(cboTipoPlanilla);
            Controls.Add(dgvNomina);
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
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
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
        private DataGridView dgvNomina;
        private DataGridViewTextBoxColumn NoEmpleado2;
        private DataGridViewTextBoxColumn PNombre2;
        private DataGridViewTextBoxColumn sNombre2;
        private DataGridViewTextBoxColumn pApellido2;
        private DataGridViewTextBoxColumn SApellido2;
        private DataGridViewTextBoxColumn SalarioBase2;
        private DataGridViewTextBoxColumn Antiguedad;
        private DataGridViewTextBoxColumn RiesgoLaboral;
        private DataGridViewTextBoxColumn Nocturnidad;
        private DataGridViewTextBoxColumn ConceptoOI;
        private DataGridViewTextBoxColumn MontoOI;
        private DataGridViewTextBoxColumn HorasExtras;
        private DataGridViewTextBoxColumn TotalIngresos;
        private DataGridViewTextBoxColumn Inss;
        private DataGridViewTextBoxColumn IR;
        private DataGridViewTextBoxColumn ConceptoOD;
        private DataGridViewTextBoxColumn MontoOD;
        private DataGridViewTextBoxColumn Deducciones2;
        private DataGridViewTextBoxColumn SalarioNeto;
        private ComboBox cboTipoPlanilla;
    }
}