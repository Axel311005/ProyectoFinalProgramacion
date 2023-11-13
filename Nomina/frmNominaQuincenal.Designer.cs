namespace Nomina
{
    partial class frmNominaQuincenal
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnExportar = new Button();
            dgvNominaQ = new DataGridView();
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            BtnExportarNomM = new Button();
            dgvNomina = new DataGridView();
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
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNominaQ).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(518, 281);
            btnExportar.Margin = new Padding(2, 1, 2, 1);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(155, 22);
            btnExportar.TabIndex = 16;
            btnExportar.Text = "Exportar Nomina a Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dgvNominaQ
            // 
            dgvNominaQ.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvNominaQ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvNominaQ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNominaQ.Columns.AddRange(new DataGridViewColumn[] { NoEmpleado2, PNombre2, sNombre2, pApellido2, SApellido2, SalarioBase2, Antiguedad, RiesgoLaboral, Nocturnidad, ConceptoOI, MontoOI, HorasExtras, TotalIngresos, Inss, IR, ConceptoOD, MontoOD, Deducciones2, SalarioNeto });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvNominaQ.DefaultCellStyle = dataGridViewCellStyle6;
            dgvNominaQ.Location = new Point(20, 37);
            dgvNominaQ.Margin = new Padding(2, 1, 2, 1);
            dgvNominaQ.Name = "dgvNominaQ";
            dgvNominaQ.RowHeadersWidth = 82;
            dgvNominaQ.RowTemplate.Height = 41;
            dgvNominaQ.Size = new Size(1072, 217);
            dgvNominaQ.TabIndex = 17;
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
            // 
            // Antiguedad
            // 
            Antiguedad.HeaderText = "Antiguedad";
            Antiguedad.MinimumWidth = 10;
            Antiguedad.Name = "Antiguedad";
            Antiguedad.Width = 90;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1114, 387);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvNominaQ);
            tabPage1.Controls.Add(btnExportar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1106, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnExportarNomM);
            tabPage2.Controls.Add(dgvNomina);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1106, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnExportarNomM
            // 
            BtnExportarNomM.Location = new Point(470, 320);
            BtnExportarNomM.Margin = new Padding(2, 1, 2, 1);
            BtnExportarNomM.Name = "BtnExportarNomM";
            BtnExportarNomM.Size = new Size(155, 22);
            BtnExportarNomM.TabIndex = 17;
            BtnExportarNomM.Text = "Exportar Nomina a Excel";
            BtnExportarNomM.UseVisualStyleBackColor = true;
            BtnExportarNomM.Click += BtnExportarNomM_Click;
            // 
            // dgvNomina
            // 
            dgvNomina.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNomina.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Arial", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvNomina.DefaultCellStyle = dataGridViewCellStyle8;
            dgvNomina.Location = new Point(5, 38);
            dgvNomina.Margin = new Padding(2, 1, 2, 1);
            dgvNomina.Name = "dgvNomina";
            dgvNomina.RowHeadersWidth = 82;
            dgvNomina.RowTemplate.Height = 41;
            dgvNomina.Size = new Size(1102, 259);
            dgvNomina.TabIndex = 15;
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
            dataGridViewTextBoxColumn2.HeaderText = "Primer Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Segundo Nombre";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Primer Apellido";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Segundo Apellido";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Salario Base";
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Antiguedad";
            dataGridViewTextBoxColumn7.MinimumWidth = 10;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Riesgo Laboral";
            dataGridViewTextBoxColumn8.MinimumWidth = 10;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Nocturnidad";
            dataGridViewTextBoxColumn9.MinimumWidth = 10;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Concepto O.I";
            dataGridViewTextBoxColumn10.MinimumWidth = 10;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 110;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Monto O.I";
            dataGridViewTextBoxColumn11.MinimumWidth = 10;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Horas Extras";
            dataGridViewTextBoxColumn12.MinimumWidth = 10;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Total Ingresos";
            dataGridViewTextBoxColumn13.MinimumWidth = 10;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Inss";
            dataGridViewTextBoxColumn14.MinimumWidth = 10;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 90;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "IR";
            dataGridViewTextBoxColumn15.MinimumWidth = 10;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Concepto O.D";
            dataGridViewTextBoxColumn16.MinimumWidth = 10;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 110;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Monto O.D";
            dataGridViewTextBoxColumn17.MinimumWidth = 10;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Total Deducciones";
            dataGridViewTextBoxColumn18.MinimumWidth = 10;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.Width = 90;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "Salario Neto";
            dataGridViewTextBoxColumn19.MinimumWidth = 10;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.Width = 110;
            // 
            // frmNominaQuincenal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1138, 402);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmNominaQuincenal";
            Text = "frmNominaQuincenal";
            Load += frmNominaQuincenal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNominaQ).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnExportar;
        private DataGridView dgvNominaQ;
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvNomina;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private Button BtnExportarNomM;
    }
}