using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Models
{
    public class LikeCreate
    {
        public int LikeId { get; set; }
        public Guid OwnerId { get; set; }
    }
}
