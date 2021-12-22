using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class WorkerStorage
    {
        private Dictionary<int, Worker> Workers = new();
        
        public Worker Create(Worker worker)
        {
            Workers.Add(worker.Id, worker);
            return Workers[worker.Id];
        }
         public Worker Read(int workerId)
            {
                return Workers[workerId];
            }

            public Worker Update(int workerId, Worker newWorker)
            {
                Workers[workerId] = newWorker;
                return Workers[workerId];
            }


        public bool Delete(int workerId)
            {
                return Workers.Remove(workerId);
            }

    }

   
}