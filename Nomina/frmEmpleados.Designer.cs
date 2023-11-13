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
            dgvDatosEmpleado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtConceptoOtrosIngresos = new TextBox();
            label27 = new Label();
            label28 = new Label();
            txtMontoOtrasDeducciones = new TextBox();
            label29 = new Label();
            groupBox2 = new GroupBox();
            label30 = new Label();
            label31 = new Label();
            txtMontoOtrosIngresos = new TextBox();
            txtConceptoOtrasDeducciones = new TextBox();
            txtHorasExtras = new TextBox();
            label32 = new Label();
            label33 = new Label();
            groupBox3 = new GroupBox();
            cboEstadoEmpleado = new ComboBox();
            txtSalarioBase = new TextBox();
            label34 = new Label();
            label35 = new Label();
            groupBox4 = new GroupBox();
            FechaCierreContrato = new DateTimePicker();
            FechaContratacion = new DateTimePicker();
            txtRuc = new TextBox();
            txtInss = new TextBox();
            txtNoEmpleado = new TextBox();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
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
            BtnExportar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmpleado).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnExportar).BeginInit();
            SuspendLayout();
            // 
            // dgvDatosEmpleado
            // 
            dgvDatosEmpleado.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatosEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosEmpleado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDatosEmpleado.Location = new Point(36, 257);
            dgvDatosEmpleado.Margin = new Padding(2, 1, 2, 1);
            dgvDatosEmpleado.Name = "dgvDatosEmpleado";
            dgvDatosEmpleado.RowHeadersWidth = 82;
            dgvDatosEmpleado.RowTemplate.Height = 41;
            dgvDatosEmpleado.Size = new Size(1128, 299);
            dgvDatosEmpleado.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Numero Empleado";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "No.Cedula";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "No.Inss";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "No.Ruc";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Primer Nombre";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Segundo Nombre";
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Primer Apellido";
            dataGridViewTextBoxColumn7.MinimumWidth = 10;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Segundo Apellido";
            dataGridViewTextBoxColumn8.MinimumWidth = 10;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Fecha Nacimiento";
            dataGridViewTextBoxColumn9.MinimumWidth = 10;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Sexo";
            dataGridViewTextBoxColumn10.MinimumWidth = 10;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Estado Civil";
            dataGridViewTextBoxColumn11.MinimumWidth = 10;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 90;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Dirección";
            dataGridViewTextBoxColumn12.MinimumWidth = 10;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 160;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn13.MinimumWidth = 10;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.Width = 90;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Celular";
            dataGridViewTextBoxColumn14.MinimumWidth = 10;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 90;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Inicio Contrato";
            dataGridViewTextBoxColumn15.MinimumWidth = 10;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Width = 120;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Cierre Contrato";
            dataGridViewTextBoxColumn16.MinimumWidth = 10;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 120;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Salario Base";
            dataGridViewTextBoxColumn17.MinimumWidth = 10;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.Width = 120;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Estado";
            dataGridViewTextBoxColumn18.MinimumWidth = 10;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConceptoOtrosIngresos);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(txtMontoOtrasDeducciones);
            groupBox1.Controls.Add(label29);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(874, 72);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(124, 150);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "DEDUCIONES";
            // 
            // txtConceptoOtrosIngresos
            // 
            txtConceptoOtrosIngresos.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtConceptoOtrosIngresos.Location = new Point(20, 55);
            txtConceptoOtrosIngresos.Margin = new Padding(2, 1, 2, 1);
            txtConceptoOtrosIngresos.Name = "txtConceptoOtrosIngresos";
            txtConceptoOtrosIngresos.Size = new Size(84, 17);
            txtConceptoOtrosIngresos.TabIndex = 4;
            txtConceptoOtrosIngresos.KeyPress += txtConceptoOtrasDeducciones_KeyPress;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(40, 76);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(35, 10);
            label27.TabIndex = 3;
            label27.Text = "MONTO";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(31, 38);
            label28.Margin = new Padding(2, 0, 2, 0);
            label28.Name = "label28";
            label28.Size = new Size(50, 10);
            label28.TabIndex = 2;
            label28.Text = "CONCEPTO";
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
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(1, 19);
            label29.Margin = new Padding(2, 0, 2, 0);
            label29.Name = "label29";
            label29.Size = new Size(113, 10);
            label29.TabIndex = 0;
            label29.Text = "OTRAS DEDUCCIONES(O.D)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(txtMontoOtrosIngresos);
            groupBox2.Controls.Add(txtConceptoOtrasDeducciones);
            groupBox2.Controls.Add(txtHorasExtras);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label33);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(758, 72);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(101, 150);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "INGRESOS";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(28, 107);
            label30.Margin = new Padding(2, 0, 2, 0);
            label30.Name = "label30";
            label30.Size = new Size(35, 10);
            label30.TabIndex = 6;
            label30.Text = "MONTO";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(26, 72);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(50, 10);
            label31.TabIndex = 5;
            label31.Text = "CONCEPTO";
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
            // txtConceptoOtrasDeducciones
            // 
            txtConceptoOtrasDeducciones.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtConceptoOtrasDeducciones.Location = new Point(12, 83);
            txtConceptoOtrasDeducciones.Margin = new Padding(2, 1, 2, 1);
            txtConceptoOtrasDeducciones.Name = "txtConceptoOtrasDeducciones";
            txtConceptoOtrasDeducciones.Size = new Size(76, 17);
            txtConceptoOtrasDeducciones.TabIndex = 3;
            txtConceptoOtrasDeducciones.KeyPress += txtConceptoOtrosIngresos_KeyPress;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            txtHorasExtras.Location = new Point(12, 37);
            txtHorasExtras.Margin = new Padding(2, 1, 2, 1);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(76, 17);
            txtHorasExtras.TabIndex = 2;
            txtHorasExtras.KeyPress += txtHorasExtras_KeyPress;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(4, 57);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(92, 10);
            label32.TabIndex = 1;
            label32.Text = "OTROS INGRESOS(O.I)";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(10, 22);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(66, 10);
            label33.TabIndex = 0;
            label33.Text = "HORAS EXTRAS";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboEstadoEmpleado);
            groupBox3.Controls.Add(txtSalarioBase);
            groupBox3.Controls.Add(label34);
            groupBox3.Controls.Add(label35);
            groupBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(630, 72);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(117, 150);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "OTROS DATOS";
            // 
            // cboEstadoEmpleado
            // 
            cboEstadoEmpleado.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            cboEstadoEmpleado.FormattingEnabled = true;
            cboEstadoEmpleado.Location = new Point(15, 81);
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
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label34.Location = new Point(4, 63);
            label34.Margin = new Padding(2, 0, 2, 0);
            label34.Name = "label34";
            label34.Size = new Size(100, 10);
            label34.TabIndex = 1;
            label34.Text = "ESTADO DEL EMPLEADO";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label35.Location = new Point(15, 22);
            label35.Margin = new Padding(2, 0, 2, 0);
            label35.Name = "label35";
            label35.Size = new Size(62, 10);
            label35.TabIndex = 0;
            label35.Text = "SALARIO BASE";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(FechaCierreContrato);
            groupBox4.Controls.Add(FechaContratacion);
            groupBox4.Controls.Add(txtRuc);
            groupBox4.Controls.Add(txtInss);
            groupBox4.Controls.Add(txtNoEmpleado);
            groupBox4.Controls.Add(label36);
            groupBox4.Controls.Add(label37);
            groupBox4.Controls.Add(label38);
            groupBox4.Controls.Add(label39);
            groupBox4.Controls.Add(label40);
            groupBox4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(436, 72);
            groupBox4.Margin = new Padding(2, 1, 2, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 1, 2, 1);
            groupBox4.Size = new Size(184, 150);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "DATOS LABORALES";
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
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label36.Location = new Point(-2, 116);
            label36.Margin = new Padding(2, 0, 2, 0);
            label36.Name = "label36";
            label36.Size = new Size(123, 10);
            label36.TabIndex = 4;
            label36.Text = "FECHA CIERRE DE CONTRATO";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label37.Location = new Point(-2, 80);
            label37.Margin = new Padding(2, 0, 2, 0);
            label37.Name = "label37";
            label37.Size = new Size(109, 10);
            label37.TabIndex = 3;
            label37.Text = "FECHA DE CONTRATACIÓN";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label38.Location = new Point(-2, 61);
            label38.Margin = new Padding(2, 0, 2, 0);
            label38.Name = "label38";
            label38.Size = new Size(36, 10);
            label38.TabIndex = 2;
            label38.Text = "No.RUC";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label39.Location = new Point(-2, 41);
            label39.Margin = new Padding(2, 0, 2, 0);
            label39.Name = "label39";
            label39.Size = new Size(36, 10);
            label39.TabIndex = 1;
            label39.Text = "No.INSS";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(-2, 22);
            label40.Margin = new Padding(2, 0, 2, 0);
            label40.Name = "label40";
            label40.Size = new Size(62, 10);
            label40.TabIndex = 0;
            label40.Text = "No.EMPLEADO";
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
            groupBox5.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(238, 72);
            groupBox5.Margin = new Padding(2, 1, 2, 1);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2, 1, 2, 1);
            groupBox5.Size = new Size(184, 150);
            groupBox5.TabIndex = 30;
            groupBox5.TabStop = false;
            groupBox5.Text = "OTROS DATOS PERSONALES";
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
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label41.Location = new Point(-2, 116);
            label41.Margin = new Padding(2, 0, 2, 0);
            label41.Name = "label41";
            label41.Size = new Size(84, 10);
            label41.TabIndex = 10;
            label41.Text = "FECHA NACIMIENTO";
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
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label42.Location = new Point(-2, 97);
            label42.Margin = new Padding(2, 0, 2, 0);
            label42.Name = "label42";
            label42.Size = new Size(43, 10);
            label42.TabIndex = 4;
            label42.Text = "CELULAR";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label43.Location = new Point(-2, 78);
            label43.Margin = new Padding(2, 0, 2, 0);
            label43.Name = "label43";
            label43.Size = new Size(48, 10);
            label43.TabIndex = 3;
            label43.Text = "TELEFONO";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label44.Location = new Point(-2, 61);
            label44.Margin = new Padding(2, 0, 2, 0);
            label44.Name = "label44";
            label44.Size = new Size(50, 10);
            label44.TabIndex = 2;
            label44.Text = "DIRECCION";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label45.Location = new Point(-2, 41);
            label45.Margin = new Padding(2, 0, 2, 0);
            label45.Name = "label45";
            label45.Size = new Size(58, 10);
            label45.TabIndex = 1;
            label45.Text = "ESTADO CIVIL";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label46.Location = new Point(-2, 22);
            label46.Margin = new Padding(2, 0, 2, 0);
            label46.Name = "label46";
            label46.Size = new Size(26, 10);
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
            groupBox6.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(34, 72);
            groupBox6.Margin = new Padding(2, 1, 2, 1);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2, 1, 2, 1);
            groupBox6.Size = new Size(194, 150);
            groupBox6.TabIndex = 29;
            groupBox6.TabStop = false;
            groupBox6.Text = "DATOS DE IDENTIDAD";
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
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label47.Location = new Point(1, 97);
            label47.Margin = new Padding(2, 0, 2, 0);
            label47.Name = "label47";
            label47.Size = new Size(51, 10);
            label47.TabIndex = 22;
            label47.Text = "No.CEDULA";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label48.Location = new Point(1, 78);
            label48.Margin = new Padding(2, 0, 2, 0);
            label48.Name = "label48";
            label48.Size = new Size(86, 10);
            label48.TabIndex = 21;
            label48.Text = "SEGUNDO APELLIDO";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label49.Location = new Point(1, 59);
            label49.Margin = new Padding(2, 0, 2, 0);
            label49.Name = "label49";
            label49.Size = new Size(77, 10);
            label49.TabIndex = 20;
            label49.Text = "PRIMER APELLIDO";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label50.Location = new Point(1, 39);
            label50.Margin = new Padding(2, 0, 2, 0);
            label50.Name = "label50";
            label50.Size = new Size(83, 10);
            label50.TabIndex = 19;
            label50.Text = "SEGUNDO NOMBRE";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Arial", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label51.Location = new Point(1, 20);
            label51.Margin = new Padding(2, 0, 2, 0);
            label51.Name = "label51";
            label51.Size = new Size(74, 10);
            label51.TabIndex = 18;
            label51.Text = "PRIMER NOMBRE";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Arial Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label52.Location = new Point(36, 20);
            label52.Margin = new Padding(2, 0, 2, 0);
            label52.Name = "label52";
            label52.Size = new Size(256, 27);
            label52.TabIndex = 28;
            label52.Text = "DATOS DEL EMPLEADO";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Image = Properties.Resources.A_adirporfa;
            BtnAgregar.Location = new Point(1016, 111);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(54, 31);
            BtnAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnAgregar.TabIndex = 42;
            BtnAgregar.TabStop = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnExportar
            // 
            BtnExportar.Image = Properties.Resources.archivo_excel;
            BtnExportar.Location = new Point(1016, 152);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(54, 34);
            BtnExportar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnExportar.TabIndex = 43;
            BtnExportar.TabStop = false;
            BtnExportar.Click += BtnExportar_Click_1;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1229, 583);
            Controls.Add(BtnExportar);
            Controls.Add(BtnAgregar);
            Controls.Add(dgvDatosEmpleado);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(label52);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosEmpleado).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnExportar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDatosEmpleado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private GroupBox groupBox1;
        private TextBox txtConceptoOtrosIngresos;
        private Label label27;
        private Label label28;
        private TextBox txtMontoOtrasDeducciones;
        private Label label29;
        private GroupBox groupBox2;
        private Label label30;
        private Label label31;
        private TextBox txtMontoOtrosIngresos;
        private TextBox txtConceptoOtrasDeducciones;
        private TextBox txtHorasExtras;
        private Label label32;
        private Label label33;
        private GroupBox groupBox3;
        private ComboBox cboEstadoEmpleado;
        private TextBox txtSalarioBase;
        private Label label34;
        private Label label35;
        private GroupBox groupBox4;
        private DateTimePicker FechaCierreContrato;
        private DateTimePicker FechaContratacion;
        private TextBox txtRuc;
        private TextBox txtInss;
        private TextBox txtNoEmpleado;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
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
        private PictureBox BtnExportar;
    }
}