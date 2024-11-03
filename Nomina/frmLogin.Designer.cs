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
            btnInicioSesion = new Button();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -7);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 517);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.CornflowerBlue;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Cascadia Mono Light", 12F);
            txtUser.ForeColor = SystemColors.ActiveCaptionText;
            txtUser.Location = new Point(373, 171);
            txtUser.Margin = new Padding(5, 4, 5, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(439, 24);
            txtUser.TabIndex = 3;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono Light", 20.25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(533, 83);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 45);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Enabled = false;
            lblUsuario.ForeColor = Color.Gainsboro;
            lblUsuario.Location = new Point(367, 199);
            lblUsuario.Margin = new Padding(5, 0, 5, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(444, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = ".................................................................................................................................................";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.CornflowerBlue;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Cascadia Mono Light", 12F);
            txtPass.ForeColor = SystemColors.ActiveCaptionText;
            txtPass.Location = new Point(367, 267);
            txtPass.Margin = new Padding(5, 4, 5, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(439, 24);
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
            lblContraseña.Location = new Point(367, 289);
            lblContraseña.Margin = new Padding(5, 0, 5, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(444, 20);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = ".................................................................................................................................................";
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.CornflowerBlue;
            btnInicioSesion.FlatAppearance.BorderSize = 0;
            btnInicioSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnInicioSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnInicioSesion.FlatStyle = FlatStyle.Flat;
            btnInicioSesion.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicioSesion.ForeColor = SystemColors.ActiveCaptionText;
            btnInicioSesion.Location = new Point(451, 332);
            btnInicioSesion.Margin = new Padding(5, 3, 5, 3);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(225, 53);
            btnInicioSesion.TabIndex = 9;
            btnInicioSesion.Text = "ACCEDER";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(831, 1);
            btnMaximizar.Margin = new Padding(5, 3, 5, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(54, 51);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 10;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(773, 1);
            btnMinimizar.Margin = new Padding(5, 3, 5, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(54, 51);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 11;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(698, 365);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(475, 388);
            label3.Name = "label3";
            label3.Size = new Size(210, 25);
            label3.TabIndex = 13;
            label3.Text = "¿NO TIENES CUENTA?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(499, 415);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 14;
            label4.Text = "CREALA AQUI";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.CornflowerBlue;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnCrear.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = SystemColors.ActiveCaptionText;
            btnCrear.Location = new Point(477, 461);
            btnCrear.Margin = new Padding(5, 3, 5, 3);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(176, 36);
            btnCrear.TabIndex = 15;
            btnCrear.Text = "CREAR CUENTA";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(888, 509);
            Controls.Add(btnCrear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMinimizar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnInicioSesion);
            Controls.Add(lblContraseña);
            Controls.Add(txtPass);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
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
        private Button btnInicioSesion;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCrear;
    }
}