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
        public AcquiredProject Read(int acquiredProjectId)
        {
            return AcquiredProjects[acquiredProjectId];
        }

        public AcquiredProject Update(int acquiredProjectId, AcquiredProject newAcquiredProject)
        {
            AcquiredProjects[acquiredProjectId] = newAcquiredProject;
            return AcquiredProjects[acquiredProjectId];
        }

        public bool Delete(int acquiredProjectId)
        {
            return AcquiredProjects.Remove(acquiredProjectId);
        }

    }
}