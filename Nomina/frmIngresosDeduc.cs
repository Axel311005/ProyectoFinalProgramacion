using Modelo;
using SharedModels.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nomina
{
    public partial class frmIngresosDeduc : Form
    {
        private readonly ApiClient _apiClient;
        public frmIngresosDeduc(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void frmIngresosDeduc_Load(object sender, EventArgs e)
        {
            await LoadIngresosAsync();
            await LoadDeduccionesAsync();
        }
        private async Task LoadIngresosAsync()
        {
            try
            {
                var ingresos = await _apiClient.Ingresos.GetAllAsync();
                dgvIngresos.DataSource = ingresos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ingresos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDeduccionesAsync()
        {
            try
            {
                var deducciones = await _apiClient.Deducciones.GetAllAsync();
                dgvDeducciones.DataSource = deducciones.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar deducciones: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFieldsIngresos()
        {
            txtConceptoOtrosIngresos.Clear();
            txtHorasExtras.Clear();
            txtNumeroEmpleadoIng.Clear();
            txtMontoOtrosIngresos.Clear();
            txtSalarioOrdinario.Clear();
        }
        private void ClearInputFieldsDeducciones()
        {
            txtNumeroEmpleadoDeduc.Clear();
            txtMontoOtrasDeducciones.Clear();
            txtConceptoOtrasDeducciones.Clear();
        }

        private async void btnAgregarIng_Click(object sender, EventArgs e)
        {

            if (txtNumeroEmpleadoIng.Text != "" && txtMontoOtrosIngresos.Text != "" && txtHorasExtras.Text != ""
                && txtSalarioOrdinario.Text != "")
            {
                var newIngreso = new IngresoCreateDto
                {

                    NumeroEmpleado = Convert.ToInt32(txtNumeroEmpleadoIng.Text),
                    SalarioOrdinario = Convert.ToInt32(txtSalarioOrdinario.Text),
                    ConceptoOtrosIngresos = txtConceptoOtrosIngresos.Text,
                    OtrosIngresos = Convert.ToInt32(txtMontoOtrosIngresos.Text),
                    HorasExtras = Convert.ToInt32(txtHorasExtras.Text)

                };

                try
                {
                    var success = await _apiClient.Ingresos.CreateAsync(newIngreso);

                    MessageBox.Show("¡Ingreso agregado correctamente!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFieldsIngresos();
                    await LoadIngresosAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar Ingreso: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al agregar ingreso, revise los espacios en blanco", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

            
        }

        private async void btnActualizarIng_Click(object sender, EventArgs e)
        {

            if (dgvIngresos.SelectedRows.Count > 0)
            {

                if (txtNumeroEmpleadoIng.Text != "" && txtMontoOtrosIngresos.Text != "" && txtHorasExtras.Text != ""
                && txtSalarioOrdinario.Text != "")
                {
                    var selectedIngreso = (IngresoDto)dgvIngresos.SelectedRows[0].DataBoundItem;
                    var updateIngreso = new IngresoUpdateDto
                    {
                        IngresoID = selectedIngreso.IngresoID,
                        NumeroEmpleado = Convert.ToInt32(txtNumeroEmpleadoIng.Text),
                        SalarioOrdinario = Convert.ToInt32(txtSalarioOrdinario.Text),
                        ConceptoOtrosIngresos = txtConceptoOtrosIngresos.Text,
                        OtrosIngresos = Convert.ToInt32(txtMontoOtrosIngresos.Text),
                        HorasExtras = Convert.ToInt32(txtHorasExtras.Text),

                    };

                    try
                    {
                        var success = await _apiClient.Ingresos.UpdateAsync(selectedIngreso.IngresoID,
                    updateIngreso);

                        if (success)
                        {
                            MessageBox.Show("¡Ingreso actualizado exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFieldsIngresos();
                            await LoadIngresosAsync();
                        }
                        else
                        {
                            MessageBox.Show($"Error al actualizar ingreso.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar ingreso: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al actualizar ingreso, revise los espacios en blanco", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   
            }
            else
            {
                MessageBox.Show("Seleccione un ingreso de un empleado para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private async void btnEliminarIng_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.Rows.Count > 0)
            {
                var selectedIngreso =
                    (IngresoDto)dgvIngresos.SelectedRows[0].DataBoundItem;
                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar el ingreso del empleado '{selectedIngreso.NumeroEmpleado}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var sucess =
                    await _apiClient.Ingresos.DeleteAsync(selectedIngreso.IngresoID);
                        if (sucess)
                        {
                            MessageBox.Show("¡Ingreso eliminado exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadIngresosAsync();
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar ingreso.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar ingreso: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione un ingreso para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ingreso = (IngresoDto)dgvIngresos.Rows[e.RowIndex].DataBoundItem;

                txtNumeroEmpleadoIng.Text = ingreso.NumeroEmpleado.ToString();
                txtSalarioOrdinario.Text = ingreso.SalarioOrdinario.ToString();
                txtConceptoOtrosIngresos.Text = ingreso.ConceptoOtrosIngresos;
                txtMontoOtrosIngresos.Text = ingreso.OtrosIngresos.ToString();

            }
        }

        private void dgvDeducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var deduccion = (DeduccionDto)dgvDeducciones.Rows[e.RowIndex].DataBoundItem;
                txtNumeroEmpleadoDeduc.Text = deduccion.NumeroEmpleado.ToString();
                txtConceptoOtrasDeducciones.Text = deduccion.ConceptoOD;
                txtMontoOtrasDeducciones.Text = deduccion.MontoOtrasDeducciones.ToString();

            }
        }

        private async void btnAgregarDeduc_Click(object sender, EventArgs e)
        {
            if (txtNumeroEmpleadoDeduc.Text != "" && txtMontoOtrasDeducciones.Text != "") 
            {
                var newDeduc = new DeduccionCreateDto
                {

                    NumeroEmpleado = Convert.ToInt32(txtNumeroEmpleadoDeduc.Text),
                    ConceptoOD = txtConceptoOtrasDeducciones.Text,
                    MontoOtrasDeducciones = Convert.ToInt32(txtMontoOtrasDeducciones.Text)

                };

                try
                {
                    var success = await _apiClient.Deducciones.CreateAsync(newDeduc);

                    MessageBox.Show("¡Deducción agregada correctamente!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFieldsDeducciones();
                    await LoadDeduccionesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar Deducción: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Error al agregar Deducción, revise los espacios en blanco",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private async void btnActualizarDeduc_Click(object sender, EventArgs e)
        {
            if (dgvDeducciones.SelectedRows.Count > 0)
            {
                if (txtNumeroEmpleadoDeduc.Text != "" && txtMontoOtrasDeducciones.Text != "")
                {
                    var selectedDeduc = (DeduccionDto)dgvDeducciones.SelectedRows[0].DataBoundItem;
                    var updateDeduc = new DeduccionUpdateDto
                    {
                        DeduccionID = selectedDeduc.DeduccionID,
                        NumeroEmpleado = Convert.ToInt32(txtNumeroEmpleadoDeduc.Text),
                        ConceptoOD = txtConceptoOtrasDeducciones.Text,
                        MontoOtrasDeducciones = Convert.ToInt32(txtMontoOtrasDeducciones.Text)

                    };

                    try
                    {
                        var success = await _apiClient.Deducciones.UpdateAsync(selectedDeduc.DeduccionID,
                    updateDeduc);

                        if (success)
                        {
                            MessageBox.Show("¡Deducción actualizada exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFieldsDeducciones();
                            await LoadDeduccionesAsync();
                        }
                        else
                        {
                            MessageBox.Show($"Error al actualizar deducción.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar deducción: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Error al actualizar deducción, revise los espaciose en blanco",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MessageBox.Show("Seleccione una deducción de un empleado para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnEliminarD_Click(object sender, EventArgs e)
        {
            if (dgvDeducciones.Rows.Count > 0)
            {
                var selectedDeduc =
                    (DeduccionDto)dgvDeducciones.SelectedRows[0].DataBoundItem;
                var result =
                    MessageBox.Show($"¿Está seguro de que desea eliminar la deducción del empleado '{selectedDeduc.NumeroEmpleado}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var sucess =
                    await _apiClient.Deducciones.DeleteAsync(selectedDeduc.DeduccionID);
                        if (sucess)
                        {
                            MessageBox.Show("¡Deducción eliminada exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadDeduccionesAsync();
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar deducción.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar deducción: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione una deducción para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvIngresos);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvDeducciones);
        }

        private void txtNumeroEmpleadoIng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void txtNumeroEmpleadoDeduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
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

        }

        private void txtMontoOtrosIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
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

        private void txtSalarioOrdinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
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

        private void txtMontoOtrasDeducciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
