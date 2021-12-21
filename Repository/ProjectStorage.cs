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
         public Project Read(Project project)
            {
                return Projects[project.Id];
            }

            public Project Update(Project project, Project newProject)
            {
                Projects[project.Id] = newProject;
                return Projects[project.Id];
            }

        internal Project Read(int projectId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Project project)
            {
                return Projects.Remove(project.Id);
            }

        internal Project Update(int projectId, Project newProject)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int projectId)
        {
            throw new NotImplementedException();
        }
    }

   
}