using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Migrations
{
    class Configuration : DbMigrationsConfiguration<Carteira.Infra.Contexts.StoreDataContext>{

        public Configuration()
        {
            AutomaticMigrationsEnable = false;
        }

        protected override void Seed(Carteira.Infra.Contexts.StoreDataContext context)
        {

            // Esse método será chamado após a migração para a versão mais recente.

            // Você pode usar o método de extensão de ajuda DbSet <T> .AddOrUpdate ()
            // para evitar a criação de dados duplicados.
        }

        public bool AutomaticMigrationsEnable { get; }
    }
}
