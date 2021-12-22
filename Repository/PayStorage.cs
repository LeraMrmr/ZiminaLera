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
         public Pay Read(int payId)
            {
                return Pays[payId];
            }

            public Pay Update(int payId, Pay newPay)
            {
                Pays[payId] = newPay;
                return Pays[payId];
            }


        public bool Delete(int payId)
            {
                return Pays.Remove(payId);
            }

    }

   
}