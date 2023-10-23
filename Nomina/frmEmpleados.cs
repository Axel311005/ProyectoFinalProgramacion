using Modelo;

namespace Nomina
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();


        }




        string[] sexos = { "M", "F" };
        string[] EstadoCivil2 = { "Soltero", "Casado" };
        string[] estado2 = { "Activo", "No Activo" };
        string[] TipoPlanilla = { "Mensual", "Quincenal" };

        Nómina nomina = new Nómina();
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


        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            EnviarObjetos();


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


    }
}