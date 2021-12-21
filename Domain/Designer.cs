using System;

namespace ZiminaLear.Domain
{
    public class Designer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Pay { get; set; }

        public Designer() {}

        public Designer(int desId, string name, string phone, string pay)
        {
            Id = desId;
            Name = name;
            Phone = phone;
            Pay = pay;
        }
    }
    }

