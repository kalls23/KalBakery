using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalBakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KalBakery.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakesController : Controller
    {
        private readonly BakeryDbContext _context;

        public CakesController(BakeryDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Cake> GetCakes()
        {
            return _context.Cakes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCake(int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cake = await _context.Cakes.FindAsync(id);

            if(cake == null)
            {
                return NotFound();
            }
            return Ok(cake);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> PostCake([FromBody]Cake cake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cakes.Add(cake);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCake", new { id = cake.CakeId }, cake);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute]int id, [FromBody] Cake cake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cake.CakeId)
            {
                return BadRequest();
            }

            _context.Entry(cake).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CakeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cake = await _context.Cakes.FindAsync(id);
            if (cake == null)
            {
                return NotFound();
            }

            _context.Cakes.Remove(cake);
            await _context.SaveChangesAsync();

            return Ok(cake);
        }

        private bool CakeExists(int id)
        {
            return _context.Cakes.Any(e => e.CakeId == id);
        }
    }
}
