using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return appDbContext.Pies;
        }

        public Pie getPieById(int PieId)
        {
            return appDbContext.Pies.FirstOrDefault(p => p.Id == PieId);
        }
    }
}
