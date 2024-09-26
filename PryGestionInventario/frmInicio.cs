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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        clsBD ObjConexion = new clsBD();    
        private void frmInicio_Load(object sender, EventArgs e)
        {
            ObjConexion.Listar(dgvRegistro);
        }
    }
}
