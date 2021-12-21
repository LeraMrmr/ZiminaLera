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
        [HttpPut]
        public AcquiredProject Create(AcquiredProject acquiredProject)
        {
            return Storage.acquiredProjectStorage.Create(acquiredProject);
        }    
        [HttpGet]
        public AcquiredProject Read(AcquiredProject acquiredProject)
        {
            return Storage.acquiredProjectStorage.Read(acquiredProject.Id);
        }

        [HttpPut]
        public AcquiredProject Update(AcquiredProject acquiredProject, AcquiredProject newAcqiredProject)
        {
            return Storage.acquiredProjectStorage.Update(acquiredProject.Id, newAcqiredProject);
        }

        [HttpDelete]
        public bool Delete(AcquiredProject acquiredProject)
        {
            return Storage.acquiredProjectStorage.Delete(acquiredProject.Id);
        }
    }
}