namespace Nomina
{
    partial class frmNomina
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtnExportarM = new PictureBox();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtNumeroEmpleado = new TextBox();
            label1 = new Label();
            dgvNominaIndividual = new DataGridView();
            tabPage2 = new TabPage();
            btnGenNomi = new Button();
            btnExportExcel = new PictureBox();
            dgvNominaGeneral = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnExportarM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNominaIndividual).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExportExcel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNominaGeneral).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 584);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1089, 547);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.Controls.Add(BtnExportarM);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(txtNumeroEmpleado);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvNominaIndividual);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1081, 511);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gestion Nomina";
            // 
            // BtnExportarM
            // 
            BtnExportarM.Image = Properties.Resources.archivo_excel;
            BtnExportarM.Location = new Point(779, 58);
            BtnExportarM.Margin = new Padding(5, 4, 5, 4);
            BtnExportarM.Name = "BtnExportarM";
            BtnExportarM.Size = new Size(62, 45);
            BtnExportarM.SizeMode = PictureBoxSizeMode.Zoom;
            BtnExportarM.TabIndex = 48;
            BtnExportarM.TabStop = false;
            BtnExportarM.Click += BtnExportarM_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Cascadia Mono", 9.75F);
            btnEditar.Location = new Point(621, 118);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 48);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Cascadia Mono", 9.75F);
            btnAgregar.Location = new Point(621, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 43);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNumeroEmpleado
            // 
            txtNumeroEmpleado.Location = new Point(372, 118);
            txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            txtNumeroEmpleado.Size = new Size(156, 27);
            txtNumeroEmpleado.TabIndex = 2;
            txtNumeroEmpleado.KeyPress += txtNumeroEmpleado_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(352, 58);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 1;
            label1.Text = "Numero de Empleado";
            // 
            // dgvNominaIndividual
            // 
            dgvNominaIndividual.BackgroundColor = SystemColors.ButtonFace;
            dgvNominaIndividual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvNominaIndividual.DefaultCellStyle = dataGridViewCellStyle1;
            dgvNominaIndividual.Location = new Point(224, 204);
            dgvNominaIndividual.Name = "dgvNominaIndividual";
            dgvNominaIndividual.RowHeadersWidth = 51;
            dgvNominaIndividual.Size = new Size(603, 272);
            dgvNominaIndividual.TabIndex = 0;
            dgvNominaIndividual.CellClick += dgvNominaIndividual_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.CornflowerBlue;
            tabPage2.Controls.Add(btnGenNomi);
            tabPage2.Controls.Add(btnExportExcel);
            tabPage2.Controls.Add(dgvNominaGeneral);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1081, 511);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nomina";
            // 
            // btnGenNomi
            // 
            btnGenNomi.FlatAppearance.BorderSize = 0;
            btnGenNomi.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnGenNomi.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnGenNomi.FlatStyle = FlatStyle.Flat;
            btnGenNomi.Font = new Font("Cascadia Mono", 9.75F);
            btnGenNomi.Location = new Point(37, 23);
            btnGenNomi.Name = "btnGenNomi";
            btnGenNomi.Size = new Size(189, 43);
            btnGenNomi.TabIndex = 49;
            btnGenNomi.Text = "Generar Nomina";
            btnGenNomi.UseVisualStyleBackColor = true;
            btnGenNomi.Click += btnGenNomi_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Image = Properties.Resources.archivo_excel;
            btnExportExcel.Location = new Point(965, 23);
            btnExportExcel.Margin = new Padding(5, 4, 5, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(62, 45);
            btnExportExcel.SizeMode = PictureBoxSizeMode.Zoom;
            btnExportExcel.TabIndex = 48;
            btnExportExcel.TabStop = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // dgvNominaGeneral
            // 
            dgvNominaGeneral.BackgroundColor = SystemColors.Control;
            dgvNominaGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNominaGeneral.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNominaGeneral.Location = new Point(9, 76);
            dgvNominaGeneral.Name = "dgvNominaGeneral";
            dgvNominaGeneral.RowHeadersWidth = 51;
            dgvNominaGeneral.Size = new Size(1018, 372);
            dgvNominaGeneral.TabIndex = 0;
            // 
            // frmNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 584);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNomina";
            Text = "frmNomina";
            Load += frmNomina_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnExportarM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNominaIndividual).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnExportExcel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNominaGeneral).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvNominaGeneral;
        private DataGridView dgvNominaIndividual;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtNumeroEmpleado;
        private Label label1;
        private PictureBox BtnExportarM;
        private PictureBox btnExportExcel;
        private Button btnGenNomi;
    }
}