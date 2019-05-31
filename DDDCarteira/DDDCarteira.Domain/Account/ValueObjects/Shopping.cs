using DDDCarteira.Domain.Account.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Domain.Account.ValueObjects
{
    public class Shopping : ValueObject
    {
        public Shopping(Broker broker , float valorTotal)
        {
            Broker = broker;
            ValorTotal = valorTotal;

            if (ValorTotal.Equals(null))
            {
                AddNotification("valorTotal, Informe o valor total do registro");
            }

            if (broker.Equals(null))
            {
                AddNotification("broker, A corretora está vazia");
            }

        }

        public Broker Broker { get; set; }
        public float ValorTotal { get; set; }

        private void AddNotification(string v)
        {
            throw new NotImplementedException();
        }
    }
}
