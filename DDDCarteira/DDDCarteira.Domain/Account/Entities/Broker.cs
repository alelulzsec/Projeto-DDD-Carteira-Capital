using DDDCarteira.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDCarteira.Domain.Account.ValueObjects;

namespace DDDCarteira.Domain.Account.Entities
{
    public class Broker : Entity {

        public Broker(
          
          string name,
          string cnpj,
          string email,
          string phone)
          
        {
            Name = name;
            CNPJ = cnpj;
            Email = email;
            Phone = phone;
        }
        public string Name { get; private set; }
        public string CNPJ { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Broker broker { get; private set; }


    }
}
