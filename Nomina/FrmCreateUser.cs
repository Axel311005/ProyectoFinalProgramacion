using SharedModels.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nomina
{
    public partial class FrmCreateUser : Form
    {
        private readonly ApiClient _apiClient;
     
        public FrmCreateUser(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "NOMBRE DE USUARIO")
                txtUserName.Text = "";
            txtUserName.ForeColor = Color.LightGray;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "NOMBRE DE USUARIO";
                txtUserName.ForeColor = Color.DimGray;
            }
        }

        private void txtFistName_Leave(object sender, EventArgs e)
        {
            if (txtFistName.Text == "")
            {
                txtFistName.Text = "PRIMER NOMBRE";
                txtFistName.ForeColor = Color.DimGray;
            }
        }

        private void txtFistName_Enter(object sender, EventArgs e)
        {
            if (txtFistName.Text == "PRIMER NOMBRE")
                txtFistName.Text = "";
            txtFistName.ForeColor = Color.LightGray;
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "APELLIDO";
                txtLastName.ForeColor = Color.DimGray;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "APELLIDO")
                txtLastName.Text = "";
            txtLastName.ForeColor = Color.LightGray;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
                txtPassword.Text = "";
            txtPassword.ForeColor = Color.LightGray;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
                txtEmail.Text = "";
            txtEmail.ForeColor = Color.LightGray;
        }

        private async void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            await Register();
           
        }
        private async Task Register()
        {

            if (txtEmail.Text != "" && txtFistName.Text != "" && txtLastName.Text != "" && txtPassword.Text != "" && txtUserName.Text != "")
            {
                string UserName = txtUserName.Text;
                string FirstName = txtFistName.Text;
                string LastName = txtLastName.Text;
                string Email = txtEmail.Text;
                string Password = txtPassword.Text;

                var user =
                   await _apiClient.RegisterUsers.Register(UserName, FirstName, LastName, Password, Email);

                if (!string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Create successful!");

                    _apiClient.SetAuthToken(user);
                    Hide();

                }
                else
                {
                    MessageBox.Show("Create failed. Please check.");
                }
            }
            else
            {
                MessageBox.Show("Error, revise los campos en blanco");
            }
            
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
