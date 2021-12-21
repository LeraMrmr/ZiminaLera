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
         public Worker Read(Worker worker)
            {
                return Workers[worker.Id];
            }

            public Worker Update(Worker worker, Worker newWorker)
            {
                Workers[worker.Id] = newWorker;
                return Workers[worker.Id];
            }

        internal Worker Read(int desId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Worker worker)
            {
                return Workers.Remove(worker.Id);
            }

        internal Worker Update(int desId, Worker newWorker)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int desId)
        {
            throw new NotImplementedException();
        }
    }

   
}