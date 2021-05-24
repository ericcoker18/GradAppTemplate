using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Models;
using App.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.ApiModels;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionController : ControllerBase
    {
        private readonly IChampionServices _championServices;
        public ChampionController(IChampionServices championService)
        {
            _championServices = championService;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_championServices.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_championServices.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ChampionModel champion)
        {
            _championServices.Add(champion.ToDomainModel());
            return CreatedAtAction("Get", new { Id = champion.Id }, champion);

        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ChampionModel champions)
        {
            var champion = _championServices.Update(champions.ToDomainModel());
            return Ok(champion.ToApiModel());


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _championServices.Remove(id);
            // ADD NULL
            return NoContent();
        }
    }
}
