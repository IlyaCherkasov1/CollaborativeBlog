using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext appDBContext;
        public PieRepository(AppDbContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return appDBContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return appDBContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return appDBContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
