using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;
using System.Globalization;

namespace TP_Final2
{
    public partial class frmAltaTienda : Form
    {
        private Tienda tienda = null; // cuando toque modificar ya voy a tener un articulo caragdo
        private OpenFileDialog archivo = null; 
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
        private bool ValidarAgregar()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text)) 
            {
                ControlPaint.DrawBorder(txtCodigo.CreateGraphics(), txtCodigo.ClientRectangle, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid);
                ControlPaint.DrawBorder(txtNombre.CreateGraphics(), txtNombre.ClientRectangle, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid);
                ControlPaint.DrawBorder(txtDescripcion.CreateGraphics(), txtDescripcion.ClientRectangle, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid, Color.Red, 2, ButtonBorderStyle.Solid);
               
                return false;
            }
            else
            {
                RestaurarBordes();
                return true;
            }

            // Validación del precio
           // if (!decimal.TryParse(txtPrecio.Text, out _))
           // {
           //     return false; // Devolver falso si el precio no es válido
           // }

            // Si todas las validaciones pasan, devolver verdadero
           // return true;
        }

        private void RestaurarBordes()
        {
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.BackColor = SystemColors.Window;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.BackColor = SystemColors.Window;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.BackColor = SystemColors.Window;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Tienda art = new Tienda(); //crea un nuevo articulo
            TiendaNegocio negocio = new TiendaNegocio();
            try 
            {
                if (!ValidarAgregar()) //si la validacion falla se ejecuta el if
                {
                    return;
                }
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
                try
                {
                    tienda.precio = Convert.ToDecimal(txtPrecio.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese solo numeros.");
                    return; //sale sin continuar
                }

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
                //guardo imagen si levanto localmente
                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))  // si el archivo es distinto de nulo y no tiene htto entonces
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName); // me aseguro que tengo q guardar una imagen local
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
                    txtPrecio.Text = tienda.precio.ToString();
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

        private void pbxTienda_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de imagen JPEG (*.jpg)|*.jpg|Archivos de imagen PNG (*.png)|*.png"; // "jpg|*.jpg"|png|*.png";
            // me guarda la ruta dl archivo seleccionado
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName; // lee el archivo y lo guardo en la caja de texto
                cargarImagen(archivo.FileName);

            }

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
