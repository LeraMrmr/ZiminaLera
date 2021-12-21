using System;

namespace ZiminaLear.Domain
{
    public class AcquiredProject
    {
        public int Id { get; set; }
        public int IdProject { get; set; }
        public string ActualPrice { get; set; }

        public AcquiredProject() {}

        public AcquiredProject(int aprojectId,int projectId,string aPrice)
        {
            Id = aprojectId;
            IdProject = projectId;
            ActualPrice = aPrice;

        }
    }
}