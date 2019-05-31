using DDDCarteira.Shared.Entities;
using DDDCarteira.Domain.Account.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Domain.Account.Entities
{
   public class Wallet : Entity{
        private BuyDate buyDate;

        public Wallet(BuyDate buyDate)
        {
            this.buyDate = buyDate;
        }

        public Wallet(
           BuyDate buyDate,
           Shopping shopping,
           Broker broker,
           Customer customer)
        {
            BuyDate= buyDate;
            Shopping = shopping;
            Broker = broker;
            Customer = customer;
        }

        public BuyDate BuyDate { get; private set; }
        public Shopping Shopping { get; private set; }
        public Broker Broker { get; private set; }
        public Customer Customer { get; private set; }
        
    }
}
