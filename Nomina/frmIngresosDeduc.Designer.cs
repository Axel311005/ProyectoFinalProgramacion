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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvIngresos = new DataGridView();
            groupBox2 = new GroupBox();
            btnExport = new PictureBox();
            btnEliminarIng = new Button();
            btnActualizarIng = new Button();
            btnAgregarIng = new Button();
            txtSalarioOrdinario = new TextBox();
            label2 = new Label();
            txtNumeroEmpleadoIng = new TextBox();
            label1 = new Label();
            label30 = new Label();
            label31 = new Label();
            txtMontoOtrosIngresos = new TextBox();
            txtConceptoOtrosIngresos = new TextBox();
            txtHorasExtras = new TextBox();
            label32 = new Label();
            label33 = new Label();
            tabPage2 = new TabPage();
            dgvDeducciones = new DataGridView();
            groupBox1 = new GroupBox();
            btnExportarExcel = new PictureBox();
            btnEliminarD = new Button();
            btnActualizarDeduc = new Button();
            txtNumeroEmpleadoDeduc = new TextBox();
            btnAgregarDeduc = new Button();
            label6 = new Label();
            txtMontoOtrasDeducciones = new TextBox();
            txtConceptoOtrasDeducciones = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExport).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExportarExcel).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 0);
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
            tabPage1.Font = new Font("Cascadia Mono", 9.75F);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1139, 443);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingresos";
            // 
            // dgvIngresos
            // 
            dgvIngresos.BackgroundColor = SystemColors.Control;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvIngresos.DefaultCellStyle = dataGridViewCellStyle1;
            dgvIngresos.Location = new Point(21, 193);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.ReadOnly = true;
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngresos.Size = new Size(1093, 233);
            dgvIngresos.TabIndex = 38;
            dgvIngresos.CellClick += dgvIngresos_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExport);
            groupBox2.Controls.Add(btnEliminarIng);
            groupBox2.Controls.Add(btnActualizarIng);
            groupBox2.Controls.Add(btnAgregarIng);
            groupBox2.Controls.Add(txtSalarioOrdinario);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNumeroEmpleadoIng);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(txtMontoOtrosIngresos);
            groupBox2.Controls.Add(txtConceptoOtrosIngresos);
            groupBox2.Controls.Add(txtHorasExtras);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label33);
            groupBox2.Font = new Font("Cascadia Mono", 9.75F);
            groupBox2.Location = new Point(7, 4);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(1106, 161);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "INGRESOS";
            // 
            // btnExport
            // 
            btnExport.Image = Properties.Resources.archivo_excel;
            btnExport.Location = new Point(1006, 84);
            btnExport.Margin = new Padding(5, 4, 5, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(62, 45);
            btnExport.SizeMode = PictureBoxSizeMode.Zoom;
            btnExport.TabIndex = 48;
            btnExport.TabStop = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnEliminarIng
            // 
            btnEliminarIng.FlatAppearance.BorderSize = 0;
            btnEliminarIng.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnEliminarIng.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEliminarIng.FlatStyle = FlatStyle.Flat;
            btnEliminarIng.Font = new Font("Cascadia Mono", 9F);
            btnEliminarIng.Location = new Point(231, 104);
            btnEliminarIng.Name = "btnEliminarIng";
            btnEliminarIng.Size = new Size(94, 47);
            btnEliminarIng.TabIndex = 13;
            btnEliminarIng.Text = "Eliminar";
            btnEliminarIng.UseVisualStyleBackColor = true;
            btnEliminarIng.Click += btnEliminarIng_Click;
            // 
            // btnActualizarIng
            // 
            btnActualizarIng.FlatAppearance.BorderSize = 0;
            btnActualizarIng.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnActualizarIng.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnActualizarIng.FlatStyle = FlatStyle.Flat;
            btnActualizarIng.Font = new Font("Cascadia Mono", 9F);
            btnActualizarIng.Location = new Point(111, 104);
            btnActualizarIng.Name = "btnActualizarIng";
            btnActualizarIng.Size = new Size(113, 47);
            btnActualizarIng.TabIndex = 12;
            btnActualizarIng.Text = "Actualizar";
            btnActualizarIng.UseVisualStyleBackColor = true;
            btnActualizarIng.Click += btnActualizarIng_Click;
            // 
            // btnAgregarIng
            // 
            btnAgregarIng.FlatAppearance.BorderSize = 0;
            btnAgregarIng.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAgregarIng.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAgregarIng.FlatStyle = FlatStyle.Flat;
            btnAgregarIng.Font = new Font("Cascadia Mono", 9F);
            btnAgregarIng.Location = new Point(10, 104);
            btnAgregarIng.Name = "btnAgregarIng";
            btnAgregarIng.Size = new Size(94, 40);
            btnAgregarIng.TabIndex = 11;
            btnAgregarIng.Text = "Agregar";
            btnAgregarIng.UseVisualStyleBackColor = true;
            btnAgregarIng.Click += btnAgregarIng_Click;
            // 
            // txtSalarioOrdinario
            // 
            txtSalarioOrdinario.Location = new Point(231, 72);
            txtSalarioOrdinario.Name = "txtSalarioOrdinario";
            txtSalarioOrdinario.Size = new Size(164, 26);
            txtSalarioOrdinario.TabIndex = 10;
            txtSalarioOrdinario.KeyPress += txtSalarioOrdinario_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 9.75F);
            label2.Location = new Point(231, 43);
            label2.Name = "label2";
            label2.Size = new Size(180, 22);
            label2.TabIndex = 9;
            label2.Text = "SALARIO ORDINARIO";
            // 
            // txtNumeroEmpleadoIng
            // 
            txtNumeroEmpleadoIng.Location = new Point(14, 68);
            txtNumeroEmpleadoIng.Name = "txtNumeroEmpleadoIng";
            txtNumeroEmpleadoIng.Size = new Size(173, 26);
            txtNumeroEmpleadoIng.TabIndex = 8;
            txtNumeroEmpleadoIng.KeyPress += txtNumeroEmpleadoIng_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 9.75F);
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 7;
            label1.Text = "NUMERO DE EMPLEADO";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Cascadia Mono", 9.75F);
            label30.Location = new Point(674, 42);
            label30.Margin = new Padding(2, 0, 2, 0);
            label30.Name = "label30";
            label30.Size = new Size(60, 22);
            label30.TabIndex = 6;
            label30.Text = "MONTO";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Cascadia Mono", 9.75F);
            label31.Location = new Point(508, 43);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(90, 22);
            label31.TabIndex = 5;
            label31.Text = "CONCEPTO";
            // 
            // txtMontoOtrosIngresos
            // 
            txtMontoOtrosIngresos.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMontoOtrosIngresos.Location = new Point(674, 72);
            txtMontoOtrosIngresos.Margin = new Padding(2, 1, 2, 1);
            txtMontoOtrosIngresos.Multiline = true;
            txtMontoOtrosIngresos.Name = "txtMontoOtrosIngresos";
            txtMontoOtrosIngresos.Size = new Size(54, 27);
            txtMontoOtrosIngresos.TabIndex = 4;
            txtMontoOtrosIngresos.KeyPress += txtMontoOtrosIngresos_KeyPress;
            // 
            // txtConceptoOtrosIngresos
            // 
            txtConceptoOtrosIngresos.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConceptoOtrosIngresos.Location = new Point(499, 72);
            txtConceptoOtrosIngresos.Margin = new Padding(2, 1, 2, 1);
            txtConceptoOtrosIngresos.Multiline = true;
            txtConceptoOtrosIngresos.Name = "txtConceptoOtrosIngresos";
            txtConceptoOtrosIngresos.Size = new Size(110, 27);
            txtConceptoOtrosIngresos.TabIndex = 3;
            txtConceptoOtrosIngresos.KeyPress += txtConceptoOtrosIngresos_KeyPress;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHorasExtras.Location = new Point(823, 72);
            txtHorasExtras.Margin = new Padding(2, 1, 2, 1);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(81, 27);
            txtHorasExtras.TabIndex = 2;
            txtHorasExtras.KeyPress += txtHorasExtras_KeyPress;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Cascadia Mono", 9.75F);
            label32.Location = new Point(622, 10);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(200, 22);
            label32.TabIndex = 1;
            label32.Text = "OTROS INGRESOS(O.I)";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Cascadia Mono", 9.75F);
            label33.Location = new Point(799, 42);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(130, 22);
            label33.TabIndex = 0;
            label33.Text = "HORAS EXTRAS";
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
            // dgvDeducciones
            // 
            dgvDeducciones.BackgroundColor = SystemColors.Control;
            dgvDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDeducciones.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDeducciones.Location = new Point(13, 204);
            dgvDeducciones.Name = "dgvDeducciones";
            dgvDeducciones.ReadOnly = true;
            dgvDeducciones.RowHeadersWidth = 51;
            dgvDeducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeducciones.Size = new Size(1109, 219);
            dgvDeducciones.TabIndex = 2;
            dgvDeducciones.CellClick += dgvDeducciones_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportarExcel);
            groupBox1.Controls.Add(btnEliminarD);
            groupBox1.Controls.Add(btnActualizarDeduc);
            groupBox1.Controls.Add(txtNumeroEmpleadoDeduc);
            groupBox1.Controls.Add(btnAgregarDeduc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMontoOtrasDeducciones);
            groupBox1.Controls.Add(txtConceptoOtrasDeducciones);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Cascadia Mono", 9.75F);
            groupBox1.Location = new Point(7, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1126, 181);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deducciones";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Image = Properties.Resources.archivo_excel;
            btnExportarExcel.Location = new Point(896, 73);
            btnExportarExcel.Margin = new Padding(5, 4, 5, 4);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(62, 45);
            btnExportarExcel.SizeMode = PictureBoxSizeMode.Zoom;
            btnExportarExcel.TabIndex = 48;
            btnExportarExcel.TabStop = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // btnEliminarD
            // 
            btnEliminarD.FlatAppearance.BorderSize = 0;
            btnEliminarD.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnEliminarD.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEliminarD.FlatStyle = FlatStyle.Flat;
            btnEliminarD.Font = new Font("Cascadia Mono", 9.75F);
            btnEliminarD.Location = new Point(758, 75);
            btnEliminarD.Name = "btnEliminarD";
            btnEliminarD.Size = new Size(112, 29);
            btnEliminarD.TabIndex = 8;
            btnEliminarD.Text = "ELIMINAR";
            btnEliminarD.UseVisualStyleBackColor = true;
            btnEliminarD.Click += btnEliminarD_Click;
            // 
            // btnActualizarDeduc
            // 
            btnActualizarDeduc.FlatAppearance.BorderSize = 0;
            btnActualizarDeduc.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnActualizarDeduc.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnActualizarDeduc.FlatStyle = FlatStyle.Flat;
            btnActualizarDeduc.Font = new Font("Cascadia Mono", 9.75F);
            btnActualizarDeduc.Location = new Point(629, 75);
            btnActualizarDeduc.Name = "btnActualizarDeduc";
            btnActualizarDeduc.Size = new Size(123, 29);
            btnActualizarDeduc.TabIndex = 7;
            btnActualizarDeduc.Text = "ACTUALIZAR";
            btnActualizarDeduc.UseVisualStyleBackColor = true;
            btnActualizarDeduc.Click += btnActualizarDeduc_Click;
            // 
            // txtNumeroEmpleadoDeduc
            // 
            txtNumeroEmpleadoDeduc.Location = new Point(6, 91);
            txtNumeroEmpleadoDeduc.Name = "txtNumeroEmpleadoDeduc";
            txtNumeroEmpleadoDeduc.Size = new Size(141, 26);
            txtNumeroEmpleadoDeduc.TabIndex = 6;
            txtNumeroEmpleadoDeduc.KeyPress += txtNumeroEmpleadoDeduc_KeyPress;
            // 
            // btnAgregarDeduc
            // 
            btnAgregarDeduc.FlatAppearance.BorderSize = 0;
            btnAgregarDeduc.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAgregarDeduc.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAgregarDeduc.FlatStyle = FlatStyle.Flat;
            btnAgregarDeduc.Font = new Font("Cascadia Mono", 9.75F);
            btnAgregarDeduc.Location = new Point(514, 73);
            btnAgregarDeduc.Name = "btnAgregarDeduc";
            btnAgregarDeduc.Size = new Size(94, 29);
            btnAgregarDeduc.TabIndex = 0;
            btnAgregarDeduc.Text = "AGREGAR";
            btnAgregarDeduc.UseVisualStyleBackColor = true;
            btnAgregarDeduc.Click += btnAgregarDeduc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 9.75F);
            label6.Location = new Point(-1, 66);
            label6.Name = "label6";
            label6.Size = new Size(160, 22);
            label6.TabIndex = 5;
            label6.Text = "NUMERO EMPLEADO";
            // 
            // txtMontoOtrasDeducciones
            // 
            txtMontoOtrasDeducciones.Location = new Point(337, 91);
            txtMontoOtrasDeducciones.Name = "txtMontoOtrasDeducciones";
            txtMontoOtrasDeducciones.Size = new Size(114, 26);
            txtMontoOtrasDeducciones.TabIndex = 4;
            txtMontoOtrasDeducciones.KeyPress += txtMontoOtrasDeducciones_KeyPress;
            // 
            // txtConceptoOtrasDeducciones
            // 
            txtConceptoOtrasDeducciones.Location = new Point(188, 91);
            txtConceptoOtrasDeducciones.Name = "txtConceptoOtrasDeducciones";
            txtConceptoOtrasDeducciones.Size = new Size(114, 26);
            txtConceptoOtrasDeducciones.TabIndex = 3;
            txtConceptoOtrasDeducciones.KeyPress += txtConceptoOtrasDeducciones_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono", 9.75F);
            label5.Location = new Point(364, 66);
            label5.Name = "label5";
            label5.Size = new Size(60, 22);
            label5.TabIndex = 2;
            label5.Text = "MONTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 9.75F);
            label4.Location = new Point(203, 66);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 1;
            label4.Text = "CONCEPTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 9.75F);
            label3.Location = new Point(142, 23);
            label3.Name = "label3";
            label3.Size = new Size(230, 22);
            label3.TabIndex = 0;
            label3.Text = "OTRAS DEDUCCIONES(O.D)";
            // 
            // frmIngresosDeduc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1171, 555);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIngresosDeduc";
            Text = " ";
            Load += frmIngresosDeduc_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExport).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExportarExcel).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Button btnAgregarIng;
        private TextBox txtSalarioOrdinario;
        private Label label2;
        private TextBox txtNumeroEmpleadoIng;
        private Button btnEliminarIng;
        private Button btnActualizarIng;
        private DataGridView dgvIngresos;
        private GroupBox groupBox1;
        private Button btnAgregarDeduc;
        private Label label3;
        private TextBox txtMontoOtrasDeducciones;
        private TextBox txtConceptoOtrasDeducciones;
        private Label label5;
        private Label label4;
        private TextBox txtNumeroEmpleadoDeduc;
        private Label label6;
        private Button btnEliminarD;
        private Button btnActualizarDeduc;
        private DataGridView dgvDeducciones;
        private PictureBox btnExport;
        private PictureBox btnExportarExcel;
    }
}