using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.Models
{
    public class Comments
    {
        [BindNever]
        [Key]
        public int CommentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }
        [Required]
        [MaxLength(100)]
        
        public string Email { get; set; }
        [Required]
        [MaxLength(300)]
        
        public string Comment { get; set; }
        public bool CallMe { get; set; }

    }
}
