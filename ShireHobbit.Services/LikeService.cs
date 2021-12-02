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
    public class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLike(LikeCreate model)
        {
            var entity = new Like()
            {
                OwnerId = _userId,
                LikeId = model.LikeId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public LikeDetail GetLikeByPostId(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Likes
                        .Single(e => e.LikeId == likeId && e.PostId == postId);
                return
                    new LikeDetail
                    {
                        LikeId = entity.LikeId,
                        PostId = entity.PostId
                    };
            }
        }
    }
}
