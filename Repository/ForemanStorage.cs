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
         public Foreman Read(int foremanId)
            {
                return Foremans[foremanId];
            }

            public Foreman Update(int foremanId, Foreman newForeman)
            {
                Foremans[foremanId] = newForeman;
                return Foremans[foremanId];
            }


        public bool Delete(int foremanId)
            {
                return Foremans.Remove(foremanId);
            }


    }
}