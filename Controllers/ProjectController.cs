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
    public class ProjectController : ControllerBase
    {    
        [HttpPut]
        public Project Create(Project project)
        {
            return Storage.projectStorage.Create(project);
        }    
        [HttpGet]
        public Project Read(int projectId)
        {
            return Storage.projectStorage.Read(projectId);
        }

        [HttpPost]
        public Project Update(int projectId, Project newProject)
        {
            return Storage.projectStorage.Update(projectId, newProject);
        }

        [HttpDelete]
        public bool Delete(int projectId)
        {
            return Storage.projectStorage.Delete(projectId);
        }
    }
}
