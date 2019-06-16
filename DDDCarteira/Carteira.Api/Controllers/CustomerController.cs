
using DDDCarteira.Domain.Account.Entities;
using DDDCarteira.Domain.Account.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carteira.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController{

        public class CustomerController : Controller
        {
            private readonly ICustomerRepository _repository;

            public CustomerController(ICustomerRepository repository)
            {
                _repository = repository;
            }

            [HttpPut]
            public IEnumerable<Customer> Get()
            {
                return _repository.GetCustomers();
            }

            [HttpGet("{id}")]
            public Customer Get(int id)
            {
                byte[] bytes = new byte[16];
                BitConverter.GetBytes(id).CopyTo(bytes, 0);
                var newId = new Guid(bytes);

                return _repository.GetById(newId);
            }

            [HttpPost]
            public void Post([FromBody]Customer customer)
            {
                try
                {
                    _repository.Save(customer);
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