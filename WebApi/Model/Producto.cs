using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Producto
    {

        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Identificador { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }

    }
}
