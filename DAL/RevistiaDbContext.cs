using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL
{
    public class RevistiaDbContext : DbContext
    {
        public RevistiaDbContext()
        //: base("Data Source=localhost\\sqlExpress;Initial Catalog=Revistia;Integrated Security=True;")
        : base("name=RevistiaContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
