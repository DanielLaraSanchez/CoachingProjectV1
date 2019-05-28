using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Entities;
<<<<<<< HEAD
=======
using DataLayer.Entities.Repository;

//why are things not asynchronous?
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
<<<<<<< HEAD
        private readonly PoolChampionContext _context;

        public PlayersController(PoolChampionContext context)
        {
            _context = context;
=======

        public IDataRepository<Player> _dataRepository { get; }

        public PlayersController(IDataRepository<Player> dataRepository)
        {
            _dataRepository = dataRepository;
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95
        }

        // GET: api/Players
        [HttpGet]
<<<<<<< HEAD
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
=======
        public ActionResult<IEnumerable<Player>> GetPlayers()
        {
            IEnumerable<Player> players = _dataRepository.GetAll();
            return Ok(players);
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
<<<<<<< HEAD
        public async Task<ActionResult<Player>> GetPlayer(long id)
        {
            var player = await _context.Players.FindAsync(id);

=======
        public ActionResult<Player> GetPlayer(long id)
        {
            Player player = _dataRepository.Get(id);
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95
            if (player == null)
            {
                return NotFound();
            }

            return player;
        }

        // PUT: api/Players/5
        [HttpPut("{id}")]
<<<<<<< HEAD
        public async Task<IActionResult> PutPlayer(long id, Player player)
        {
            if (id != player.PlayerId)
            {
                return BadRequest();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

=======
        public IActionResult PutPlayer(long id, Player player)
        {
            if (player == null)
            {
                return BadRequest("Player is null.");
            }

            Player playerToUpdate = _dataRepository.Get(id);
            if (playerToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Update(playerToUpdate, player);
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95
            return NoContent();
        }

        // POST: api/Players
        [HttpPost]
<<<<<<< HEAD
        public async Task<ActionResult<Player>> PostPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayer", new { id = player.PlayerId }, player);
=======
        public ActionResult<Player> PostPlayer(Player player)
        {
            if (player == null)
            {
                return BadRequest("Employee is null.");
            }

            _dataRepository.Add(player);
            return CreatedAtRoute(
                  "Get",
                  new { Id = player.PlayerId },
                  player);
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
<<<<<<< HEAD
        public async Task<ActionResult<Player>> DeletePlayer(long id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return player;
        }

        private bool PlayerExists(long id)
        {
            return _context.Players.Any(e => e.PlayerId == id);
        }
=======
        public ActionResult<Player> DeletePlayer(long id)
        {
            Player player = _dataRepository.Get(id);
            if (player == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Delete(player);
            return NoContent();
        }

       
>>>>>>> 9ede5b53204b9790adbddcb851128e74f0a8cb95
    }
}
