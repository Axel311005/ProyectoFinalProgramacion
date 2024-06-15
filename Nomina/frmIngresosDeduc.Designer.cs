namespace Nomina
{
    partial class frmIngresosDeduc
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
            BtnExportarM = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label30 = new Label();
            label31 = new Label();
            txtMontoOtrosIngresos = new TextBox();
            txtConceptoOtrosIngresos = new TextBox();
            txtHorasExtras = new TextBox();
            label32 = new Label();
            label33 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            btnAgregarI = new Button();
            btnActualizarI = new Button();
            btnEliminarI = new Button();
            dgvIngresos = new DataGridView();
            btnAgregarD = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtConcepto = new TextBox();
            txtMonto = new TextBox();
            txtNumeroEmpleado = new TextBox();
            label6 = new Label();
            btnActualizarD = new Button();
            btnEliminarD = new Button();
            dgvDeducciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)BtnExportarM).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).BeginInit();
            SuspendLayout();
            // 
            // BtnExportarM
            // 
            BtnExportarM.Image = Properties.Resources.archivo_excel;
            BtnExportarM.Location = new Point(23, 495);
            BtnExportarM.Margin = new Padding(4);
            BtnExportarM.Name = "BtnExportarM";
            BtnExportarM.Size = new Size(62, 46);
            BtnExportarM.SizeMode = PictureBoxSizeMode.Zoom;
            BtnExportarM.TabIndex = 47;
            BtnExportarM.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1147, 479);
            tabControl1.TabIndex = 48;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.Controls.Add(dgvIngresos);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1139, 443);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingresos";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.CornflowerBlue;
            tabPage2.Controls.Add(dgvDeducciones);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1139, 443);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Deducciones";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarI);
            groupBox2.Controls.Add(btnActualizarI);
            groupBox2.Controls.Add(btnAgregarI);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(txtMontoOtrosIngresos);
            groupBox2.Controls.Add(txtConceptoOtrosIngresos);
            groupBox2.Controls.Add(txtHorasExtras);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label33);
            groupBox2.Font = new Font("Arial", 9F);
            groupBox2.Location = new Point(7, 4);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(1106, 161);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "INGRESOS";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 6F, FontStyle.Bold);
            label30.Location = new Point(388, 19);
            label30.Margin = new Padding(2, 0, 2, 0);
            label30.Name = "label30";
            label30.Size = new Size(42, 12);
            label30.TabIndex = 6;
            label30.Text = "MONTO";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 6F, FontStyle.Bold);
            label31.Location = new Point(263, 19);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(61, 12);
            label31.TabIndex = 5;
            label31.Text = "CONCEPTO";
            // 
            // txtMontoOtrosIngresos
            // 
            txtMontoOtrosIngresos.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtMontoOtrosIngresos.Location = new Point(365, 37);
            txtMontoOtrosIngresos.Margin = new Padding(2, 1, 2, 1);
            txtMontoOtrosIngresos.Name = "txtMontoOtrosIngresos";
            txtMontoOtrosIngresos.Size = new Size(86, 19);
            txtMontoOtrosIngresos.TabIndex = 4;
            // 
            // txtConceptoOtrosIngresos
            // 
            txtConceptoOtrosIngresos.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtConceptoOtrosIngresos.Location = new Point(253, 37);
            txtConceptoOtrosIngresos.Margin = new Padding(2, 1, 2, 1);
            txtConceptoOtrosIngresos.Name = "txtConceptoOtrosIngresos";
            txtConceptoOtrosIngresos.Size = new Size(86, 19);
            txtConceptoOtrosIngresos.TabIndex = 3;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Font = new Font("Arial", 6F, FontStyle.Bold);
            txtHorasExtras.Location = new Point(14, 49);
            txtHorasExtras.Margin = new Padding(2, 1, 2, 1);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(86, 19);
            txtHorasExtras.TabIndex = 2;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial", 6F, FontStyle.Bold);
            label32.Location = new Point(122, 40);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(117, 12);
            label32.TabIndex = 1;
            label32.Text = "OTROS INGRESOS(O.I)";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial", 6F, FontStyle.Bold);
            label33.Location = new Point(14, 21);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(84, 12);
            label33.TabIndex = 0;
            label33.Text = "HORAS EXTRAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 6F, FontStyle.Bold);
            label1.Location = new Point(471, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 12);
            label1.TabIndex = 7;
            label1.Text = "NUMERO DE EMPLEADO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(492, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 25);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(632, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 25);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 6F, FontStyle.Bold);
            label2.Location = new Point(611, 21);
            label2.Name = "label2";
            label2.Size = new Size(110, 12);
            label2.TabIndex = 9;
            label2.Text = "SALARIO ORDINARIO";
            // 
            // btnAgregarI
            // 
            btnAgregarI.Location = new Point(77, 108);
            btnAgregarI.Name = "btnAgregarI";
            btnAgregarI.Size = new Size(94, 29);
            btnAgregarI.TabIndex = 11;
            btnAgregarI.Text = "Agregar";
            btnAgregarI.UseVisualStyleBackColor = true;
            // 
            // btnActualizarI
            // 
            btnActualizarI.Location = new Point(314, 108);
            btnActualizarI.Name = "btnActualizarI";
            btnActualizarI.Size = new Size(94, 29);
            btnActualizarI.TabIndex = 12;
            btnActualizarI.Text = "Actualizar";
            btnActualizarI.UseVisualStyleBackColor = true;
            // 
            // btnEliminarI
            // 
            btnEliminarI.Location = new Point(601, 108);
            btnEliminarI.Name = "btnEliminarI";
            btnEliminarI.Size = new Size(94, 29);
            btnEliminarI.TabIndex = 13;
            btnEliminarI.Text = "Eliminar";
            btnEliminarI.UseVisualStyleBackColor = true;
            // 
            // dgvIngresos
            // 
            dgvIngresos.BackgroundColor = SystemColors.Control;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(21, 193);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.Size = new Size(1092, 233);
            dgvIngresos.TabIndex = 38;
            // 
            // btnAgregarD
            // 
            btnAgregarD.Location = new Point(514, 73);
            btnAgregarD.Name = "btnAgregarD";
            btnAgregarD.Size = new Size(94, 29);
            btnAgregarD.TabIndex = 0;
            btnAgregarD.Text = "AGREGAR";
            btnAgregarD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminarD);
            groupBox1.Controls.Add(btnActualizarD);
            groupBox1.Controls.Add(txtNumeroEmpleado);
            groupBox1.Controls.Add(btnAgregarD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtConcepto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1126, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deducciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 6F, FontStyle.Bold);
            label3.Location = new Point(43, 30);
            label3.Name = "label3";
            label3.Size = new Size(140, 12);
            label3.TabIndex = 0;
            label3.Text = "OTRAS DEDUCCIONES(O.D)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 6F, FontStyle.Bold);
            label4.Location = new Point(23, 60);
            label4.Name = "label4";
            label4.Size = new Size(61, 12);
            label4.TabIndex = 1;
            label4.Text = "CONCEPTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 6F, FontStyle.Bold);
            label5.Location = new Point(168, 60);
            label5.Name = "label5";
            label5.Size = new Size(42, 12);
            label5.TabIndex = 2;
            label5.Text = "MONTO";
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(6, 75);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(114, 27);
            txtConcepto.TabIndex = 3;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(149, 75);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(114, 27);
            txtMonto.TabIndex = 4;
            // 
            // txtNumeroEmpleado
            // 
            txtNumeroEmpleado.Location = new Point(320, 75);
            txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            txtNumeroEmpleado.Size = new Size(114, 27);
            txtNumeroEmpleado.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 6F, FontStyle.Bold);
            label6.Location = new Point(320, 60);
            label6.Name = "label6";
            label6.Size = new Size(111, 12);
            label6.TabIndex = 5;
            label6.Text = "NUMERO EMPLEADO";
            // 
            // btnActualizarD
            // 
            btnActualizarD.Location = new Point(628, 74);
            btnActualizarD.Name = "btnActualizarD";
            btnActualizarD.Size = new Size(110, 29);
            btnActualizarD.TabIndex = 7;
            btnActualizarD.Text = "ACTUALIZAR";
            btnActualizarD.UseVisualStyleBackColor = true;
            // 
            // btnEliminarD
            // 
            btnEliminarD.Location = new Point(758, 75);
            btnEliminarD.Name = "btnEliminarD";
            btnEliminarD.Size = new Size(94, 29);
            btnEliminarD.TabIndex = 8;
            btnEliminarD.Text = "ELIMINAR";
            btnEliminarD.UseVisualStyleBackColor = true;
            // 
            // dgvDeducciones
            // 
            dgvDeducciones.BackgroundColor = SystemColors.Control;
            dgvDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeducciones.Location = new Point(13, 204);
            dgvDeducciones.Name = "dgvDeducciones";
            dgvDeducciones.RowHeadersWidth = 51;
            dgvDeducciones.Size = new Size(1109, 218);
            dgvDeducciones.TabIndex = 2;
            // 
            // frmIngresosDeduc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1171, 554);
            Controls.Add(tabControl1);
            Controls.Add(BtnExportarM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIngresosDeduc";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)BtnExportarM).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BtnExportarM;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label30;
        private Label label31;
        private TextBox txtMontoOtrosIngresos;
        private TextBox txtConceptoOtrosIngresos;
        private TextBox txtHorasExtras;
        private Label label32;
        private Label label33;
        private Button btnAgregarI;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button btnEliminarI;
        private Button btnActualizarI;
        private DataGridView dgvIngresos;
        private GroupBox groupBox1;
        private Button btnAgregarD;
        private Label label3;
        private TextBox txtMonto;
        private TextBox txtConcepto;
        private Label label5;
        private Label label4;
        private TextBox txtNumeroEmpleado;
        private Label label6;
        private Button btnEliminarD;
        private Button btnActualizarD;
        private DataGridView dgvDeducciones;
    }
}