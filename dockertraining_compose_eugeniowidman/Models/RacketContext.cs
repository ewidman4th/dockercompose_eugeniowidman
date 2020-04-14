using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dockertraining_compose_eugeniowidman.Models
{
    public class RacketContext:DbContext
    {
        public DbSet<Racket> Rackets { get; set; }

        public RacketContext(DbContextOptions options) :
            base(options) { }
    }
}
