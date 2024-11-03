namespace Nomina
{
    partial class InterfazIU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazIU));
            PanelTop = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            btnIngrDeduc = new Button();
            panel2 = new Panel();
            btnNomina = new Button();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            BtnPLanilla = new Button();
            PanelMid = new Panel();
            PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.FromArgb(58, 110, 165);
            PanelTop.Controls.Add(pictureBox2);
            PanelTop.Controls.Add(pictureBox1);
            PanelTop.ForeColor = SystemColors.ActiveCaptionText;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Margin = new Padding(5, 4, 5, 4);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(2053, 64);
            PanelTop.TabIndex = 0;
            PanelTop.MouseDown += PanelTop_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1432, 9);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CErrarUI2;
            pictureBox1.Location = new Point(1479, 9);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 78, 152);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnIngrDeduc);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnNomina);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(BtnPLanilla);
            panel1.Location = new Point(0, 64);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 707);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(33, 158, 188);
            panel4.Location = new Point(0, 336);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 43);
            panel4.TabIndex = 8;
            // 
            // btnIngrDeduc
            // 
            btnIngrDeduc.FlatAppearance.BorderSize = 0;
            btnIngrDeduc.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 158, 188);
            btnIngrDeduc.FlatStyle = FlatStyle.Flat;
            btnIngrDeduc.Font = new Font("Cascadia Mono Light", 12F);
            btnIngrDeduc.ForeColor = Color.White;
            btnIngrDeduc.Location = new Point(5, 289);
            btnIngrDeduc.Margin = new Padding(5, 4, 5, 4);
            btnIngrDeduc.Name = "btnIngrDeduc";
            btnIngrDeduc.Size = new Size(238, 43);
            btnIngrDeduc.TabIndex = 9;
            btnIngrDeduc.Text = "Ingresos/Deducciones";
            btnIngrDeduc.UseVisualStyleBackColor = false;
            btnIngrDeduc.Click += btnIngrDeduc_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 158, 188);
            panel2.Location = new Point(0, 285);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 43);
            panel2.TabIndex = 7;
            // 
            // btnNomina
            // 
            btnNomina.FlatAppearance.BorderSize = 0;
            btnNomina.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 158, 188);
            btnNomina.FlatStyle = FlatStyle.Flat;
            btnNomina.Font = new Font("Cascadia Mono Light", 12F);
            btnNomina.ForeColor = Color.White;
            btnNomina.Location = new Point(0, 336);
            btnNomina.Margin = new Padding(5, 4, 5, 4);
            btnNomina.Name = "btnNomina";
            btnNomina.Size = new Size(229, 43);
            btnNomina.TabIndex = 8;
            btnNomina.Text = "Nominas";
            btnNomina.UseVisualStyleBackColor = false;
            btnNomina.Click += btnNomina_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(5, 4, 5, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(238, 207);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 158, 188);
            panel3.Location = new Point(0, 231);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 43);
            panel3.TabIndex = 6;
            // 
            // BtnPLanilla
            // 
            BtnPLanilla.FlatAppearance.BorderSize = 0;
            BtnPLanilla.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 158, 188);
            BtnPLanilla.FlatStyle = FlatStyle.Flat;
            BtnPLanilla.Font = new Font("Cascadia Mono Light", 12F);
            BtnPLanilla.ForeColor = Color.White;
            BtnPLanilla.Location = new Point(0, 235);
            BtnPLanilla.Margin = new Padding(5, 4, 5, 4);
            BtnPLanilla.Name = "BtnPLanilla";
            BtnPLanilla.Size = new Size(229, 43);
            BtnPLanilla.TabIndex = 2;
            BtnPLanilla.Text = "Empleados";
            BtnPLanilla.UseVisualStyleBackColor = false;
            BtnPLanilla.Click += BtnPLanilla_Click;
            // 
            // PanelMid
            // 
            PanelMid.Location = new Point(239, 64);
            PanelMid.Margin = new Padding(5, 4, 5, 4);
            PanelMid.Name = "PanelMid";
            PanelMid.Size = new Size(1287, 697);
            PanelMid.TabIndex = 2;
            // 
            // InterfazIU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 773);
            Controls.Add(PanelMid);
            Controls.Add(panel1);
            Controls.Add(PanelTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "InterfazIU";
            Text = "InterfazIU";
            PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel PanelMid;
        private Panel panel3;
        private Button BtnPLanilla;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button btnNomina;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button btnIngrDeduc;
    }
}