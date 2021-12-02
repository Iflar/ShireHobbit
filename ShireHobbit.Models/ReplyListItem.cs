using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Models
{
   public class ReplyListItem
    {
        public int ReplyId { get; set; }
        public string Text { get; set; }

        [Display(Name="Create Message")]
        public DateTimeOffset TimeStamp { get; set; }

    }
}
