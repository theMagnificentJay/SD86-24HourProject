using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourAssignment.Models;

namespace Project.Data
{
    public class CommentRepository
    {
        public bool CreateComment(Comment comment)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(comment);
                return ctx.SaveChanges() == 1;
            }
        }

        public List<Comment> GetCommentsByPostId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<Comment> commentsForPostId = ctx.Comments.Where(comment => comment.PostId == id).ToList();

                return commentsForPostId;
            }
        }
    }
}
