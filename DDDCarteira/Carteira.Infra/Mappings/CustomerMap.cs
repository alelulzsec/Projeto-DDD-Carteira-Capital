using DDDCarteira;
using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<DDDCarteira.Domain.Account.Entities.Customer>
    {
        public CustomerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Document).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Phone).IsRequired().HasMaxLength(11).IsFixedLength();

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
