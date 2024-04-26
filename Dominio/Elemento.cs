using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;

        }

    }
    public class Categoria
    {
        // elementos de categoria
        public int Id { get; set; }
        public string Descripcion { set; get; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
