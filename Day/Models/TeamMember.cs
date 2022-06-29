using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string FullName { get; set; }
        [MaxLength(30)]
        public string Position { get; set; }
        [MaxLength(300)]
        public string Desc { get; set; }
        [MaxLength(100)]
        public string TwitterUrl { get; set; }
        [MaxLength(100)]
        public string FacebookUrl { get; set; }
        [MaxLength(100)]
        public string InstaUrl { get; set; }
        [MaxLength(100)]
        public string LinkednUrl { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
