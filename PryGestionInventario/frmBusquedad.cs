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
    public partial class frmBusquedad : Form
    {
        public frmBusquedad()
        {
            InitializeComponent();
        }
        clsBD ObjConexion = new clsBD();   
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            ObjConexion.buscarProducto(Nombre, dgvRegistro);
        }

        private void optNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCodigo.Enabled = false;
            txtCategoria.Enabled = false;
           
        }
       
        private void optCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtCategoria.Enabled = false;
            
        }

        private void optCategoria_CheckedChanged(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
            txtNombre.Enabled = false;
            txtCodigo.Enabled = false;
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                ObjConexion.buscarProducto(codigo, dgvRegistro);
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text;  
            ObjConexion.buscarProductoCat(categoria,dgvRegistro);  
        }
    }
}
