using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carteira.Api.Controllers
{
    [Route("api/[controller]")]
    public class WalletController : Controller
    {
        private readonly IWalletRepository _repository;
        private Wallet wallet;

        public WalletController(IWalletRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IEnumerable<Wallet> Get()
        {
            return _repository.GetWallets();
        }

        [HttpGet("{id}")]
        public Wallet Get(string code)
        {
            return _repository.GetWalletByCode(code);
        }

        [HttpPost]
        public void Post([FromBody]Wallet parcel)
        {
            try
            {
                _repository.Save(wallet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}