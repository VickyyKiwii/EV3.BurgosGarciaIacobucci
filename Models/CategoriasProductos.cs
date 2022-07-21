using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductoCategoria.Models
{
    public partial class CategoriasProductos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoriasProductos()
        {
            this.Producto = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}