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
        public Pay Read(int payId)
        {
            return Storage.payStorage.Read(payId);
        }

        [HttpPost]
        public Pay Update(int payId, Pay newPay)
        {    
            return Storage.payStorage.Update(payId, newPay);
        }

        [HttpDelete]
        public bool Delete(int payId)
        {
            return Storage.payStorage.Delete(payId);
        }
    }
}