using System;
using System.Data.SqlClient;
using System.Linq;

namespace UP16_17_Database
{
    internal class Rank1
    {
        string rank;
        int category;

        public string Rank { get => rank; set => rank = value; }
        public int Category { get => category; set => category = value; }

        public Rank1(string rank, int category)
        {
            this.Rank = rank;
            this.Category = category;
        }

        
    }
}