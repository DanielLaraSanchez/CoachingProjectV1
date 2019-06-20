﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class RankingController : Controller
    {
        private readonly IPoolChampionService _poolChampion;
        
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return new OkObjectResult (await _poolChampion.GetRanking());
        }
    }
}