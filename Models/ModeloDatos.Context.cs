using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ProductoCategoria.Models
{
    public partial class servicioEntities1 : DbContext
    {
        public servicioEntities1()
           : base("name=servicioEntities1")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        
    }
}