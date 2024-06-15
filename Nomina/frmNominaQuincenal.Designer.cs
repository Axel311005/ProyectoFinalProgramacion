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
            TabPage tabPage2;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvNomina = new DataGridView();
            BtnExportarM = new PictureBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnExportarM).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.CornflowerBlue;
            tabPage2.Controls.Add(BtnExportarM);
            tabPage2.Controls.Add(dgvNomina);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1408, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nomina Mensual";
            // 
            // dgvNomina
            // 
            dgvNomina.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 6F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 6F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNomina.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNomina.Location = new Point(6, 51);
            dgvNomina.Margin = new Padding(2, 1, 2, 1);
            dgvNomina.Name = "dgvNomina";
            dgvNomina.RowHeadersWidth = 82;
            dgvNomina.RowTemplate.Height = 41;
            dgvNomina.Size = new Size(1299, 346);
            dgvNomina.TabIndex = 15;
            // 
            // BtnExportarM
            // 
            BtnExportarM.Image = Properties.Resources.archivo_excel;
            BtnExportarM.Location = new Point(6, 401);
            BtnExportarM.Margin = new Padding(4);
            BtnExportarM.Name = "BtnExportarM";
            BtnExportarM.Size = new Size(62, 46);
            BtnExportarM.SizeMode = PictureBoxSizeMode.Zoom;
            BtnExportarM.TabIndex = 46;
            BtnExportarM.TabStop = false;
            BtnExportarM.Click += BtnExportarM_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-3, 3);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1416, 672);
            tabControl1.TabIndex = 18;
            // 
            // frmNominaQuincenal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1337, 504);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmNominaQuincenal";
            Text = "frmNominaQuincenal";
            Load += frmNominaQuincenal_Load_1;
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnExportarM).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BtnExportarM;
        private DataGridView dgvNomina;
        private TabControl tabControl1;
    }
}