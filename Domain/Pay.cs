using System;

namespace ZiminaLear.Domain
{
    public class Pay
    {
        public int Id { get; set; }
        public int IdWorker { get; set; }
        public int IdDesigner { get; set; }
        public bool Oplacheno { get; set; }
        public int IdCustomer { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int IdPlan { get; set; }

        public Pay() {}

        public Pay(int payId,int desId,int workId,bool oplacheno,int planId, string month, int year)
        {
            Id = payId;
            IdDesigner = desId;
            IdWorker = workId;
            Oplacheno = oplacheno;
            IdPlan = planId;
            Month = month;
            Year = year;

        }
    }
}