using ShireHobbit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShireHobbit.WebAPI.Controllers
{
    public class ReplyController : ApiController
    {
        private ReplyService CreateReplyService()
        {
            var userId = Guid.Parse
                (User.Identity.GetUserId());
            var replyservice = new ReplyService(userId);
                return replyservice;
        }
    }

    [IHTTP Get]
}
