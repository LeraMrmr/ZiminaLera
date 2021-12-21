using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class PayStorage
    {
        private Dictionary<int, Pay> Pays = new();
        
        public Pay Create(Pay pay)
        {
            Pays.Add(pay.Id, pay);
            return Pays[pay.Id];
        }
         public Pay Read(Pay pay)
            {
                return Pays[pay.Id];
            }

            public Pay Update(Pay pay, Pay newPay)
            {
                Pays[pay.Id] = newPay;
                return Pays[pay.Id];
            }

        internal Pay Read(int payId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Pay pay)
            {
                return Pays.Remove(pay.Id);
            }

        internal Pay Update(int payId, Pay newPay)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int payId)
        {
            throw new NotImplementedException();
        }
    }

   
}