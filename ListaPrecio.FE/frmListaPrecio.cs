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
        private Productos ListaProducto = new Productos();

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

            ListaProducto.Agregar(prod);

            MostrarLista();
        }

        private void MostrarLista()
        {
            lblResultado.Text = ListaProducto.Listar();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Producto prod = ListaProducto.Buscar(txtCodigo.Text);

            if(prod==null)
            {
                lblResultado.Text = "No se encontró el producto";
            }
            else
            {
                txtNombre.Text= prod.Nombre;
                txtPrecio.Text = prod.Precio.ToString();
                lblResultado.Text = "";
            }
        }
    }
}
