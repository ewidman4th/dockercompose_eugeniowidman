using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dockertraining_compose_eugeniowidman.Models;

namespace dockertraining_compose_eugeniowidman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacketController : ControllerBase
    {
        private readonly RacketContext db;

        public RacketController(RacketContext context)
        {
            db = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRacket(int id)
        {
            var racket = await db.Rackets.FindAsync(id);

            if (racket == default(Racket))
                return NotFound();

            return Ok(racket);
        }

        [HttpPost]
        public async Task<IActionResult> AddRacket([FromBody] Racket racket)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await db.AddAsync(racket);
            await db.SaveChangesAsync();

            return Ok(racket.Id);
        }

        /*[HttpPost]
        public async Task<IActionResult> DeleteRacket(int id)
        {
            var racket = await db.Rackets.FindAsync(id);

            if (racket == default(Racket))
                return NotFound();
            else
            {
                db.Remove(racket);
                await db.SaveChangesAsync();
            }

            return Ok();
        }*/
    }
}
