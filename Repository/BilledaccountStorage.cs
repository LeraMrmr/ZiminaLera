using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class BilledaccountStorage
    {
        private Dictionary<string, Billedaccount> Billedaccounts = new();
        
        public Billedaccount Create(Billedaccount billedaccount)
        {
            Billedaccounts.Add(billedaccount.Price, billedaccount);
            return Billedaccounts[billedaccount.Price];
        }
         public Billedaccount Read(Billedaccount billedaccount)
            {
                return Billedaccounts[billedaccount.Price];
            }

            public Billedaccount Update(Billedaccount billedaccount, Billedaccount newBilledaccount)
            {
                Billedaccounts[billedaccount.Price] = newBilledaccount;
                return Billedaccounts[billedaccount.Price];
            }

        internal Billedaccount Read(string price)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Billedaccount billedaccount)
            {
                return Billedaccounts.Remove(billedaccount.Price);
            }

        internal Billedaccount Update(string price, Billedaccount newBilledaccount)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(string price)
        {
            throw new NotImplementedException();
        }
    }
}