using System;

namespace ZiminaLear.Domain
{
    public class PlanOfWork
    {
        public int Id { get; set; }
        public string Volume { get; set; }
        public DateTime Time { get; set; }
        public bool Done { get; set; }

        public PlanOfWork() {}

        public PlanOfWork(int planId, string volume, DateTime time, bool done)
        {
           Id = planId;
           Volume = volume;
           Time = time;
           Done = done;
        }
    }
    }