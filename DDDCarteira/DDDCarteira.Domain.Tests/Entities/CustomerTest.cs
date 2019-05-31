using DDDCarteira;
using DDDCarteira.Domain.Account.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DDDCarteira.Domain.Tests.Financial
{
    class CustomerTest  {

        public void CriarUsuario(){

            var customer = new Customer("Univem", "444444444", "univem@univem.com", "99999-9999");

            customer.Active = true;
        }

        public void Adicionar(){
            var customer2 = new Customer("", "555555555", "uol@uol.com", "988888888");
        }
    }
}
