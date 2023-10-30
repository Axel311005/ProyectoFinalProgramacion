namespace Nomina
{
    partial class frmNominaMensual
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvNomina = new DataGridView();
            btnExportar = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            SuspendLayout();
            // 
            // dgvNomina
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dgvNomina.Location = new Point(12, 207);
            dgvNomina.Name = "dgvNomina";
            dgvNomina.RowHeadersWidth = 82;
            dgvNomina.RowTemplate.Height = 41;
            dgvNomina.Size = new Size(2058, 321);
            dgvNomina.TabIndex = 14;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(782, 591);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(316, 46);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar Nomina a Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // NoEmpleado2
            // 
            NoEmpleado2.HeaderText = "Numero Empleado";
            NoEmpleado2.MinimumWidth = 10;
            NoEmpleado2.Name = "NoEmpleado2";
            NoEmpleado2.Width = 110;
            // 
            // PNombre2
            // 
            PNombre2.HeaderText = "Primer Nombre";
            PNombre2.MinimumWidth = 10;
            PNombre2.Name = "PNombre2";
            PNombre2.Width = 110;
            // 
            // sNombre2
            // 
            sNombre2.HeaderText = "Segundo Nombre";
            sNombre2.MinimumWidth = 10;
            sNombre2.Name = "sNombre2";
            sNombre2.Width = 110;
            // 
            // pApellido2
            // 
            pApellido2.HeaderText = "Primer Apellido";
            pApellido2.MinimumWidth = 10;
            pApellido2.Name = "pApellido2";
            pApellido2.Width = 110;
            // 
            // SApellido2
            // 
            SApellido2.HeaderText = "Segundo Apellido";
            SApellido2.MinimumWidth = 10;
            SApellido2.Name = "SApellido2";
            SApellido2.Width = 110;
            // 
            // SalarioBase2
            // 
            SalarioBase2.HeaderText = "Salario Base";
            SalarioBase2.MinimumWidth = 10;
            SalarioBase2.Name = "SalarioBase2";
            SalarioBase2.Width = 110;
            // 
            // Antiguedad
            // 
            Antiguedad.HeaderText = "Antiguedad";
            Antiguedad.MinimumWidth = 10;
            Antiguedad.Name = "Antiguedad";
            // 
            // RiesgoLaboral
            // 
            RiesgoLaboral.HeaderText = "Riesgo Laboral";
            RiesgoLaboral.MinimumWidth = 10;
            RiesgoLaboral.Name = "RiesgoLaboral";
            // 
            // Nocturnidad
            // 
            Nocturnidad.HeaderText = "Nocturnidad";
            Nocturnidad.MinimumWidth = 10;
            Nocturnidad.Name = "Nocturnidad";
            // 
            // ConceptoOI
            // 
            ConceptoOI.HeaderText = "Concepto O.I";
            ConceptoOI.MinimumWidth = 10;
            ConceptoOI.Name = "ConceptoOI";
            ConceptoOI.Width = 110;
            // 
            // MontoOI
            // 
            MontoOI.HeaderText = "Monto O.I";
            MontoOI.MinimumWidth = 10;
            MontoOI.Name = "MontoOI";
            // 
            // HorasExtras
            // 
            HorasExtras.HeaderText = "Horas Extras";
            HorasExtras.MinimumWidth = 10;
            HorasExtras.Name = "HorasExtras";
            // 
            // TotalIngresos
            // 
            TotalIngresos.HeaderText = "Total Ingresos";
            TotalIngresos.MinimumWidth = 10;
            TotalIngresos.Name = "TotalIngresos";
            // 
            // Inss
            // 
            Inss.HeaderText = "Inss";
            Inss.MinimumWidth = 10;
            Inss.Name = "Inss";
            Inss.Width = 90;
            // 
            // IR
            // 
            IR.HeaderText = "IR";
            IR.MinimumWidth = 10;
            IR.Name = "IR";
            // 
            // ConceptoOD
            // 
            ConceptoOD.HeaderText = "Concepto O.D";
            ConceptoOD.MinimumWidth = 10;
            ConceptoOD.Name = "ConceptoOD";
            ConceptoOD.Width = 110;
            // 
            // MontoOD
            // 
            MontoOD.HeaderText = "Monto O.D";
            MontoOD.MinimumWidth = 10;
            MontoOD.Name = "MontoOD";
            // 
            // Deducciones2
            // 
            Deducciones2.HeaderText = "Total Deducciones";
            Deducciones2.MinimumWidth = 10;
            Deducciones2.Name = "Deducciones2";
            Deducciones2.Width = 90;
            // 
            // SalarioNeto
            // 
            SalarioNeto.HeaderText = "Salario Neto";
            SalarioNeto.MinimumWidth = 10;
            SalarioNeto.Name = "SalarioNeto";
            SalarioNeto.Width = 110;
            // 
            // frmNominaMensual
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2113, 807);
            Controls.Add(btnExportar);
            Controls.Add(dgvNomina);
            Name = "frmNominaMensual";
            Text = "frmNominaMensual";
            Load += frmNominaMensual_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNomina;
        private Button btnExportar;
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
    }
}