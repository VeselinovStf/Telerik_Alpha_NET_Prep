using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatServer.Data
{
    public class Cat
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Range(0,20)]
        public int Age { get; set; }

        [Required]
        [MaxLength(30)]

        public string Breed { get; set; }

        [Required]
        public string ImgUrl { get; set; }
    }
}
