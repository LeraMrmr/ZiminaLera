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
    public class WorkerController : ControllerBase
    {    
        [HttpPut]
        public Worker Create(Worker worker)
        {
            return Storage.workerStorage.Create(worker);
        }    
        [HttpGet]
        public Worker Read(int workerId)
        {
            return Storage.workerStorage.Read(workerId);
        }

        [HttpPost]
        public Worker Update(int workerId, Worker newWorker)
        {
            return Storage.workerStorage.Update(workerId, newWorker);
        }

        [HttpDelete]
        public bool Delete(int workerId)
        {
            return Storage.workerStorage.Delete(workerId);
        }
    }
}
