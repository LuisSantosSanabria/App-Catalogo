using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Elemento
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
        public int IdC { get; set; }
        public string DescripcionC { set; get; }
        public override string ToString()
        {
            return DescripcionC;
        }
    }
}
