namespace Nomina
{
    partial class FrmCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateUser));
            panel1 = new Panel();
            btnCrearUsuario = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtLastName = new TextBox();
            txtFistName = new TextBox();
            txtUserName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(btnCrearUsuario);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFistName);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 501);
            panel1.TabIndex = 0;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.CornflowerBlue;
            btnCrearUsuario.FlatAppearance.BorderColor = Color.White;
            btnCrearUsuario.FlatAppearance.BorderSize = 0;
            btnCrearUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnCrearUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearUsuario.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearUsuario.Location = new Point(731, 419);
            btnCrearUsuario.Margin = new Padding(5, 3, 5, 3);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(142, 53);
            btnCrearUsuario.TabIndex = 25;
            btnCrearUsuario.Text = "CREAR";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.CornflowerBlue;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Cascadia Mono Light", 12F);
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(309, 419);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 24);
            txtEmail.TabIndex = 24;
            txtEmail.Text = "EMAIL";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.CornflowerBlue;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Cascadia Mono Light", 12F);
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(309, 340);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 24);
            txtPassword.TabIndex = 23;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.CornflowerBlue;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Cascadia Mono Light", 12F);
            txtLastName.ForeColor = SystemColors.ActiveCaptionText;
            txtLastName.Location = new Point(309, 275);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(360, 24);
            txtLastName.TabIndex = 22;
            txtLastName.Text = "APELLIDO";
            txtLastName.Enter += txtLastName_Enter;
            txtLastName.Leave += txtLastName_Leave;
            // 
            // txtFistName
            // 
            txtFistName.BackColor = Color.CornflowerBlue;
            txtFistName.BorderStyle = BorderStyle.None;
            txtFistName.Font = new Font("Cascadia Mono Light", 12F);
            txtFistName.ForeColor = SystemColors.ActiveCaptionText;
            txtFistName.Location = new Point(309, 183);
            txtFistName.Name = "txtFistName";
            txtFistName.Size = new Size(360, 24);
            txtFistName.TabIndex = 21;
            txtFistName.Text = "PRIMER NOMBRE";
            txtFistName.Enter += txtFistName_Enter;
            txtFistName.Leave += txtFistName_Leave;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.CornflowerBlue;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Cascadia Mono Light", 12F);
            txtUserName.ForeColor = SystemColors.ActiveCaptionText;
            txtUserName.Location = new Point(307, 107);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(361, 24);
            txtUserName.TabIndex = 20;
            txtUserName.Text = "NOMBRE DE USUARIO";
            txtUserName.Enter += txtUserName_Enter;
            txtUserName.Leave += txtUserName_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(309, 437);
            label6.Name = "label6";
            label6.Size = new Size(360, 20);
            label6.TabIndex = 19;
            label6.Text = ".....................................................................................................................";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(309, 367);
            label5.Name = "label5";
            label5.Size = new Size(360, 20);
            label5.TabIndex = 18;
            label5.Text = ".....................................................................................................................";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(309, 293);
            label4.Name = "label4";
            label4.Size = new Size(360, 20);
            label4.TabIndex = 17;
            label4.Text = ".....................................................................................................................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(309, 213);
            label3.Name = "label3";
            label3.Size = new Size(360, 20);
            label3.TabIndex = 16;
            label3.Text = ".....................................................................................................................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(309, 131);
            label2.Name = "label2";
            label2.Size = new Size(360, 20);
            label2.TabIndex = 15;
            label2.Text = ".....................................................................................................................";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono Light", 20.25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(402, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 45);
            label1.TabIndex = 14;
            label1.Text = "Crear Usuario";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(771, 11);
            btnMinimizar.Margin = new Padding(5, 3, 5, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(54, 51);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 13;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(830, 11);
            btnMaximizar.Margin = new Padding(5, 3, 5, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(54, 51);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 12;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -11);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 529);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 501);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCreateUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtLastName;
        private TextBox txtFistName;
        private TextBox txtUserName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCrearUsuario;
    }
}