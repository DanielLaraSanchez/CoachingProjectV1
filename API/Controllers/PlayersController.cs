using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Entities;
using DataLayer.Entities.Repository;

//why are things not asynchronous?

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {

        public IDataRepository<Player> _dataRepository { get; }

        public PlayersController(IDataRepository<Player> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Players
        [HttpGet]
        public ActionResult<IEnumerable<Player>> GetPlayers()
        {
            IEnumerable<Player> players = _dataRepository.GetAll();
            return Ok(players);
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public ActionResult<Player> GetPlayer(long id)
        {
            Player player = _dataRepository.Get(id);
            if (player == null)
            {
                return NotFound();
            }

            return player;
        }

        // PUT: api/Players/5
        [HttpPut("{id}")]
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
            return NoContent();
        }

        // POST: api/Players
        [HttpPost]
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
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
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

       
    }
}
