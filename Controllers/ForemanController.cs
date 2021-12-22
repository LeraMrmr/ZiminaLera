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
        public Foreman Read(int foremanId)
        {
            return Storage.foremanStorage.Read(foremanId);
        }

        [HttpPost]
        public Foreman Update(int foremanId, Foreman newForeman)
        {
            return Storage.foremanStorage.Update(foremanId, newForeman);
        }

        [HttpDelete]
        public bool Delete(int foremanId)
        {
            return Storage.foremanStorage.Delete(foremanId);
        }
    }
}
