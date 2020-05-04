using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba27_EntityFramework
{
    public class AppDBContext:DbContext
    {
        public AppDBContext():base("DBConnection")
        {

        }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<InStock> inStocks { get; set; }
        public DbSet<Sell> Sells { get; set; }

    }
}
