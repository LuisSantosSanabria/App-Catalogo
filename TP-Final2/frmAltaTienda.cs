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
        private Tienda tienda = null; // cuando toque modificar ya voy a tener un articulo caragdo
        public frmAltaTienda()
        {
            InitializeComponent();
        }
        public frmAltaTienda(Tienda tienda) // articulo ya cargado
        {
            InitializeComponent();
            this.tienda = tienda;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // o close solo
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Tienda art = new Tienda(); //crea un nuevo articulo
            TiendaNegocio negocio = new TiendaNegocio();
            try 
            {
                if (tienda == null)
                    tienda = new Tienda(); //si el artiulo esta nuelo estonces cargo los datos

                // capturar los datos que la persona cargue y trans en objeto tipo tienda
                tienda.Codigo = txtCodigo.Text;
                tienda.Nombre = txtNombre.Text;
                tienda.Descripcion = txtDescripcion.Text;
                tienda.Marca = (Marca)cboMarca.SelectedItem;
                tienda.Categoria = (Categoria)cboCategoria.SelectedItem;
                // Mapear para agregar una imagen nueva del articulo
                tienda.ImagenUrl = txtImagenUrl.Text;

                //como se cual de los dos(A/M) tiene que elegir
                if (tienda.Id != 0)
                {
                    //ahora lo tengo que mandar a la base de datos
                    negocio.modificar(tienda);
                    MessageBox.Show("Modificado con exito");
                }
                else
                {
                    negocio.agregar(tienda);
                    MessageBox.Show("Agregado con exito");
                }
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
               cboMarca.ValueMember = "Id";
               cboMarca.DisplayMember = "Descripcion";

               cboCategoria.DataSource = elementonegocio.listarCategorias();
               cboCategoria.ValueMember = "Id";
               cboCategoria.DisplayMember = "Descripcion";

                if (tienda != null) // quiere decir que tengo un articulo para modificar
                {
                    txtCodigo.Text = tienda.Codigo;
                    txtNombre.Text = tienda.Nombre;
                    txtDescripcion.Text = tienda.Descripcion;
                    txtImagenUrl.Text = tienda.ImagenUrl;
                    cargarImagen(tienda.ImagenUrl);
                    cboMarca.SelectedValue = tienda.Marca.Id; // me preseleccionado los valores que tiene el articulo que elija
                    cboCategoria.SelectedValue = tienda.Categoria.Id;

                }
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
