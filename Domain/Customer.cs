using System;

namespace ZiminaLear.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer() {}

        public Customer(int custId,string name,string phone, string address, DateTime birthDate)
        {
            Id = custId;
            Name = name;
            Phone = phone;
            Address = address;
            BirthDate = birthDate;
        }
    }
}
