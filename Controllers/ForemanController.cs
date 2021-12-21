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
    public class ForemanController : ControllerBase
    {    
        [HttpPut]
        public Foreman Create(Foreman foreman)
        {
            return Storage.foremanStorage.Create(foreman);
        }    
        [HttpGet]
        public Foreman Read(Foreman foreman)
        {
            return Storage.foremanStorage.Read(foreman.Id);
        }

        [HttpPut]
        public Foreman Update(Foreman foreman, Foreman newForeman)
        {
            return Storage.foremanStorage.Update(foreman.Id, newForeman);
        }

        [HttpDelete]
        public bool Delete(Foreman foreman)
        {
            return Storage.foremanStorage.Delete(foreman.Id);
        }
    }
}
