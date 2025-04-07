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
    public class UbicationsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public UbicationsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Ubications
        [HttpGet]
        [Route("api/ubications")]
        public async Task<ActionResult<IEnumerable<Ubication>>> GetUbications()
        {
            return await _context.Ubications.ToListAsync();
        }

        // GET: api/Ubications/5
        [HttpGet]
        [Route("api/ubications/{id}")]
        public async Task<ActionResult<Ubication>> GetUbication(int id)
        {
            var ubication = await _context.Ubications.FindAsync(id);

            if (ubication == null)
            {
                return NotFound();
            }

            return ubication;
        }

        [HttpGet]
        [Route("api/ubications/{latitude}/{longitude}")]
        public async Task<ActionResult<Ubication>> GetUbicationByLatitudeLongitude(float latitude, float longitude)
        {
            var ubication = await _context.Ubications.Where(x => x.Latitude == latitude && x.Longitude == longitude).FirstOrDefaultAsync();

            if (ubication == null)
            {
                return NotFound();
            }

            return ubication;
        }

        // PUT: api/Ubications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("api/ubications/{id}")]
        public async Task<IActionResult> PutUbication(int id, [FromBody] Ubication ubication)
        {
            if (id != ubication.UbicationId)
            {
                return BadRequest();
            }

            _context.Entry(ubication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UbicationExists(id))
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

        // POST: api/Ubications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/ubications")]
        public async Task<ActionResult<Ubication>> PostUbication( [FromBody] Ubication ubication)
        {
            _context.Ubications.Add(ubication);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUbication", new { id = ubication.UbicationId }, ubication);
        }

        // DELETE: api/Ubications/5
        [HttpDelete]
        [Route("api/ubications/{id}")]
        public async Task<IActionResult> DeleteUbication(int id)
        {
            var ubication = await _context.Ubications.FindAsync(id);
            if (ubication == null)
            {
                return NotFound();
            }

            _context.Ubications.Remove(ubication);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UbicationExists(int id)
        {
            return _context.Ubications.Any(e => e.UbicationId == id);
        }
    }
}
