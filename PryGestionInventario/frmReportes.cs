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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }
        clsBD ObjConexion = new clsBD();    
        private void frmReportes_Load(object sender, EventArgs e)
        {
            ObjConexion.listarStockxCategoria(chCategoria);
            ObjConexion.listarStockxProducto(chProducto);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObjConexion.listarStockxCategoria(chCategoria);
            ObjConexion.listarStockxProducto(chProducto);
            ObjConexion.ReporteStock();
        }
    }
}
