using System;

namespace ZiminaLear.Domain
{
    public class Foreman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Foreman() {}

        public Foreman(int desId, string name, string phone)
        {
            Id = desId;
            Name = name;
            Phone = phone;
        }
    }
    }