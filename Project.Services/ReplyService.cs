using System;
using Project.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services
{
    public class ReplyService
    {
        private ReplyRepository _repository { get; }
        public ReplyService()
        {
            _repository = new ReplyRepository();
        }
        public bool CreateReply(Reply reply)
        {
            return _repository.CreateReply(reply);
        }

        public List<Reply> GetRepliesByCommentId(int id)
        {
            return _repository.GetRepliesByCommentId(id);
        }
    }
}
