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
         public Customer Read(Customer customer)
            {
                return Customers[customer.Id];
            }

            public Customer Update(Customer customer, Customer newCustomer)
            {
                Customers[customer.Id] = newCustomer;
                return Customers[customer.Id];
            }

        internal Customer Read(int custId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer customer)
            {
                return Customers.Remove(customer.Id);
            }

        internal Customer Update(int custId, Customer newCustomer)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int custId)
        {
            throw new NotImplementedException();
        }
    }
}