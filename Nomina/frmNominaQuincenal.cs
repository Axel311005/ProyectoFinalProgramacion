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
using static System.Windows.Forms.DataFormats;

namespace Nomina
{
    public partial class frmNominaQuincenal : Form
    {
        public frmNominaQuincenal()
        {
            InitializeComponent();
        }



       

        private void BtnExportarM_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            excel.ExportarAExcel(dgvNomina);

        }

        private void frmNominaQuincenal_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
