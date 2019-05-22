using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Entities
{
    class RankingContext : DbContext
    {
        public RankingContext(DbContextOptions options) : base(options) { } 

        public DbSet<Ranking> Rankings { get; set; }
    }
}
