using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.Models
{
    public interface ICommentsRepositoy
    {
        public void AddComment(Comments comments);
    }
}
