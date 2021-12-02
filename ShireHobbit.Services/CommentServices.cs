using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Services
{
    public class CommentServices
    {
        public readonly Guid _userId;

        public CommentServices(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    Id = model.Id,
                    Text = model.Text,
                    AuthorId = _userId,
                    PostId = model.PostId

                };
        }
    }
}
