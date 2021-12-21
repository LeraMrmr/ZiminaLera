using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZiminaLear.Domain;
using ZiminaLear.Repository;

namespace ZiminaLear.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {    
        [HttpPut]
        public Customer Create(Customer customer)
        {
            return Storage.customerStorage.Create(customer);
        }    
        [HttpGet]
        public Customer Read(Customer customer)
        {
            return Storage.customerStorage.Read(customer.Id);
        }

        [HttpPut]
        public Customer Update(Customer customer, Customer newCustomer)
        {
            return Storage.customerStorage.Update(customer.Id, newCustomer);
        }

        [HttpDelete]
        public bool Delete(Customer customer)
        {
            return Storage.customerStorage.Delete(customer.Id);
        }
    }
}
