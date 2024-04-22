using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final2
{
    internal class Tienda // MI claase base del objeto que voy a manipular en mi app
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
      //  public Elemento Tipo { get; set; }
        public Elemento Marca { get; set; }
    }
}
