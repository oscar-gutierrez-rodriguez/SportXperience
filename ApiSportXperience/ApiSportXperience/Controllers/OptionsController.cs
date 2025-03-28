using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSportXperience.Models;

namespace ApiSportXperience.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public OptionsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Options
        [HttpGet]
        [Route("api/options/products/{id}")]
        public async Task<ActionResult<IEnumerable<Option>>> GetOptionsByProduct(int id)
        {
            return await _context.Options.Where(x => x.ProductId == id).ToListAsync();
        }

        // GET: api/Options/5
        [HttpGet]
        [Route("api/options/{id}")]
        public async Task<ActionResult<Option>> GetOption(int id)
        {
            var option = await _context.Options.FindAsync(id);

            if (option == null)
            {
                return NotFound();
            }

            return option;
        }

        // PUT: api/Options/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("api/options/{id}")]
        public async Task<IActionResult> PutOption(int id, [FromBody] Option option)
        {
            if (id != option.OptionId)
            {
                return BadRequest();
            }

            _context.Entry(option).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OptionExists(id))
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

        // POST: api/Options
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/options")]
        public async Task<ActionResult<Option>> PostOption( [FromBody] Option option)
        {
            _context.Options.Add(option);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOption", new { id = option.OptionId }, option);
        }

        // DELETE: api/Options/5
        [HttpDelete]
        [Route("api/options/{id}")]
        public async Task<IActionResult> DeleteOption(int id)
        {
            var option = await _context.Options.FindAsync(id);
            if (option == null)
            {
                return NotFound();
            }

            _context.Options.Remove(option);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OptionExists(int id)
        {
            return _context.Options.Any(e => e.OptionId == id);
        }
    }
}
