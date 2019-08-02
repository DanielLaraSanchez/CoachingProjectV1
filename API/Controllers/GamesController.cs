using DataLayer.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using API.Requests;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IPoolChampionService _poolChampionService;

        public GamesController(IPoolChampionService poolChanpionService)
        {
            _poolChampionService = poolChanpionService;
        }

        [HttpGet("getgames")]
        public async Task<ActionResult<Game>> GetAllGames()
        {
            var games = await _poolChampionService.GetAllGames();
            return Ok(games);
        }

        [HttpPost("creategame")]
        public async Task<ActionResult<Game>> CreateGame([FromBody]GameRequest game)
        {
            Domain.Game newGame = new Domain.Game(game.Player1, game.Player2);
            newGame.Creator = game.Creator;
            newGame.Winner = game.Winner;

            await _poolChampionService.CreateGame(newGame);
            return Ok(newGame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ConfirmGame(long playerId, long gameId)
        {
            return new OkObjectResult(await _poolChampionService.Confirm(playerId, gameId));
        }


    }
}
