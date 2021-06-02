using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourAssignment.Models;

namespace Project.Data
{
    public class ReplyRepository
    {
        public bool CreateReply(Reply reply)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(reply);
                return ctx.SaveChanges() == 1;
            }
        }

        public List<Reply> GetRepliesByCommentId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<Reply> repliesForComment = ctx.Replies.Where(reply => reply.CommentId == id).ToList();

                return repliesForComment;
            }
        }
    }
}
