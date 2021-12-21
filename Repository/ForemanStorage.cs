using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class ForemanStorage
    {
        private Dictionary<int, Foreman> Foremans = new();
        
        public Foreman Create(Foreman foreman)
        {
            Foremans.Add(foreman.Id, foreman);
            return Foremans[foreman.Id];
        }
         public Foreman Read(Foreman foreman)
            {
                return Foremans[foreman.Id];
            }

            public Foreman Update(Foreman foreman, Foreman newForeman)
            {
                Foremans[foreman.Id] = newForeman;
                return Foremans[foreman.Id];
            }

        internal Foreman Read(int desId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Foreman foreman)
            {
                return Foremans.Remove(foreman.Id);
            }

        internal Foreman Update(int desId, Foreman newForeman)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int desId)
        {
            throw new NotImplementedException();
        }
    }
}