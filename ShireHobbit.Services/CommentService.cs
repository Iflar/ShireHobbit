using System;
using ShireHobbit.Data;
using ShireHobbit.Models;
using ShireHobbit.WebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Services
{
    public class CommentService
    {
        public readonly Guid _authorId;

        public CommentService(Guid authorid)
        {
            _authorId = authorid;
        }


        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new CommentService()
                {
                    AuthorId = _authorId,
                    Text = model.Text,
                    PostId = model.PostId

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CommentListItem> GetComments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Comments
                        .Where(e => e.AuthorId == _authorId)
                        .Select(
                        else =>
                            new CommentListItem
                            {
                                Id = e.Id,
                                Text = e.Text,
                                PostId = e.PostId

                            })
                    return query.ToArray();
            }
        }
    }


}
