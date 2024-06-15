using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class InterfazIU : Form
    {
        public InterfazIU()
        {
            InitializeComponent();
            CenterToScreen();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPLanilla_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEmpleados());
        }

        private void AbrirForm(Object form)
        {
            if (this.PanelMid.Controls.Count > 0)
            {

                var existForm = this.PanelMid.Controls[0] as Form;
                existForm.Close();
            }

            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.PanelMid.Controls.Add(frm);
            this.PanelMid.Tag = frm;
            frm.Show();
        }


        private void btnNomina_Click(object sender, EventArgs e)
        {
            if (PanelMid.Controls.Count > 0)
            {
                PanelMid.Controls.Clear();
                AbrirForm(new frmNominaQuincenal());
            }



        }


    }

}
