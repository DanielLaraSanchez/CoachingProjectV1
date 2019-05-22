using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Entities
{
    class GameContext : DbContext
    {
        public GameContext(DbContextOptions options ) : base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}
