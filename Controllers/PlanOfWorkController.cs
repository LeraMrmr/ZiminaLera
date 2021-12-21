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
        public PlanOfWork Read(PlanOfWork planOfWork)
        {
            return Storage.planOfWorkStorage.Read(planOfWork.Id);
        }

        [HttpPut]
        public PlanOfWork Update(PlanOfWork planOfWork, PlanOfWork newPlanOfWork)
        {
            return Storage.planOfWorkStorage.Update(planOfWork.Id, newPlanOfWork);
        }

        [HttpDelete]
        public bool Delete(PlanOfWork planOfWork)
        {
            return Storage.planOfWorkStorage.Delete(planOfWork.Id);
        }
    }
}
