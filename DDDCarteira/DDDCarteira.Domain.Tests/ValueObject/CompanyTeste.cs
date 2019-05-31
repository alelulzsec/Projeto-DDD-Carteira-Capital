using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDCarteira.Domain.Account.ValueObjects;
using DDDCarteira.Domain.Account.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DDDCarteira.Domain.Tests.ValueObject
{
   public class CompanyTeste{

        public void RetornaDataCompravazia(){
            var dataCompra = new BuyDate("", "00/00/0000");
            Assert.IsTrue(dataCompra.Valid);
        }
    }
}



