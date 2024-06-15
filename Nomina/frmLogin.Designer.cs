namespace Nomina
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            label1 = new Label();
            lblUsuario = new Label();
            txtPass = new TextBox();
            lblContraseña = new Label();
            btnInicioSecion = new Button();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -11);
            pictureBox1.Margin = new Padding(6, 4, 6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 828);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.CornflowerBlue;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.Transparent;
            txtUser.Location = new Point(605, 284);
            txtUser.Margin = new Padding(6);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(713, 38);
            txtUser.TabIndex = 3;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(864, 132);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 72);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Enabled = false;
            lblUsuario.ForeColor = Color.Gainsboro;
            lblUsuario.Location = new Point(596, 319);
            lblUsuario.Margin = new Padding(6, 0, 6, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(739, 32);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = ".................................................................................................................................................";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.CornflowerBlue;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.Transparent;
            txtPass.Location = new Point(596, 427);
            txtPass.Margin = new Padding(6);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(713, 38);
            txtPass.TabIndex = 7;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Enabled = false;
            lblContraseña.ForeColor = Color.Gainsboro;
            lblContraseña.Location = new Point(596, 462);
            lblContraseña.Margin = new Padding(6, 0, 6, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(739, 32);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = ".................................................................................................................................................";
            // 
            // btnInicioSecion
            // 
            btnInicioSecion.BackColor = Color.CornflowerBlue;
            btnInicioSecion.FlatStyle = FlatStyle.Flat;
            btnInicioSecion.ForeColor = Color.Transparent;
            btnInicioSecion.Location = new Point(565, 617);
            btnInicioSecion.Margin = new Padding(6, 4, 6, 4);
            btnInicioSecion.Name = "btnInicioSecion";
            btnInicioSecion.Size = new Size(752, 85);
            btnInicioSecion.TabIndex = 9;
            btnInicioSecion.Text = "ACCEDER";
            btnInicioSecion.UseVisualStyleBackColor = false;
            btnInicioSecion.Click += btnInicioSecion_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1350, 2);
            btnMaximizar.Margin = new Padding(6, 4, 6, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(87, 81);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 10;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1254, 2);
            btnMinimizar.Margin = new Padding(6, 4, 6, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(87, 81);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 11;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1443, 804);
            Controls.Add(btnMinimizar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnInicioSecion);
            Controls.Add(lblContraseña);
            Controls.Add(txtPass);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Label label1;
        private Label lblUsuario;
        private TextBox txtPass;
        private Label lblContraseña;
        private Button btnInicioSecion;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
    }
}