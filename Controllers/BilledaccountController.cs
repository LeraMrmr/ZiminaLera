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
        public Billedaccount Read(string billedaccountPrice)
        {
            return Storage.billedaccountStorage.Read(billedaccountPrice);
        }

        [HttpPost]
        public Billedaccount Update(string billedaccountPrice, Billedaccount newBilledaccount)
        {    
            return Storage.billedaccountStorage.Update(billedaccountPrice, newBilledaccount);
        }

        [HttpDelete]
        public bool Delete(string billedaccountPrice)
        {
            return Storage.billedaccountStorage.Delete(billedaccountPrice);
        }
    }
}