using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Areas.ViewModels
{
    public class AdminViewModel
    {
        [Required]
        [MaxLength(25)]
        [MinLength(5)]
        public string Username { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
