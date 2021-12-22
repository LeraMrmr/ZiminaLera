using System;
using System.Collections.Generic;
using ZiminaLear.Domain;

namespace ZiminaLear.Repository
{
    public class CustomerStorage
    {
        private Dictionary<int, Customer> Customers = new();
        
        public Customer Create(Customer customer)
        {
            Customers.Add(customer.Id, customer);
            return Customers[customer.Id];
        }
         public Customer Read(int customerId)
            {
                return Customers[customerId];
            }

            public Customer Update(int customerId, Customer newCustomer)
            {
                Customers[customerId] = newCustomer;
                return Customers[customerId];
            }


        public bool Delete(int customerId)
            {
                return Customers.Remove(customerId);
            }

    }
}