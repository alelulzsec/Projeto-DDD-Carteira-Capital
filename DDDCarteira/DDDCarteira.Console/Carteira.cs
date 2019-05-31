using DDDCarteira;
using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.Repositories;
using DDDCarteira.Domain.Account.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Console
{
    class Carteira
    {
        static void Main(string[] args){
            var fakeCustomerRepository = new FakeCustomerRepository();
            var fakerBrokerRepository = new FakeBrokerRepository();
            GenerateWallet(fakeCustomerRepository, fakerBrokerRepository);
        }
        public static void GenerateWallet(ICustomerRepository customerRepository,
            IBrokerRepository brokerRepository){

            var customer = customerRepository.GetById(Guid.NewGuid());
            var broker = brokerRepository.GetbyId(Guid.NewGuid());
            var wallet = new Wallet(
              new BuyDate(new DateTime(20190909), new DateTime(20190912)));
        }

        public class FakeCustomerRepository : ICustomerRepository { 
           public Customer GetById(Guid id){
                var customerFake = new Customer
                  (
                    "José",
                    "5555555555",
                    "email@email.com",
                    "14988888888"
                   );
                  return customerFake;
           }
            public IEnumerable<Customer> GetCustomers(){
                throw new NotImplementedException();
            }
            public void Save(Customer customer){
                throw new NotImplementedException();
            }
        }
        public class FakeBrokerRepository : IBrokerRepository{
            public Broker GetById(Guid id){
                var brokerFake = new Broker(
                    "XP",
                    "11111111111",
                    "xp@xp.com",
                    "2134544852"
                 );
                return brokerFake;
            }
            public IEnumerable<Broker> GetBrokers(){
                throw new NotImplementedException();
            }

            public void Save(Broker broker){
                throw new NotImplementedException();
            }

            public Broker GetById()
            {
                throw new NotImplementedException();
            }

            public object GetbyId(Guid guid)
            {
                throw new NotImplementedException();
            }
        }

        public class FakeWalletRepository : IWalletRepository{
            public Wallet GetWalletBydataRegistro(string dataRegistro){
                var fakeCustomerRepository = new FakeCustomerRepository();
                var fakerBrokerRepository = new FakeBrokerRepository();
                var customer = customerRepository.GetById(Guid.NewGuid());
                var broker = brokerRepository.GetbyId(Guid.NewGuid());
                var wallet = new Wallet(
                    new BuyDate(new DateTime(20190909), new DateTime(20190912)));
                return walletFake;
            }
            public IEnumerable<Wallet> GetWalletByWallets(){
                throw new NotImplementedException();
            }
            public IEnumerable<Wallet> GetWalletByBroker(Guid id){
                throw new NotImplementedException();
            }
            public IEnumerable<Wallet> GetWalletByCustomer(Guid id){
                throw new NotImplementedException();
            }
            public void Save(Wallet wallet){
                throw new NotImplementedException();
            }

            public IEnumerable<Wallet> GetWallets()
            {
                throw new NotImplementedException();
            }

            public Wallet GetParcelByCode(string code)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<Wallet> GetWalletsByCustomer(Guid id)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<Wallet> GetWalletsByBroker(Guid id)
            {
                throw new NotImplementedException();
            }
        }
     }

}

