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
    class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }

        // POST
        public bool CreateLike(LikeCreate model)
        {
            var entity = new Like()
            {
                OwnerId = _userId,
                LikeId = model.LikeId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Like.Add(entity);
                return ctx.SaveChanges() == 1;
            }

            //using (var ctx = new ApplicationDbContext())
            //{
            //    ctx.Like.Add(entity);
            //    return ctx.SaveChanges() == 1;
            //}
        }
        // GET Likes by Post ID

    }
}
