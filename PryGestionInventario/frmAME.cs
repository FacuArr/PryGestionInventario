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
    public partial class frmAME : Form
    {
        public frmAME()
        {
            InitializeComponent();
        }
        clsProducto producto = new clsProducto();  
        clsBD ObjConexion = new clsBD();    
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.Categoria = txtCategoria.Text;
            if (dgvRegistro.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(txtID.Text);
                if (id != null)
                {
                    producto.ID = id;
                    ObjConexion.actualizarProducto(producto);
                    ObjConexion.Listar(dgvRegistro);
                }
            }
            else
            {
                ObjConexion.insertarProducto(producto);
                ObjConexion.Listar(dgvRegistro);
            }
        }

        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["ID"].Value);
            txtNombre.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Nombre"].Value);
            txtDescripcion.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Descripcion"].Value);
            txtPrecio.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Precio"].Value);
            txtStock.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Stock"].Value);
            txtCategoria.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Categoria"].Value);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCategoria.Clear();
            dgvRegistro.CurrentCell = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvRegistro.CurrentRow.Cells["ID"].Value);
                ObjConexion.eliminarProducto(id);

            }
            ObjConexion.Listar(dgvRegistro);
        }

        private void frmAME_Load(object sender, EventArgs e)
        {
            ObjConexion.Listar(dgvRegistro);
            
        }

       
    }
}
