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
        public Designer Read(Designer designer)
        {
            return Storage.designerStorage.Read(designer.Id);
        }

        [HttpPut]
        public Designer Update(Designer designer, Designer newDesigner)
        {
            return Storage.designerStorage.Update(designer.Id, newDesigner);
        }

        [HttpDelete]
        public bool Delete(Designer designer)
        {
            return Storage.designerStorage.Delete(designer.Id);
        }
    }
}
