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
         public PlanOfWork Read(PlanOfWork planOfWork)
            {
                return PlanOfWorks[planOfWork.Id];
            }

            public PlanOfWork Update(PlanOfWork planOfWork, PlanOfWork newPlanOfWork)
            {
                PlanOfWorks[planOfWork.Id] = newPlanOfWork;
                return PlanOfWorks[planOfWork.Id];
            }

        internal PlanOfWork Read(int planId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PlanOfWork planOfWork)
            {
                return PlanOfWorks.Remove(planOfWork.Id);
            }

        internal PlanOfWork Update(int planId, PlanOfWork newPlanOfWork)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int planId)
        {
            throw new NotImplementedException();
        }
    }

   
}