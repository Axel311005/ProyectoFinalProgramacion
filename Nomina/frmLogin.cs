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
        private Dictionary<string, string> usuarios;

        public frmLogin()
        {
            InitializeComponent();
            usuarios = CargarUsuarios();
            
        }

        private void CrearArchivoUsuarios()
        {
            using (StreamWriter Login = new StreamWriter("usuarios.txt"))
            {
                string datos = "Axel31,123456";
                Login.WriteLine(datos);
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

        private void btnInicioSecion_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contrasena = txtPass.Text;

            if (VerificarCredenciales(usuario, contrasena))
            {
                MessageBox.Show($"Inicio de sesión exitoso. ¡Bienvenido, {usuario}!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                InterfazIU interfazIU = new InterfazIU();
                interfazIU.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string, string> CargarUsuarios()
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>();

            try
            {
                string[] lineas = File.ReadAllLines("usuarios.txt");

                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(','); 
                    string usuario = partes[0].Trim(); 
                    string contrasena = partes[1].Trim(); 
                    usuarios[usuario] = contrasena;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarios;
        }

        private bool VerificarCredenciales(string usuario, string contrasena)
        {
            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contrasena)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Intento de inicio de sesión fallido para usuario: {usuario}, contraseña: {contrasena}");
                return false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (!File.Exists("usuarios.txt"))
            {
                CrearArchivoUsuarios();
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
    }
}
