using Modelo;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Modelo;
using SharedModels.Dto;

namespace Nomina
{
    public partial class frmEmpleados : Form
    {
        private readonly ApiClient _apiClient;
        public int yearsTrabajados = 0;
        public frmEmpleados()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
           
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        string[] sexos = { "M", "F" };
        string[] EstadoCivil2 = { "Soltero", "Casado" };
    


        NominaMensual nomina = new NominaMensual();
        NominaQuincenal quincenal = new NominaQuincenal();




        private async void frmEmpleados_Load(object sender, EventArgs e)
        {
            cboEstadoCivil.DataSource = EstadoCivil2;
           
            cboSexo.DataSource = sexos;
            dgvDatosEmpleado.RowTemplate.Height = 20;
            await LoadEmpleadosAsync();

        }

        private async Task LoadEmpleadosAsync()
        {
            try
            {
                var empleados = await _apiClient.Empleados.GetAllAsync();
                dgvDatosEmpleado.DataSource = empleados.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Validar()
        {

            if (txtPrimerNombre.Text.Trim().Length == 0)
            {
                return "Primer Nombre";
            }
            else if (txtSegundoNombre.Text.Trim().Length == 0)
            {
                return "Segundo Nombre";
            }
            else if (txtPrimerApellido.Text.Trim().Length == 0)
            {
                return "Primer Apellido";
            }
            else if (txtSegundoApellido.Text.Trim().Length == 0)
            {
                return "Segundo Apellido";
            }
            else if (txtCedula.Text.Trim().Length == 0)
            {
                return "Cédula";
            }
            else if (txtDireccion.Text.Trim().Length == 0)
            {
                return "Dirección";
            }
            else if (txtInss.Text.Trim().Length == 0)
            {
                return "No.Inss";
            }
            else if (txtRuc.Text.Trim().Length == 0)
            {
                return "No.Ruc";
            }
            else if (txtCelular.Text.Trim().Length == 0)
            {
                return "Celular";
            }
            else if (txtTelefono.Text.Trim().Length == 0)
            {
                return "Telefono";
            }
            else if (txtSalarioBase.Text.Trim().Length == 0)
            {
                return "Salario Base";
            }

            else if (txtNoEmpleado.Text.Trim().Length == 0)
            {
                return "No.Empleado";
            }

            return "";
        }



        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 8;

            if (txtTelefono.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 8;

            if (txtCelular.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 5;

            if (txtNoEmpleado.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 6;

            if (txtSalarioBase.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtHorasExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 2;

            //if (txtHorasExtras.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtMontoOtrosIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 5;

            //if (txtMontoOtrasDeducciones.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtMontoOtrasDeducciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 5;

            //if (txtMontoOtrasDeducciones.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConceptoOtrosIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConceptoOtrasDeducciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {

                if (txtCedula.Text.Length >= 13)
                {
                    e.Handled = true;
                }
            }

            else if (char.IsLetter(e.KeyChar) && char.IsUpper(e.KeyChar))
            {

                if (txtCedula.Text.Length != 13)
                {
                    e.Handled = true;
                }
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtInss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 7;

            if (txtInss.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            if (txtRuc.Text.Length >= 14)
            {
                e.Handled = true;
                return;
            }

            if (txtRuc.Text.Length == 0)
            {
                if (char.IsLetter(e.KeyChar) && char.IsUpper(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {

            var newEmpleado = new EmpleadoCreateDto
            { 
               NumeroCedula=txtCedula.Text,
               NumeroINSS=Convert.ToInt32(txtInss.Text),
               NumeroRUC=txtRuc.Text,
               PrimerNombre=txtPrimerNombre.Text,
               SegundoNombre=txtSegundoNombre.Text,
               PrimerApellido=txtPrimerApellido.Text,
               SegundoApellido=txtSegundoApellido.Text,
               FechaNacimiento=DateOnly.Parse(FechaNacimiento.Text),
               Sexo=cboSexo.Text,
               EstadoCivil=cboEstadoCivil.Text,
               Direccion=txtDireccion.Text, 
               Telefono= Convert.ToInt32(txtTelefono.Text),
               Celular= Convert.ToInt32(txtCelular.Text),
               FechaContratacion=DateOnly.Parse(FechaContratacion.Text),
               FechaCierreContrato= DateOnly.Parse(FechaCierreContrato.Text),
               EstadoEmpleado=chkEstadoEmpleado.Checked,
               YearsTrabajados=yearsTrabajados
            };
            try
            {
                var success = await _apiClient.Empleados.CreateAsync(newEmpleado);

                MessageBox.Show("¡Empleado agregado correctamente!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBoxs();
                await LoadEmpleadosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar empleado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void LimpiarTextBoxs()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtNoEmpleado.Clear();
            txtSalarioBase.Clear();
            chkEstadoEmpleado.Checked = false;
            txtInss.Clear();
            txtRuc.Clear();
        }

      

        private void FechaContratacion_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            yearsTrabajados = (int)(fechaActual.Year - FechaContratacion.Value.Year);
            if (fechaActual < FechaContratacion.Value.AddYears(yearsTrabajados))
            {
                yearsTrabajados--;
            }

            //nomina.YearsTrabajados = yearstrabajados;
            //quincenal.YearsTrabajados = yearstrabajados;
        }

        private void BtnExportar_Click_1(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvDatosEmpleado);
        }
    }

}