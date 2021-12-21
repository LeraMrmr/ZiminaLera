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
    public class BilledaccountController : ControllerBase
    {    
        [HttpPut]
        public Billedaccount Create(Billedaccount billedaccount)
        {
            return Storage.billedaccountStorage.Create(billedaccount);
        }    
        [HttpGet]
        public Billedaccount Read(Billedaccount billedaccount)
        {
            return Storage.billedaccountStorage.Read(billedaccount.Price);
        }

        [HttpPut]
        public Billedaccount Update(Billedaccount billedaccount, Billedaccount newBilledaccount)
        {    
            return Storage.billedaccountStorage.Update(billedaccount.Price, newBilledaccount);
        }

        [HttpDelete]
        public bool Delete(Billedaccount billedaccount)
        {
            return Storage.billedaccountStorage.Delete(billedaccount.Price);
        }
    }
}