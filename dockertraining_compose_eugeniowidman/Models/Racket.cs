using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dockertraining_compose_eugeniowidman.Models
{
    public class Racket
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(15)]
        public string Level { get; set; }
    }
}
