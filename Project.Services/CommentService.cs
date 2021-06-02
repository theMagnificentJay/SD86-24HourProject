using System;
using Project.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services
{
    public class CommentService
    {
        private CommentRepository _repository { get; }
        public CommentService()
        {
            _repository = new CommentRepository();
        }
        public bool CreateComment(Comment comment)
        {
            return _repository.CreateComment(comment);
        }

        public List<Comment> GetCommentsByPostId(int id)
        {
            return _repository.GetCommentsByPostId(id);
        }
    }
}
