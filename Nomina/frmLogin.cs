using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nomina
{
    public partial class frmLogin : Form
    {
        private readonly ApiClient _apiClient;

        public frmLogin()
        {
            InitializeComponent();
            _apiClient = new ApiClient();

        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async Task LoginAsync()
        {

            if (txtPass.Text != "" && txtUser.Text!="")
            {
                string username = txtUser.Text;
                string password = txtPass.Text;

                var token =
                    await _apiClient.LoginUsers.AuthenticateUserAsync(username, password);

                if (!string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Login successful!");


                    _apiClient.SetAuthToken(token);

                    Hide();
                    var mainForm = new InterfazIU(_apiClient);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password.");
                }
            }
            else
            {
                MessageBox.Show("Error, revise los espacios en blanco");
            }
            
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
                txtUser.Text = "";
            txtUser.ForeColor = Color.LightGray;

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
                txtPass.Text = "";
            txtPass.ForeColor = Color.LightGray;
            txtPass.UseSystemPasswordChar = true;

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }

        }

        private async void btnInicioSesion_Click(object sender, EventArgs e)
        {
            await LoginAsync();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var mainForm = new FrmCreateUser(_apiClient);
            mainForm.Show();
        }
    }
}
