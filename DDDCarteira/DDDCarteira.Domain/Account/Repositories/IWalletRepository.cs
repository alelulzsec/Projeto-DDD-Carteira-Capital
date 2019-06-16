using DDDCarteira.Domain.Account.Entities; /*Referencia para Entities*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Domain.Account.Repositories{
   public interface IWalletRepository {

        void Save(Wallet wallet);
        IEnumerable<Wallet> GetWallets();
        Wallet GetParcelByCode(string code);
        IEnumerable<Wallet> GetWalletsByCustomer(Guid id);
        IEnumerable<Wallet> GetWalletsByBroker(Guid id);
        Wallet GetWalletByCode(string code);
        void Save(object wallet);
    }
}
