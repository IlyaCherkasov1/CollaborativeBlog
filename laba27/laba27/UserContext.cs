using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba27
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection")
        {
        }
        public DbSet<Medecine> Medecines { get; set; }
        public DbSet<Sale>  Sales { get; set; }
        public DbSet<StockAvailabillity> StockAvailabillities { get; set; }

    }
}
