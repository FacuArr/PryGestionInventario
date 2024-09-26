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
        clsBD ObjConexion = new clsBD();    

        private void AbrirFormulario<Miform>() where Miform : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<Miform>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnAEM_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAME>();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBusquedad>();    
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario<frmInicio>();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmInicio>();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmReportes>();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
