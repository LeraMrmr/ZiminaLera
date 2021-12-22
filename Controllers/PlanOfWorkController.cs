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
    public class PlanOfWorkController : ControllerBase
    {    
        [HttpPut]
        public PlanOfWork Create(PlanOfWork planOfWork)
        {
            return Storage.planOfWorkStorage.Create(planOfWork);
        }    
        [HttpGet]
        public PlanOfWork Read(int planOfWorkId)
        {
            return Storage.planOfWorkStorage.Read(planOfWorkId);
        }

        [HttpPost]
        public PlanOfWork Update(int planOfWorkId, PlanOfWork newPlanOfWork)
        {
            return Storage.planOfWorkStorage.Update(planOfWorkId, newPlanOfWork);
        }

        [HttpDelete]
        public bool Delete(int planOfWorkId)
        {
            return Storage.planOfWorkStorage.Delete(planOfWorkId);
        }
    }
}
