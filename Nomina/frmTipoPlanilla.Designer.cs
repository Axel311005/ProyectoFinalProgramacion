namespace Nomina
{
    partial class frmTipoPlanilla
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
            btnMensual = new Button();
            btnQuincenal = new Button();
            SuspendLayout();
            // 
            // btnMensual
            // 
            btnMensual.Location = new Point(114, 155);
            btnMensual.Name = "btnMensual";
            btnMensual.Size = new Size(150, 46);
            btnMensual.TabIndex = 0;
            btnMensual.Text = "Mensual";
            btnMensual.UseVisualStyleBackColor = true;
            btnMensual.Click += btnMensual_Click;
            // 
            // btnQuincenal
            // 
            btnQuincenal.Location = new Point(482, 155);
            btnQuincenal.Name = "btnQuincenal";
            btnQuincenal.Size = new Size(150, 46);
            btnQuincenal.TabIndex = 1;
            btnQuincenal.Text = "Quincenal";
            btnQuincenal.UseVisualStyleBackColor = true;
            btnQuincenal.Click += btnQuincenal_Click;
            // 
            // frmTipoPlanilla
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuincenal);
            Controls.Add(btnMensual);
            Name = "frmTipoPlanilla";
            Text = "frmTipoPlanilla";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMensual;
        private Button btnQuincenal;
    }
}