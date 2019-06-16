using DDDCarteira;
using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Contexts
{
    public class StoreDataContext : DbContext{

        public StoreDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StoreDB; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Broker> Brokers { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DbSet<Wallet> Wallets { get; set; }
        public object Configuration { get; }
        public object Wallet { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new BrokerMap());
            modelBuilder.Configurations.Add(new WalletMap());
        }


    }

    internal class CustomerMap
    {
        public CustomerMap()
        {
        }
    }

    internal class WalletMap
    {
        public WalletMap()
        {
        }
    }

    internal class BrokerMap
    {
        public BrokerMap()
        {
        }
    }
}
