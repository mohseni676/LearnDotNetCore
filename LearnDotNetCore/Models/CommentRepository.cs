using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.Models
{
    public class CommentRepository : ICommentsRepositoy
    {
        public readonly AppDbContext appDbContext;

        public CommentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void AddComment(Comments comments)
        {
            appDbContext.Comments.Add(comments);
            appDbContext.SaveChanges();
        }
    }
}
