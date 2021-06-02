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
    public class ReplyController : ApiController
    {
        public IHttpActionResult Post(Reply reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = new ReplyService();

            if (!service.CreateReply(reply))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            ReplyService replyService = new ReplyService();
            List<Reply> reply = replyService.GetRepliesByCommentId(id);
            return Ok(reply);
        }
    }
}
