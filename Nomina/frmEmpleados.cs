using Modelo;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nomina
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();

            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPlanilla.DropDownStyle = ComboBoxStyle.DropDownList;


        }




        string[] sexos = { "M", "F" };
        string[] EstadoCivil2 = { "Soltero", "Casado" };
        string[] estado2 = { "Activo", "No Activo" };
        string[] TipoPlanilla = { "Mensual", "Quincenal" };

        N�mina nomina = new N�mina();
        NominaQuincenal quincenal = new NominaQuincenal();

        private void btnCalcularNomina_Click(object sender, EventArgs e)
        {

        }





        public void EnviarObjetos()
        {

            nomina.NumeroCedula = txtCedula.Text;
            nomina.NumeroEmpleados = int.Parse(txtNoEmpleado.Text);
            nomina.NumeroInss = int.Parse(txtInss.Text);
            nomina.NumeroRuc = txtRuc.Text;
            nomina.PrimerNombre = txtPrimerNombre.Text;
            nomina.SegundoNombre = txtSegundoNombre.Text;
            nomina.PrimerApellido = txtPrimerApellido.Text;
            nomina.SegundoApellido = txtSegundoApellido.Text;
            nomina.FechaNacimiento = DateTime.Parse(FechaNacimiento.Text);
            nomina.Sexo = cboSexo.Text;
            nomina.EstadoCivil = cboEstadoCivil.Text;
            nomina.Direccion = txtDireccion.Text;
            nomina.Telefono = int.Parse(txtTelefono.Text);
            nomina.Celular = int.Parse(txtCelular.Text);
            nomina.FechaContratacion = DateTime.Parse(FechaContratacion.Text);
            nomina.FechaFinalizacionContrato = DateTime.Parse(FechaCierreContrato.Text);
            nomina.SalarioBase = double.Parse(txtSalarioBase.Text);
            nomina.EstadoDelEmpleado = cboEstadoEmpleado.Text;
            nomina.OtrosIngresos = double.Parse(txtMontoOtrosIngresos.Text);
            nomina.OtrasDeducciones = double.Parse(txtMontoOtrasDeducciones.Text);
            nomina.HorasExtras = int.Parse(txtHorasExtras.Text);

            quincenal.SalarioBase = int.Parse(txtSalarioBase.Text);
            quincenal.HorasExtras = int.Parse(txtHorasExtras.Text);
            quincenal.OtrosIngresos = double.Parse(txtMontoOtrosIngresos.Text);
            quincenal.OtrasDeducciones = double.Parse(txtMontoOtrasDeducciones.Text);


        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cboEstadoCivil.DataSource = EstadoCivil2;
            cboEstadoEmpleado.DataSource = estado2;
            cboSexo.DataSource = sexos;
            dgvDatosEmpleado.RowTemplate.Height = 20;
            dgvNomina.RowTemplate.Height = 20;
            cboTipoPlanilla.DataSource = TipoPlanilla;
            CrearCargarFicheroDatosEmpleados();


        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            EnviarObjetos();
            GrabarDatosEmpleados();
            

            if (cboTipoPlanilla.SelectedItem == "Mensual")
            {
                Agregar();
            }
            if (cboTipoPlanilla.SelectedItem == "Quincenal")
            {
                AgregarQuincenalmente();
            }



        }


        public void AgregarDataEmpleado()
        {
            dgvDatosEmpleado.Rows.Add(txtNoEmpleado.Text, txtCedula.Text, txtInss.Text, txtRuc.Text,
                    txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text,
                    txtSegundoApellido.Text, FechaNacimiento.Text, cboSexo.Text, cboEstadoCivil.Text,
                    txtDireccion.Text, txtTelefono.Text, txtCelular.Text, FechaContratacion.Text
                    , FechaCierreContrato.Text, txtSalarioBase.Text, cboEstadoEmpleado.Text);
        }

        private void AgregarQuincenalmente()
        {
            if (Validar() == "")
            {

                AgregarDataEmpleado();
                dgvNomina.Rows.Add(txtNoEmpleado.Text, txtPrimerNombre.Text,
                    txtSegundoNombre.Text, txtPrimerApellido.Text,
                    txtSegundoApellido.Text, quincenal.SalarioQuincenal().ToString("0.00"),
                    quincenal.CalcularAntiguedad().ToString("0.00"), quincenal.CalcularRiesgoLaboral().ToString("0.00"),
                    quincenal.CalcularNorturnidad().ToString("0.00"), txtConceptoOtrosIngresos.Text,
                    txtMontoOtrosIngresos.Text, quincenal.CalcularPagoHorasExtras().ToString("0.00"), quincenal.TotalIngresos().ToString("0.00"),
                    quincenal.CalcularInss().ToString("0.00"), quincenal.CalcularIR().ToString("0.00"),
                    txtConceptoOtrasDeducciones.Text, txtMontoOtrasDeducciones.Text, quincenal.TotalDeducciones().ToString("0.00"),
                    quincenal.SalarioNeto().ToString("0.00"));
            }
        }



        private void Agregar()
        {
            if (Validar() == "")
            {

                AgregarDataEmpleado();


                dgvNomina.Rows.Add(txtNoEmpleado.Text, txtPrimerNombre.Text,
                    txtSegundoNombre.Text, txtPrimerApellido.Text,
                    txtSegundoApellido.Text, txtSalarioBase.Text,
                    nomina.CalcularAntiguedad().ToString("0.00"), nomina.CalcularRiesgoLaboral().ToString("0.00"),
                    nomina.CalcularNorturnidad().ToString("0.00"), txtConceptoOtrosIngresos.Text,
                    txtMontoOtrosIngresos.Text, nomina.CalcularPagoHorasExtras().ToString("0.00"), nomina.TotalIngresos().ToString("0.00"),
                    nomina.CalcularInss().ToString("0.00"), nomina.CalcularIR().ToString("0.00"),
                    txtConceptoOtrasDeducciones.Text, txtMontoOtrasDeducciones.Text, nomina.TotalDeducciones().ToString("0.00"),
                    nomina.SalarioNeto().ToString("0.00"));

                    

            }
        }

        private string Validar()
        {
            return "";
        }

        private void FechaContratacion_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            int yearstrabajados = (int)(fechaActual.Year - FechaContratacion.Value.Year);
            if (fechaActual < FechaContratacion.Value.AddYears(yearstrabajados))
            {
                yearstrabajados--;
            }

            nomina.YearsTrabajados = yearstrabajados;
            quincenal.YearsTrabajados = yearstrabajados;
        }



        public void CrearCargarFicheroDatosEmpleados()
        {
            if (!File.Exists("empleados.txt"))
            {
                StreamWriter archivo = new StreamWriter("empleados.txt");
                archivo.Close();
            }
            else
            {
                dgvDatosEmpleado.Rows.Clear(); // Limpia cualquier dato previo en el DataGridView.

                StreamReader archivo = new StreamReader("empleados.txt");

                while (!archivo.EndOfStream)
                {
                    string linea = archivo.ReadLine();
                    string[] datos = linea.Split(','); // Supongo que los datos en el archivo est�n separados por comas.

                    if (datos.Length == 18)
                    {
                        string NoEmpleado = datos[0];
                        string Cedula = datos[1];
                        string NoInss = datos[2];
                        string NoRuc = datos[3];
                        string PNombre = datos[4];
                        string SNombre = datos[5];
                        string PApellido = datos[6];
                        string SApellido = datos[7];
                        string Nacimiento = datos[8];
                        string sexo = datos[9];
                        string civil = datos[10];
                        string direccion = datos[11];
                        string telefono = datos[12];
                        string celular = datos[13];
                        string InicioContrato = datos[14];
                        string CierreContrato = datos[15];
                        string Salario = datos[16];
                        string Estado = datos[17];

                        dgvDatosEmpleado.Rows.Add(NoEmpleado, Cedula, NoInss, NoRuc, PNombre, SNombre, PApellido, SApellido, Nacimiento,
                            sexo, civil, direccion, telefono, celular, InicioContrato, CierreContrato, Salario, Estado);
                    }
                }

                archivo.Close();
            }

        }

        private void GrabarDatosEmpleados()
        {
            StreamWriter archivo = new StreamWriter("empleados.txt", true);

            string datos = $"{txtNoEmpleado.Text},{txtCedula.Text},{txtInss.Text},{txtRuc.Text},{txtPrimerNombre.Text},{txtSegundoNombre.Text}," +
                $"{txtPrimerApellido.Text},{txtSegundoApellido.Text},{FechaNacimiento.Text},{cboSexo.Text},{cboEstadoCivil.Text},{txtDireccion.Text}," +
                $"{txtTelefono.Text},{txtCelular.Text},{FechaContratacion.Text},{FechaCierreContrato.Text},{txtSalarioBase.Text},{cboEstadoEmpleado.Text}";

            archivo.WriteLine(datos);
            archivo.Close();
        }


        private void GrabarBorradoEmpleados()
        {
            try
            {
                StreamWriter archivo = new StreamWriter("empleados.txt");

                for (int i = 0; i < dgvDatosEmpleado.Rows.Count; i++)
                {
                    string aux1 = dgvDatosEmpleado.Rows[i].Cells[0].Value?.ToString();
                    string aux2 = dgvDatosEmpleado.Rows[i].Cells[1].Value?.ToString();
                    string aux3 = dgvDatosEmpleado.Rows[i].Cells[2].Value?.ToString();
                    string aux4 = dgvDatosEmpleado.Rows[i].Cells[3].Value?.ToString();
                    string aux5 = dgvDatosEmpleado.Rows[i].Cells[4].Value?.ToString();
                    string aux6 = dgvDatosEmpleado.Rows[i].Cells[5].Value?.ToString();
                    string aux7 = dgvDatosEmpleado.Rows[i].Cells[6].Value?.ToString();
                    string aux8 = dgvDatosEmpleado.Rows[i].Cells[7].Value?.ToString();
                    string aux9 = dgvDatosEmpleado.Rows[i].Cells[8].Value?.ToString();
                    string aux10 = dgvDatosEmpleado.Rows[i].Cells[9].Value?.ToString();
                    string aux11 = dgvDatosEmpleado.Rows[i].Cells[10].Value?.ToString();
                    string aux12 = dgvDatosEmpleado.Rows[i].Cells[11].Value?.ToString();
                    string aux13 = dgvDatosEmpleado.Rows[i].Cells[12].Value?.ToString();
                    string aux14 = dgvDatosEmpleado.Rows[i].Cells[13].Value?.ToString();
                    string aux15 = dgvDatosEmpleado.Rows[i].Cells[14].Value?.ToString();
                    string aux16 = dgvDatosEmpleado.Rows[i].Cells[15].Value?.ToString();
                    string aux17 = dgvDatosEmpleado.Rows[i].Cells[16].Value?.ToString();
                    string aux18 = dgvDatosEmpleado.Rows[i].Cells[17].Value?.ToString();

                    if (!string.IsNullOrEmpty(aux1) && !string.IsNullOrEmpty(aux2) && !string.IsNullOrEmpty(aux3) && !string.IsNullOrEmpty(aux4)
                        && !string.IsNullOrEmpty(aux5) && !string.IsNullOrEmpty(aux6) && !string.IsNullOrEmpty(aux7) && !string.IsNullOrEmpty(aux8)
                        && !string.IsNullOrEmpty(aux9) && !string.IsNullOrEmpty(aux10) && !string.IsNullOrEmpty(aux11) && !string.IsNullOrEmpty(aux12)
                        && !string.IsNullOrEmpty(aux13) && !string.IsNullOrEmpty(aux14) && !string.IsNullOrEmpty(aux15) && !string.IsNullOrEmpty(aux16)
                        && !string.IsNullOrEmpty(aux17) && !string.IsNullOrEmpty(aux18))
                    {
                        string linea = $"{aux1},{aux2},{aux3},{aux4},{aux5},{aux6},{aux7},{aux8},{aux9},{aux10},{aux11},{aux12},{aux13},{aux14},{aux15},{aux16},{aux17},{aux18}";
                        archivo.WriteLine(linea);
                    }

                    
                }
                archivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en el archivo: " + ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatosEmpleado.CurrentRow.Index != -1)
            {
                dgvDatosEmpleado.Rows.RemoveAt(this.dgvDatosEmpleado.CurrentRow.Index);
                MessageBox.Show("Se borro a la persona");
                GrabarBorradoEmpleados();
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

            if (txtHorasExtras.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
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
            int maxLength = 5;

            if (txtMontoOtrosIngresos.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
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
            int maxLength = 5;

            if (txtMontoOtrasDeducciones.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
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
            //if (e.KeyChar == (char)Keys.Back)
            //{
            //    e.Handled = false;
            //    return;
            //}

            //if (txtRuc.Text.Length >= 14)
            //{
            //    e.Handled = true;
            //    return;
            //}

            //if (txtRuc.Text.Length == 0)
            //{
            //    if (char.IsLetter(e.KeyChar) && char.IsUpper(e.KeyChar))
            //    {
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
            //else if (char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }




        private void cboTipoPlanilla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ExportarDataGridViewsAExcel(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            // Crear un cuadro de di�logo para guardar el archivo Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";
            saveFileDialog.FileName = "MiArchivo.xlsx"; // Nombre predeterminado del archivo



            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();

                ExportarDataGridViewAExcel(dataGridView1, workbook, "Hoja1");
                ExportarDataGridViewAExcel(dataGridView2, workbook, "Hoja2");

                // Guardar el archivo de Excel en la ubicaci�n seleccionada por el usuario
                workbook.SaveAs(rutaArchivo);
                workbook.Close();
                excelApp.Quit();

                // Liberar los recursos
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }

        private void ExportarDataGridViewAExcel(DataGridView dataGridView, Excel.Workbook workbook, string nombreHoja)
        {
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets.Add();



            // Copiar los encabezados de las columnas
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }

            // Copiar los datos del DataGridView
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewsAExcel(dgvDatosEmpleado, dgvNomina);
        }

        
    }
}