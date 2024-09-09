using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionInventario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAME frm = new frmAME(); 
            frm.ShowDialog();  
        }

        

        private void busquedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedad frm = new frmBusquedad();
            frm.ShowDialog();
        }
    }
}
