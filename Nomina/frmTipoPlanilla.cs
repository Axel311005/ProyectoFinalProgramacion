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
    public partial class frmTipoPlanilla : Form
    {
        public frmTipoPlanilla()
        {
            InitializeComponent();
        }

        private void btnMensual_Click(object sender, EventArgs e)
        {
            frmNominaMensual mensual = new frmNominaMensual();
            mensual.ShowDialog();
        }

        private void btnQuincenal_Click(object sender, EventArgs e)
        {
            frmNominaQuincenal quincenal = new frmNominaQuincenal();
            quincenal.ShowDialog();
        }
    }
}
