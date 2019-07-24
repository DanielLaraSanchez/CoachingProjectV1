using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPoolChampionService _poolChampion;

        public PlayersController(IPoolChampionService poolChampion)
        {
            _poolChampion = poolChampion;
        }

        public async Task<ActionResult> GetPlayers()
        {
           return new OkObjectResult( await _poolChampion.GetAllPlayers()); // only returns name and Id.
           
        }
        [HttpPost("{signup}")]
        public async Task<ActionResult> SignUp(PlayerRequest player)
        {

            if (ModelState.IsValid)
            {
                var newPlayer = await _poolChampion.AddPlayer(player.Name, player.EmailAddress, player.Password);
                return Ok(newPlayer); // all params EXCEPT id

            }

            return NotFound();
        }
    }
}
