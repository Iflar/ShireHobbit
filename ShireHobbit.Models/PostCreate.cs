using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShireHobbit.Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Too few characters")]
        [MaxLength(100, ErrorMessage = "Too many characters")]
        public string Title { get; set; }

        [Required]
        [MaxLength(90000, ErrorMessage = "This has gone on long enough")]
        public string  Content { get; set; }
    }
}
