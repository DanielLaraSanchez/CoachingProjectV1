using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class RankingController : Controller
    {
        private readonly IPoolChampionService _poolChampion;

        public RankingController(IPoolChampionService poolChampion)
        {
            _poolChampion = poolChampion;
        }
        
        [HttpGet("{getranking}")]
        public async Task<ActionResult> GetRanking()
        {

            var ranking = await _poolChampion.GetRanking();
            return  Ok(ranking);
        }
    }


}