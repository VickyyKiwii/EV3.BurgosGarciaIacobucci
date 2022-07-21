using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductoCategoria.Models
{
    public partial class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }
        public int idCategoria { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }

        public virtual CategoriasProductos CategoriaProducto { get; set; }

    }
}