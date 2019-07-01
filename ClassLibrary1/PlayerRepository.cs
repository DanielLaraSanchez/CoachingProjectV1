using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PlayerRepository : IPlayerRepository
    {


        public async Task<IEnumerable<Entities.Player>> GetAllPlayers()
        {
            var players = new List<Player>();
            var options = new DbContextOptionsBuilder();
            using (var context = new PoolChampionContext(options.Options))
            {
                 players = await context.Players.ToListAsync();
            }

            return players.AsEnumerable();
        }

        public async Task<DataLayer.Entities.Player> GetPlayer(long id)
        {
            DataLayer.Entities.Player player;
            var options = new DbContextOptionsBuilder();
            using (var context = new PoolChampionContext(options.Options))
            {
                player = await context.Players.FindAsync(id);
            }
            return player;
        }

        public async Task<Player> AddPlayer(string name, string email)
        { 
            var options = new DbContextOptionsBuilder();
            using (var context = new PoolChampionContext(options.Options))
            {
                if (!context.Players.Any(x => x.EmailAddress == email))
                {
                    var player = new Entities.Player
                    {
                        EmailAddress = email,
                        Name = name
                    };

                    await context.Players.AddAsync(player);

                    await context.SaveChangesAsync();
                    return player;
               }
                return null;
            }
        }


    
    }
}
