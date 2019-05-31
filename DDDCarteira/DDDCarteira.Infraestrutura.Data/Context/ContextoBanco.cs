using DDDCarteira.Domain.Account.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Infraestrutura.Data.Context
{
    class ContextoBanco : DbContext
    {

        public ContextoBanco() : base("ProjetoDDDCarteiraContext")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public DbSet<ModulosAcesso> modulosAcessos { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder){

            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvertion>; //remove quando é muito pra muitos;

        }

    }
}
