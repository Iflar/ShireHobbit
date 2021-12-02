using ShireHobbit.Data;
using ShireHobbit.Models;
using ShireHobbit.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Services
{
    public class ReplyServices
    {
        private readonly Guid _userId;

        public ReplyServices(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    AuthorId = _userId,
                    Text = model.Text,
                    TimeStamp = DateTime.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies
            }
        }
    }
}
