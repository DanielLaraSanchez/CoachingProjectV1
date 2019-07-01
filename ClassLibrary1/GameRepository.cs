using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    class GameRepository
    {

        public async Task<Game> AddGame(Player player1, Player player2)
        {
            var options = new DbContextOptionsBuilder();
            using (var context = new PoolChampionContext(options.Options))
            {
                var game = new Entities.Game()
                {
                    Player1 = player1,
                    Player2 = player2
                };
                await context.Games.AddAsync(game);
                await context.SaveChangesAsync();
                return game;
            }


        }

        public async Task<IEnumerable<Game>> GetAllGames()
        {
            var options = new DbContextOptionsBuilder();
            using (var context = new PoolChampionContext(options.Options))
            {

                var games = await context.Games.ToListAsync();
                return games;
            }
        }

        public async Task<DataLayer.Entities.Game> GetGame(long id)
        {
            DataLayer.Entities.Game game;
            var options = new DbContextOptionsBuilder();
            using (var context = new PoolChampionContext(options.Options)
            {
                game =
            }
            
           
        }
    }
}
