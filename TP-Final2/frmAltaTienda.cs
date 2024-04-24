using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP_Final2
{
    public partial class frmAltaTienda : Form
    {
        public frmAltaTienda()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // o close solo
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tienda art = new Tienda();
            TiendaNegocio negocio = new TiendaNegocio();
            try 
            {
                // capturar los datos que la persona cargue y trans en objeto tipo tienda
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Marca = (Elemento)cboMarca.SelectedItem;
                art.Categoria = (Elemento)cboCategoria.SelectedItem;

                //ahora lo tengo que mandar a la base de datos
                negocio.agregar(art);
                MessageBox.Show("Agregafo con exito");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaTienda_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementonegocio = new ElementoNegocio();
            try
            {
                // voy a la base de datos
               cboMarca.DataSource = elementonegocio.listarMarcas();
               cboCategoria.DataSource = elementonegocio.listarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
