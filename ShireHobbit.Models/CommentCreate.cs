using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Models
{
    class CommentCreate
    {
        [Requried]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(5, ErrorMessage = "There are too many characters in this field")]
        public Guid AuthorId { get; set; }

        [MaxLength(5000)]
        public string Text { get; set; }
    }
}
