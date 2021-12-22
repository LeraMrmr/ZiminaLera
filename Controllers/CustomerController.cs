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
        public Customer Read(int customerId)
        {
            return Storage.customerStorage.Read(customerId);
        }

        [HttpPut]
        public Customer Update(int customerId, Customer newCustomer)
        {
            return Storage.customerStorage.Update(customerId, newCustomer);
        }

        [HttpDelete]
        public bool Delete(int customerId)
        {
            return Storage.customerStorage.Delete(customerId);
        }
    }
}
