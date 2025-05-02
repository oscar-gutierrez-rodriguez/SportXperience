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
    public class LotsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public LotsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Lots
        [HttpGet]
        [Route("api/lots")]
        public async Task<ActionResult<IEnumerable<Lot>>> GetLots()
        {
            return await _context.Lots.ToListAsync();
        }

        // GET: api/Lots/5
        [HttpGet]
        [Route("api/lots/{id}")]
        public async Task<ActionResult<Lot>> GetLotById(int id)
        {
            var lot = await _context.Lots.Where(x => x.EventId == id).FirstOrDefaultAsync();

            if (lot == null)
            {
                return NotFound();
            }

            return lot;
        }

        [HttpGet]
        [Route("api/lots/max")]
        public async Task<int> GetLotMax()
        {
            int maxId = await _context.Lots.MaxAsync(x => x.LotId);

            return maxId;

        }

        // PUT: api/Lots/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("api/lots/{id}")]
        public async Task<IActionResult> PutLot(int id, [FromBody] Lot lot)
        {
            if (id != lot.LotId)
            {
                return BadRequest();
            }

            _context.Entry(lot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LotExists(id))
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

        // POST: api/Lots
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/lots")]
        public async Task<ActionResult<Lot>> PostLot( [FromBody] Lot lot)
        {
            _context.Lots.Add(lot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLotById", new { id = lot.LotId }, lot);
        }

        // DELETE: api/Lots/5
        [HttpDelete]
        [Route("api/lots/{id}")]
        public async Task<IActionResult> DeleteLot(int id)
        {
            var lot = await _context.Lots.FindAsync(id);
            if (lot == null)
            {
                return NotFound();
            }

                List<Product> products = await _context.Products.Where(x => x.LotId == lot.LotId).ToListAsync();

                List<Option> options = new List<Option>();

                foreach (Product p in products)
                {
                    List<Option> o = await _context.Options.Where(x => x.ProductId == p.ProductId).ToListAsync();
                    options.AddRange(o);
                }
                if (options.Count > 0)
                {
                    _context.Options.RemoveRange(options);
                }

                if (products.Count > 0)
                {
                    _context.Products.RemoveRange(products);
                }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LotExists(int id)
        {
            return _context.Lots.Any(e => e.LotId == id);
        }
    }
}
