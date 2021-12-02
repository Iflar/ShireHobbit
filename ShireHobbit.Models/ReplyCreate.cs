using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Models
{
    public class ReplyCreate
    {
        [Required]
        [MinLength(0, ErrorMessage ="Please enter at least one character")]
        [MaxLength(5000, ErrorMessage ="WE DONT NEED AN ENTIRE LIFE STORY" )]
        public string Text { get; set; }

        [Required]
        public DateTime TimeStamp { get; set}
    }
}
