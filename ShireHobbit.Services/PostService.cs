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
    class PostService
    {
        private readonly Guid _userId;
        //POST
        public bool CreatePost(PostCreate model)
        {
            var entity = new Post()
            {
                AuthorID = _userId,
                Title = model.Title,
                Content = model.Content,
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
                //this is a test
            }
        }
    }
}
