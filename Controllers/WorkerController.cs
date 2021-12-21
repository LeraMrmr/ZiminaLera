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
        public Worker Read(Worker worker)
        {
            return Storage.workerStorage.Read(worker.Id);
        }

        [HttpPut]
        public Worker Update(Worker worker, Worker newWorker)
        {
            return Storage.workerStorage.Update(worker.Id, newWorker);
        }

        [HttpDelete]
        public bool Delete(Worker worker)
        {
            return Storage.workerStorage.Delete(worker.Id);
        }
    }
}
