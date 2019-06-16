using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carteira.Api.Controllers
{
    [Route("api/[controller]")]
    public class BrokerController : Controller{
        private readonly IBrokerRepository _repository;

        public BrokerController(IBrokerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IEnumerable<Broker> Get()
        {
            return _repository.GetBrokers();
        }

        [HttpGet("{id}")]
        public Broker Get(int id)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(id).CopyTo(bytes, 0);
            var newId = new Guid(bytes);

            return _repository.GetById(newId);
        }

        [HttpPost]
        public void Post([FromBody]Broker broker)
        {
            try
            {
                _repository.Save(broker);
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