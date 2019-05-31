using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCarteira.Domain.Account.ValueObjects
{

    public class BuyDate : ValueObject
    {
        private string v1;
        private string v2;
        private DateTime dateTime1;
        private DateTime dateTime2;

        public BuyDate(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public BuyDate(DateTime dateTime1, DateTime dateTime2)
        {
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
        }
        public BuyDate(Wallet wallet, DateTime dataCompra, DateTime dataRegistro)
        {
            DataCompra = dataCompra;
            DataRegistro = dataRegistro;
            

            if (dataCompra.Equals(null)){
                AddNotification("datacompra, A data de Compra está vazia");

            }
            if (dataRegistro.Equals(null)){
                AddNotification("dataregistro, A data de Registro está vazia");
            }

            if (dataRegistro.CompareTo(dataCompra) < 0){
                AddNotification("dataRegistro, A data de registro é anterior a data de compra");
            }

        }

        public DateTime DataRegistro { get; set; }
        public DateTime DataCompra { get; set; }
        public object Valid { get; set; }

        private void AddNotification(string NameCompany)
        {
            throw new NotImplementedException();
        }
    }
}
