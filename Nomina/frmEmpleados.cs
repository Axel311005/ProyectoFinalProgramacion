using Modelo;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Modelo;
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
        }
        string[] sexos = { "M", "F" };
        string[] EstadoCivil2 = { "Soltero", "Casado" };
        string[] estado2 = { "Activo", "No Activo" };


        Nómina nomina = new Nómina();
        NominaQuincenal quincenal = new NominaQuincenal();


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
            quincenal.OtrosIngresos = double.Parse(txtMontoOtrasDeducciones.Text);
            quincenal.OtrasDeducciones = double.Parse(txtMontoOtrasDeducciones.Text);
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cboEstadoCivil.DataSource = EstadoCivil2;
            cboEstadoEmpleado.DataSource = estado2;
            cboSexo.DataSource = sexos;
            dgvDatosEmpleado.RowTemplate.Height = 20;
            CrearCargarFicheroDatosEmpleados();

        }


        public void Agregar()
        {
            if (Validar() == "")
            {
                EnviarObjetos();
                GrabarDatosEmpleados();
                GrabarDatosNominaMensual();
                GrabarDatosNominaQuincenal();
                AgregarDataEmpleado();

            }
        }
        public void AgregarDataEmpleado()
        {
            dgvDatosEmpleado.Rows.Add(txtNoEmpleado.Text, txtCedula.Text, txtInss.Text, txtRuc.Text,
                   txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text,
                   txtSegundoApellido.Text, FechaNacimiento.Text, cboSexo.Text, cboEstadoCivil.Text,
                   txtDireccion.Text, txtTelefono.Text, txtTelefono.Text, FechaContratacion.Text
                   , FechaCierreContrato.Text, txtSalarioBase.Text, cboEstadoEmpleado.Text);

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
                    string[] datos = linea.Split(','); // Supongo que los datos en el archivo están separados por comas.

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
                $"{txtTelefono.Text},{txtTelefono.Text},{FechaContratacion.Text},{FechaCierreContrato.Text},{txtSalarioBase.Text},{cboEstadoEmpleado.Text}";

            archivo.WriteLine(datos);
            archivo.Close();
        }


        private void GrabarDatosNominaMensual()
        {
            StreamWriter archivo = new StreamWriter("NominaMensual.txt", true);

            string datos = $"{txtNoEmpleado.Text},{txtPrimerNombre.Text},{txtSegundoNombre.Text}," +
                $"{txtPrimerApellido.Text},{txtSegundoApellido.Text},{nomina.SalarioBase},{nomina.CalcularAntiguedad().ToString("0.00")},{nomina.CalcularRiesgoLaboral().ToString("0.00")},{nomina.CalcularNorturnidad().ToString("0.00")}" +
                $",{txtConceptoOtrosIngresos.Text},{nomina.OtrosIngresos},{nomina.CalcularPagoHorasExtras().ToString("0.00")},{nomina.TotalIngresos().ToString("0.00")},{nomina.CalcularInss().ToString("0.00")},{nomina.CalcularIR().ToString("0.00")},{txtConceptoOtrasDeducciones.Text}" +
                $",{nomina.OtrasDeducciones},{nomina.TotalDeducciones().ToString("0.00")},{nomina.SalarioNeto().ToString("0.00")}";

            archivo.WriteLine(datos);
            archivo.Close();
        }

        private void GrabarDatosNominaQuincenal()
        {
            StreamWriter archivo = new StreamWriter("NominaQuincenal.txt", true);

            string datos = $"{txtNoEmpleado.Text},{txtPrimerNombre.Text},{txtSegundoNombre.Text}," +
                $"{txtPrimerApellido.Text},{txtSegundoApellido.Text},{quincenal.SalarioQuincenal().ToString("0.00")},{quincenal.CalcularAntiguedad().ToString("0.00")},{quincenal.CalcularRiesgoLaboral().ToString("0.00")},{quincenal.CalcularNorturnidad().ToString("0.00")}" +
                $",{txtConceptoOtrosIngresos.Text},{quincenal.OtrosIngresos},{quincenal.CalcularPagoHorasExtras().ToString("0.00")},{quincenal.TotalIngresos().ToString("0.00")},{quincenal.CalcularInss().ToString("0.00")},{quincenal.CalcularIR().ToString("0.00")},{txtConceptoOtrasDeducciones.Text}" +
                $",{quincenal.OtrasDeducciones},{quincenal.TotalDeducciones().ToString("0.00")},{quincenal.SalarioNeto().ToString("0.00")}";

            archivo.WriteLine(datos);
            archivo.Close();
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

            if (txtTelefono.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
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

            if (txtMontoOtrasDeducciones.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
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









        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void BtnExportar_Click_1(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvDatosEmpleado);
        }


        private void BtnCalcula_Click(object sender, EventArgs e)
        {




        }
    }

}