using System;

namespace ZiminaLear.Domain
{
    public class Project
    {
        public int Id { get; set; }
        public int IdDesigner { get; set; }
        public int IdForeman { get; set; }
        public bool Odobreno { get; set; }
        public int IdCustomer { get; set; }
        public string RecomendedPrice { get; set; }
        public string Materials { get; set; }
        public int IdWorker { get; set; }

        public Project() {}

        public Project(int projectId,int desId,int forId,bool odobr,int cusId, string recPrice, string materials, int workId)
        {
            Id = projectId;
            IdDesigner = desId;
            IdForeman = forId;
            Odobreno = odobr;
            IdCustomer = cusId;
            RecomendedPrice = recPrice;
            Materials = materials;
            IdWorker = workId;

        }
    }
}
