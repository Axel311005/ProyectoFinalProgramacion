using Modelo;
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

namespace Nomina
{
    public partial class frmNomina : Form
    {
        private readonly ApiClient _apiClient;

        public frmNomina(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNumeroEmpleado.Text != "")
            {
                var newNominaInd = new NominaCreateDto
                {
                    NumeroEmpleado = Convert.ToInt32(txtNumeroEmpleado.Text),
                    FechaNomina = DateOnly.FromDateTime(DateTime.Now),

                };

                try
                {
                    var success = await _apiClient.Nominas.CreateAsync(newNominaInd);

                    MessageBox.Show("¡Nomina agregada correctamente!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumeroEmpleado.Text = "";
                    await LoadNominaIndividual();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar nomina: {ex.Message}",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Error al agregar nomina, revise los espacios en blanco",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void frmNomina_Load(object sender, EventArgs e)
        {
            await LoadNominaIndividual();
           
        }

        private async Task LoadNominasCompletas()
        {
            try
            {
                var nominas = await _apiClient.nominaRepository.GetNominaGeneral();
                dgvNominaGeneral.DataSource = nominas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nominas: {ex.Message}",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadNominaIndividual()
        {
            try
            {
                var nominasInd = await _apiClient.Nominas.GetAllAsync();
                dgvNominaIndividual.DataSource = nominasInd.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nominas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtNumeroEmpleado.Clear();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvNominaIndividual.SelectedRows.Count > 0)
            {
                if(txtNumeroEmpleado.Text != "")
                {
                    var selectedNominaInd = (NominaDto)dgvNominaIndividual.SelectedRows[0].DataBoundItem;
                    var updateNominaInd = new NominaUpdateDto
                    {
                        NominaID = selectedNominaInd.NominaID,
                        NumeroEmpleado = Convert.ToInt32(txtNumeroEmpleado.Text),
                        FechaNomina = DateOnly.FromDateTime(DateTime.Now),

                    };

                    try
                    {
                        var success = await _apiClient.Nominas.UpdateAsync(selectedNominaInd.NominaID,
                    updateNominaInd);

                        if (success)
                        {
                            MessageBox.Show("¡Nomina actualizada exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                            await LoadNominaIndividual();
                        }
                        else
                        {
                            MessageBox.Show($"Error al actualizar nomina.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar nomina: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Error al actualizar nomina, revise los espacios en blanco",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione una nomina de un empleado para actualizar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNominaIndividual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var nominaInd = (NominaDto)dgvNominaIndividual.Rows[e.RowIndex].DataBoundItem;

                txtNumeroEmpleado.Text = nominaInd.NumeroEmpleado.ToString();

            }
        }

        private void BtnExportarM_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvNominaIndividual);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvNominaGeneral);
        }

        private void txtNumeroEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private async void btnGenNomi_Click(object sender, EventArgs e)
        {
            await LoadNominasCompletas();
        }
    }
}
