using Carteira.Infra.Contexts;
using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.Repositories;
using DDDCarteira.Domain.Account.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Infra.Repositories
{
    public class WalletRepository : IWalletRepository 
    {
        private readonly StoreDataContext _context;

        public WalletRepository(StoreDataContext context)
        {
            _context = context;
        }

        public Wallet GetParcelByCode(string code)
        {
            return _context.Wallets.Find(BuyDate);
        }

        public void Save(Wallet wallet)
        {
            _context.Wallet.Add(wallet);
            _context.SaveChanges();
        }

        public IEnumerable<Wallet> GetParcels()
        {
            return _context.Wallet.ToList();
        }
        public void Delete(string BuyDate)
        {
            var wallet = _context.Wallet.Find(BuyDate);

            _context.Wallet.Remove(wallet);
            _context.SaveChanges();
        }

        void IWalletRepository.Save(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Wallet> IWalletRepository.GetWallets()
        {
            throw new NotImplementedException();
        }

        Wallet IWalletRepository.GetParcelByCode(string code)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Wallet> IWalletRepository.GetWalletsByCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Wallet> IWalletRepository.GetWalletsByBroker(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
