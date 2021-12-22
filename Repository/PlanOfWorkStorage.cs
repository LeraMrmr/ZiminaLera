using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class PlanOfWorkStorage
    {
        private Dictionary<int, PlanOfWork> PlanOfWorks = new();
        
        public PlanOfWork Create(PlanOfWork planOfWork)
        {
            PlanOfWorks.Add(planOfWork.Id, planOfWork);
            return PlanOfWorks[planOfWork.Id];
        }
         public PlanOfWork Read(int planOfWorkId)
            {
                return PlanOfWorks[planOfWorkId];
            }

            public PlanOfWork Update(int planOfWorkId, PlanOfWork newPlanOfWork)
            {
                PlanOfWorks[planOfWorkId] = newPlanOfWork;
                return PlanOfWorks[planOfWorkId];
            }


        public bool Delete(int planOfWorkId)
            {
                return PlanOfWorks.Remove(planOfWorkId);
            }
    }

   
}