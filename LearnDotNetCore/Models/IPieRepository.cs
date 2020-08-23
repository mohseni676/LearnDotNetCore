using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie getPieById(int PieId);
    }
}
