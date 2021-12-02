using ShireHobbit.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Models
{
    public class LikeDetail
    {
        public int LikeId { get; set; }
        public Guid OwnerId { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
