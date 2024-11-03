using Modelo;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Modelo;
using SharedModels.Dto;
using System.Xml.Linq;

namespace Nomina
{
    public partial class frmEmpleados : Form
    {
        private readonly ApiClient _apiClient;
        public int yearsTrabajados;
        public frmEmpleados(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;

            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        string[] sexos = { "Masculino", "Femenino" };
        string[] EstadoCivil2 = { "Soltero", "Casado" };


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

                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

      

        private void txtHorasExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 2;

         
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
                NumeroCedula = txtCedula.Text,
                NumeroINSS = Convert.ToInt32(txtInss.Text),
                NumeroRUC = txtRuc.Text,
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                FechaNacimiento = DateOnly.Parse(FechaNacimiento.Text),
                Sexo = cboSexo.Text,
                EstadoCivil = cboEstadoCivil.Text,
                Direccion = txtDireccion.Text,
                Telefono = Convert.ToInt32(txtTelefono.Text),
                Celular = Convert.ToInt32(txtCelular.Text),
                FechaContratacion = DateOnly.Parse(dtpFechaContratacion.Text),
                FechaCierreContrato = DateOnly.Parse(dtpFechaCierreContrato.Text),
                EstadoEmpleado = chkEstadoEmpleado.Checked,
                YearsTrabajados = yearsTrabajados
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

            chkEstadoEmpleado.Checked = false;
            txtInss.Clear();
            txtRuc.Clear();
        }



        private void BtnExportar_Click_1(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvDatosEmpleado);
        }

        private void dtpFechaContratacion_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            yearsTrabajados = (int)(fechaActual.Year - dtpFechaContratacion.Value.Year);
            if (fechaActual < dtpFechaContratacion.Value.AddYears(yearsTrabajados))
            {
                yearsTrabajados--;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatosEmpleado.SelectedRows.Count > 0)
            {
                var selectedEmpleado = (EmpleadoDto)dgvDatosEmpleado.SelectedRows[0].DataBoundItem;
                var updateEmpleado = new EmpleadoUpdateDto
                {
                    NumeroEmpleado = selectedEmpleado.NumeroEmpleado,
                    NumeroCedula = txtCedula.Text,
                    NumeroINSS = Convert.ToInt32(txtInss.Text),
                    NumeroRUC = txtRuc.Text,
                    PrimerNombre = txtPrimerNombre.Text,
                    SegundoNombre = txtSegundoNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    FechaNacimiento = DateOnly.Parse(FechaNacimiento.Text),
                    Sexo = cboSexo.Text,
                    EstadoCivil = cboEstadoCivil.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt32(txtTelefono.Text),
                    Celular = Convert.ToInt32(txtCelular.Text),
                    FechaContratacion = DateOnly.Parse(dtpFechaContratacion.Text),
                    FechaCierreContrato = DateOnly.Parse(dtpFechaCierreContrato.Text),
                    EstadoEmpleado = chkEstadoEmpleado.Checked,
                    YearsTrabajados = yearsTrabajados
                };

                try
                {
                    var success = await _apiClient.Empleados.UpdateAsync(selectedEmpleado.NumeroEmpleado,
                updateEmpleado);

                    if (success)
                    {
                        MessageBox.Show("¡Empleado actualizado exitosamente!", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextBoxs();
                        await LoadEmpleadosAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al actualizar empleado.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar empleado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatosEmpleado.Rows.Count > 0)
            {
                var selectedEmpleado =
                    (EmpleadoDto)dgvDatosEmpleado.SelectedRows[0].DataBoundItem;
                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar el empleado '{selectedEmpleado.PrimerNombre}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var sucess =
                    await _apiClient.Empleados.DeleteAsync(selectedEmpleado.NumeroEmpleado);
                        if (sucess)
                        {
                            MessageBox.Show("¡Empleado eliminado exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadEmpleadosAsync();
                            LimpiarTextBoxs();
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar empleado.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar empleado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDatosEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var empleado = (EmpleadoDto)dgvDatosEmpleado.Rows[e.RowIndex].DataBoundItem;

                txtCedula.Text = empleado.NumeroCedula;
                txtInss.Text = empleado.NumeroINSS.ToString();
                txtRuc.Text = empleado.NumeroRUC;
                txtPrimerNombre.Text = empleado.PrimerNombre;
                txtSegundoNombre.Text = empleado.SegundoNombre;
                txtPrimerApellido.Text = empleado.PrimerApellido;
                txtSegundoApellido.Text = empleado.SegundoApellido;
                txtDireccion.Text = empleado.Direccion;
                txtTelefono.Text = empleado.Telefono.ToString();
                txtCelular.Text = empleado.Celular.ToString();
                chkEstadoEmpleado.Checked = empleado.EstadoEmpleado;
                cboSexo.Text = empleado.Sexo.ToString();
                cboEstadoCivil.Text = empleado.EstadoCivil.ToString();
                dtpFechaCierreContrato.Text = empleado.FechaCierreContrato.ToString();
                dtpFechaContratacion.Text = empleado.FechaContratacion.ToString();
                FechaNacimiento.Text = empleado.FechaNacimiento.ToString();

            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvDatosEmpleado);
        }
    }

}