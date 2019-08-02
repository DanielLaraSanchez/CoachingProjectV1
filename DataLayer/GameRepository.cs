using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class GameRepository : IGameRepository
    {

        private readonly PoolChampionContext _context;

        public GameRepository(PoolChampionContext context)
        {
            _context = context;
        }

        public async Task<Game> AddGame(Game game)
        {
                await _context.Games.AddAsync(game);
                await _context.SaveChangesAsync();
                return game;
        }

        public async Task<IEnumerable<Game>> GetAllGames()
        {
                var games = await _context.Games.ToListAsync();
                return games.AsEnumerable();
        }

        public async Task<DataLayer.Entities.Game> GetGame(long id)
        {
               var game = await _context.Games.FindAsync(id);
                return game;
        }
    }
}
