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
    public class AcquiredProjectController : ControllerBase
    {    
        [HttpPost]
        public AcquiredProject Create(AcquiredProject acquiredProject)
        {
            return Storage.acquiredProjectStorage.Create(acquiredProject);
        }    
        [HttpGet]
        public AcquiredProject Read(int acquiredProjectId)
        {
            return Storage.acquiredProjectStorage.Read(acquiredProjectId);
        }

        [HttpPut]
        public AcquiredProject Update(int acquiredProjectId, AcquiredProject newAcqiredProject)
        {
            return Storage.acquiredProjectStorage.Update(acquiredProjectId, newAcqiredProject);
        }
      
        [HttpDelete]
        public bool Delete(int acquiredProjectId)
        {
            return Storage.acquiredProjectStorage.Delete(acquiredProjectId);
        }
    }
}