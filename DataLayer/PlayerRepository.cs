using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly PoolChampionContext _context;

        public PlayerRepository(PoolChampionContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Entities.Player>> GetAllPlayers()
        {
            var players = await _context.Players.ToListAsync();
            return players.AsEnumerable();
        }

        public async Task<DataLayer.Entities.Player> GetPlayer(long id)
        {
            var player = await _context.Players.FindAsync(id);
            return player;
        }

        public async Task<Player> AddPlayer(string name, string email)
        {
            Player player = null;
            if (!_context.Players.Any(x => x.EmailAddress == email))
            {
                player = new Entities.Player
                {
                    EmailAddress = email,
                    Name = name
                };

                await _context.Players.AddAsync(player);

            }

            await _context.SaveChangesAsync();
            return player;
        }
    }   
    }

