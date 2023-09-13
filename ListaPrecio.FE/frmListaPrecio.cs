using ListaPrecio.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPrecio.FE
{
    public partial class frmListaPrecio : Form
    {
        public frmListaPrecio()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();

            prod.Agregar(txtCodigo.Text,
                         txtNombre.Text,
                         txtPrecio.Text);

            lblResultado.Text = prod.Listar();
        }
    }
}
