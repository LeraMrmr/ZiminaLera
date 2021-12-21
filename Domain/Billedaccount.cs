using System;

namespace ZiminaLear.Domain
{
    public class Billedaccount
    {
        public string Price { get; set; }
        public bool Oplacheno { get; set; }
        public int ZarplataId { get; set; }
        public string SumTotal { get; set; }

        public Billedaccount() {}

        public Billedaccount(string price,bool oplacheno,int zarplId,string sum)
        {
          Price = price;
          Oplacheno = oplacheno;
          ZarplataId = zarplId;
          SumTotal = sum;
        }
    }
}