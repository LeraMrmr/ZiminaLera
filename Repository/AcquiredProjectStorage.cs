using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class AcquiredProjectStorage
    {
        private Dictionary<int, AcquiredProject> AcquiredProjects = new();
        
        public AcquiredProject Create(AcquiredProject acquiredProject)
        {
            AcquiredProjects.Add(acquiredProject.Id, acquiredProject);
            return AcquiredProjects[acquiredProject.Id];
        }
         public AcquiredProject Read(AcquiredProject acquiredProject)
            {
                return AcquiredProjects[acquiredProject.Id];
            }

            public AcquiredProject Update(AcquiredProject acquiredProject, AcquiredProject newAcquiredProject)
            {
                AcquiredProjects[acquiredProject.Id] = newAcquiredProject;
                return AcquiredProjects[acquiredProject.Id];
            }

        internal AcquiredProject Read(int aprojectId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(AcquiredProject acquiredProject)
            {
                return AcquiredProjects.Remove(acquiredProject.Id);
            }

        internal AcquiredProject Update(int aprojectId, AcquiredProject newAcquiredProject)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int aprojectId)
        {
            throw new NotImplementedException();
        }
    }
}