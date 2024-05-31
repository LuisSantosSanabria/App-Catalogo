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
    public partial class Form1 : Form
    {
        private List<Tienda> listaTienda; // los datos de la BD se guardan aca
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvTienda_SelectionChanged(object sender, EventArgs e)
        {
            //tomom el elemeto seleccionado de la frilla
            if (dgvTienda.CurrentRow != null) // para que no se rompa al busar y borrar la grilla
            {
                Tienda seleccionado = (Tienda)dgvTienda.CurrentRow.DataBoundItem; //de la fila,dame, el objeto enlazado lo guardo en seleccinado
                cargarImagen(seleccionado.ImagenUrl);
                lblDes.Text = seleccionado.Descripcion;
                lblNmbr.Text = seleccionado.Nombre;
            }
        }



        private void cargar()
        {
            try
            {
                //invoco la lectura de BD
                TiendaNegocio negocio = new TiendaNegocio();
                listaTienda = negocio.listar();
                //muestra todaaaaaaaa la informacion
                dgvTienda.DataSource = listaTienda;
                ocultarColumnas();
                // lee las prperty y las convierte en columnas
                cargarImagen(listaTienda[0].ImagenUrl); //cargar imagen encapsulamineto
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvTienda.Columns["ImagenUrl"].Visible = false;
            dgvTienda.Columns["Id"].Visible = false;
            dgvTienda.Columns["Precio"].Visible = false;
            dgvTienda.Columns["Descripcion"].Visible = false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // para saltar a la otra ventana
            frmAltaTienda alta = new frmAltaTienda();
            alta.ShowDialog();
            //actulizar la crga
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // le paso por parametro el objeto que voy a modificar

            Tienda seleccionado;
            seleccionado = (Tienda)dgvTienda.CurrentRow.DataBoundItem;

            frmAltaTienda modificar = new frmAltaTienda(seleccionado); //este recibe un prodcuto
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TiendaNegocio negocio = new TiendaNegocio();
            Tienda seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Eliminar el Articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // me guardo la rspt
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Tienda)dgvTienda.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            // se actuliza el filtro con cada tecla que aprieta text changed
            List<Tienda> listaFiltrada; // por eso no creo lista y creo la variable vacia
            string filtro = txtFiltro.Text;
            if (filtro.Length >= 3) //me filtra cuando es mayor a 3 caracteres
            {
                listaFiltrada = listaTienda.FindAll(x => x.Codigo.ToLower().Contains(filtro.ToLower()) || x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper())); // fidAll me devuelve un onjeto // devuelve una lista
            }                                                         // si tiene una coincidencia
            else // sino tengo filtro me pone la lista original
            {
                listaFiltrada = listaTienda;
            }
            dgvTienda.DataSource = null;
            dgvTienda.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void lblPrueba_Click(object sender, EventArgs e)
        {

        }
    }
}