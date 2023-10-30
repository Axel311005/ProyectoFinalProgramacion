using Modelo;
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
    public partial class frmNominaQuincenal : Form
    {
        public frmNominaQuincenal()
        {
            InitializeComponent();
        }

        private void frmNominaQuincenal_Load(object sender, EventArgs e)
        {
            CrearCargarFicheroDatosNominaQuincenal();
        }


        public void CrearCargarFicheroDatosNominaQuincenal()
        {
            if (!File.Exists("NominaQuincenal.txt"))
            {
                StreamWriter archivo = new StreamWriter("NominaQuincenal.txt");
                archivo.Close();
            }
            else
            {
                dgvNomina.Rows.Clear(); // Limpia cualquier dato previo en el DataGridView.

                StreamReader archivo = new StreamReader("NominaQuincenal.txt");

                while (!archivo.EndOfStream)
                {
                    string linea = archivo.ReadLine();
                    string[] datos = linea.Split(','); // Supongo que los datos en el archivo están separados por comas.

                    if (datos.Length == 19)
                    {
                        string NoEmpleado = datos[0];
                        string PNombre = datos[1];
                        string SNombre = datos[2];
                        string PApellido = datos[3];
                        string SApellido = datos[4];
                        string SalarioBase = datos[5];
                        string Antiuedad = datos[6];
                        string RiesLaboral = datos[7];
                        string Noctunidad = datos[8];
                        string ConceptoOI = datos[9];
                        string MontoOI = datos[10];
                        string extras = datos[11];
                        string TotalIn = datos[12];
                        string inss = datos[13];
                        string ir = datos[14];
                        string ConceptoOD = datos[15];
                        string MontoOD = datos[16];
                        string totaldeduc = datos[17];
                        string SalarioNeto = datos[18];

                        dgvNomina.Rows.Add(NoEmpleado, PNombre, SNombre, PApellido, SApellido, SalarioBase,
                            Antiuedad, RiesLaboral, Noctunidad, ConceptoOI, MontoOI, extras, TotalIn, inss, ir, ConceptoOD, MontoOD, totaldeduc, SalarioNeto);
                    }
                }

                archivo.Close();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvNomina);
        }
    }
}
