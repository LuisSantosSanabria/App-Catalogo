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
                art.Marca = (Marca)cboMarca.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                // Mapear para agregar una imagen nueva del articulo
                art.ImagenUrl = txtImagenUrl.Text;

                //ahora lo tengo que mandar a la base de datos
                negocio.agregar(art);
                MessageBox.Show("Agregado con exito");
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

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void cargarImagen(string imagen) //para capturar exepciones
        {
            try
            {
                pbxTienda.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxTienda.Load("https://lmgd.co.uk/wp-content/uploads/2016/12/Gallery-Icon.jpg");
            }
        }
    }
}
