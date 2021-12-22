using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class ProjectStorage
    {
        private Dictionary<int, Project> Projects = new();
        
        public Project Create(Project project)
        {
            Projects.Add(project.Id, project);
            return Projects[project.Id];
        }
         public Project Read(int projectId)
            {
                return Projects[projectId];
            }

            public Project Update(int projectId, Project newProject)
            {
                Projects[projectId] = newProject;
                return Projects[projectId];
            }


        public bool Delete(int projectId)
            {
                return Projects.Remove(projectId);
            }

    }

   
}