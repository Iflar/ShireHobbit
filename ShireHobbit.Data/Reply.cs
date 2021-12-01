using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShireHobbit.Data
{
    public class Reply : Comment
    {
        [Required]
        public DateTimeOffset CreeatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

        [ForeignKey(nameof(Comment))]
        public int ReplyId { get; set; }
        public virtual Comment Comments { get; set; }
    }
}