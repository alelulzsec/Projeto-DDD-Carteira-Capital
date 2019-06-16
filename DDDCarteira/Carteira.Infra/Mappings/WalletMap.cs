using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Mappings
{
   public class WalletMap : EntityTypeConfiguration<DDDCarteira.Domain.Account.Entities.Wallet>{

        public WalletMap()
        {
            HasKey(x => x.Id);
            Property(x => x.BuyDate).IsRequired().HasMaxLength(11).IsFixedLength();

            HasRequired(x => x.Broker);

        }

        private void HasRequired(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        private object Property(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        private void HasKey(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
