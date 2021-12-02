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

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comment.Add(entity);
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
                        .Where(e => e.AuthorId == _userId)
                        .Select(
                            e =>
                                new CommentListItem
                                {
                                    Id = e.Id,
                                    Text = e.Text,
                                    PostId = e.PostId
                                }
                            );
                return query.ToArray();
            }
        }

        public CommentDetail GetCommentById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.Id == id && e.AuthorId == _userId);
                return
                    new CommentDetail
                    {
                        Id = entity.Id,
                        Text = entity.Text,
                        AuthorId = _userId,
                        PostId = entity.PostId
                    };
            }
        }

        public bool UpdateComment(CommentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.Id == model.Id && e.AuthorId == _userId);
                entity.Text = model.Text;
                entity.Id = model.Id;
                entity.PostId = model.PostId;

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteComment(int commentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.Id == commentId && e.AuthorId == _userId);

                ctx.Comments.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
