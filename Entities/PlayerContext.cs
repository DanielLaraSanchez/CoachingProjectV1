using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Entities
{
    class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions options) : base(options) { }

        public DbSet<Player> Players { get; set; }
    }
}
