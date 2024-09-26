using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            if (txtNombre.Text != "" & txtDescripcion.Text != "" & txtPrecio.Text != "" & txtStock.Text != "" & txtCategoria.Text != "")
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
                        DialogResult l = MessageBox.Show("¿Seguro que desea modificar el producto seleccionado?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (l == DialogResult.Yes)
                        {
                            producto.ID = id;
                            ObjConexion.actualizarProducto(producto);
                            ObjConexion.Listar(dgvRegistro);
                            ObjConexion.ReporteStock();
                        }
                    }
                }
                else
                {
                    DialogResult l = MessageBox.Show("¿Seguro que desea agregar este producto?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (l == DialogResult.Yes)
                    {
                        ObjConexion.insertarProducto(producto);
                        ObjConexion.Listar(dgvRegistro);
                        ObjConexion.ReporteStock();
                    }
                }
            }
            else
            {
                MessageBox.Show("Algun campo no está lleno, verifique porfavor", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvRegistro.CurrentCell = null;
            txtID.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCategoria.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRegistro.SelectedRows.Count == 1)
            {
                DialogResult l = MessageBox.Show("¿Seguro que desea eliminar el producto seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (l == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvRegistro.CurrentRow.Cells["ID"].Value);
                    ObjConexion.eliminarProducto(id);
                    ObjConexion.Listar(dgvRegistro);
                }
            }
        }

        private void frmAME_Load(object sender, EventArgs e)
        {
            ObjConexion.Listar(dgvRegistro);
            dgvRegistro.CurrentCell = null;
        }

        private void dgvRegistro_SelectionChanged_1(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["ID"].Value);
            txtNombre.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Nombre"].Value);
            txtDescripcion.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Descripcion"].Value);
            txtPrecio.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Precio"].Value);
            txtStock.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Stock"].Value);
            txtCategoria.Text = Convert.ToString(dgvRegistro.CurrentRow.Cells["Categoria"].Value);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) && (e.KeyChar != 44) && (e.KeyChar != 127))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  
                e.Handled = true;   
                return;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
