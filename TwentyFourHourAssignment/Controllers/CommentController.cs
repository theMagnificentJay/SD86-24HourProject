using Project.Data;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TwentyFourHourAssignment.Controllers
{
    [Authorize]
    public class CommentController : ApiController
    {
        public IHttpActionResult Post(Comment comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = new CommentService();

            if (!service.CreateComment(comment))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            CommentService commentService = new CommentService();
            List<Comment> comments = commentService.GetCommentsByPostId(id);
            return Ok(comments);
        }
    }
}
