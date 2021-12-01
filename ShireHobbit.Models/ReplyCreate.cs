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
        [MinLength(0, ErrorMessage ="Please eneter at least one character.")]
        [MaxLength(562, ErrorMessage = "Too many characters within this response.")]
        public string Text { get; set; }

    }
}
