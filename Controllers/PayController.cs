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
    public class PayController : ControllerBase
    {    
        [HttpPut]
        public Pay Create(Pay pay)
        {
            return Storage.payStorage.Create(pay);
        }    
        [HttpGet]
        public Pay Read(Pay pay)
        {
            return Storage.payStorage.Read(pay.Id);
        }

        [HttpPut]
        public Pay Update(Pay pay, Pay newPay)
        {    
            return Storage.payStorage.Update(pay.Id, newPay);
        }

        [HttpDelete]
        public bool Delete(Pay pay)
        {
            return Storage.payStorage.Delete(pay.Id);
        }
    }
}