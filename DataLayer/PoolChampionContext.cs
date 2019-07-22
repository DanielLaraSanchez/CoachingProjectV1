using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public  class PoolChampionContext : DbContext
    {
        public PoolChampionContext( DbContextOptions<PoolChampionContext> options)
            : base(options)
        {
        }
      
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
