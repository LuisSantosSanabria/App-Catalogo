using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //invoco la lectura de BD
            TiendaNegocio negocio = new TiendaNegocio();
            listaTienda = negocio.listar();
            dgvTienda.DataSource = listaTienda;
            dgvTienda.Columns["ImagenUrl"].Visible = false;
            // lee las prperty y las convierte en columnas
            cargarImagen(listaTienda[0].ImagenUrl); //cargar imagen encapsulamineto

        }

        private void dgvTienda_SelectionChanged(object sender, EventArgs e)
        {
            //tomom el elemeto seleccionado de la frilla
            Tienda seleccionado = (Tienda)dgvTienda.CurrentRow.DataBoundItem; //de la fila,dame, el objeto enlazado lo guardo en seleccinado
            cargarImagen(seleccionado.ImagenUrl);
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
