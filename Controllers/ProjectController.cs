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
        public Project Read(Project project)
        {
            return Storage.projectStorage.Read(project.Id);
        }

        [HttpPut]
        public Project Update(Project project, Project newProject)
        {
            return Storage.projectStorage.Update(project.Id, newProject);
        }

        [HttpDelete]
        public bool Delete(Project project)
        {
            return Storage.projectStorage.Delete(project.Id);
        }
    }
}
