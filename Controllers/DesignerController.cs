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
    public class DesignerController : ControllerBase
    {    
        [HttpPut]
        public Designer Create(Designer designer)
        {
            return Storage.designerStorage.Create(designer);
        }    
        [HttpGet]
        public Designer Read(int designerId)
        {
            return Storage.designerStorage.Read(designerId);
        }

        [HttpPost]
        public Designer Update(int designerId, Designer newDesigner)
        {
            return Storage.designerStorage.Update(designerId, newDesigner);
        }

        [HttpDelete]
        public bool Delete(int designerId)
        {
            return Storage.designerStorage.Delete(designerId);
        }
    }
}
