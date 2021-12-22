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
         public Billedaccount Read(string billedaccountPrice)
            {
                return Billedaccounts[billedaccountPrice];
            }

            public Billedaccount Update(string billedaccountPrice, Billedaccount newBilledaccount)
            {
                Billedaccounts[billedaccountPrice] = newBilledaccount;
                return Billedaccounts[billedaccountPrice];
            }



        public bool Delete(string billedaccountPrice)
            {
                return Billedaccounts.Remove(billedaccountPrice);
            }

    }
}