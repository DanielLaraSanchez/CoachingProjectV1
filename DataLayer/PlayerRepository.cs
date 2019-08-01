using System;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public async Task<Player> AddPlayer(string name, string emailAddress, string password)
        {
            Player player = null;
            if (!_context.Players.Any(x => x.EmailAddress == emailAddress))
            {
                player = new Entities.Player
                {
                    EmailAddress = emailAddress,
                    Name = name,
                    Password = password
                };

                await _context.Players.AddAsync(player);

            }

            await _context.SaveChangesAsync();
            return player;
        }

        public async Task<Player> GetPlayerLoggedIn(string email, string password)
        {
            Player player = null;
            try
            {
                 player = await _context.Players.Where(x => x.EmailAddress == email).Where(x => x.Password == password).FirstOrDefaultAsync(); //or SingleAsync

                if (player.EmailAddress != null)
                {
                    return player;
                }
               
            }
            catch (NullReferenceException error)
            {
                Console.WriteLine(error.Message);
            }

            return player;
        }

        public bool CheckIfPasswordIsCorrect(string passwordUi, string passwordDb)
        {
            bool result = passwordUi == passwordDb;

            return result;
        }


    }   
 }

