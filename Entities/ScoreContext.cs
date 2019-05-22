using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    class ScoreContext : DbContext
    {
        public ScoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Score> Scores { get; set; }
    }
}
