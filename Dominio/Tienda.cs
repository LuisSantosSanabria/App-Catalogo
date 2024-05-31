using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tienda // MI claase base del objeto que voy a manipular en mi app
    {
        public int Id { get; set; }
        [DisplayName("Código")] // anoation
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        private decimal _precio;
        [DisplayName("Precio-")]
        public decimal precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        [DisplayName("Precio ")]
        public string PrecioFinal
        {
            get { return _precio.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")); }
        }

        public string ImagenUrl { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
