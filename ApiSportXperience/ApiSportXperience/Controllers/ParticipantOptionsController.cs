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
    public class ParticipantOptionsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public ParticipantOptionsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/ParticipantOptions
        [HttpGet]
        [Route("api/participantsOptions")]
        public async Task<ActionResult<IEnumerable<ParticipantOption>>> GetParticipantOptions()
        {
            return await _context.ParticipantOptions.ToListAsync();
        }

        [HttpGet]
        [Route("api/participantsOptions/{id}")]
        public async Task<ActionResult<ParticipantOption>> GetParticipantOption(int id)
        {
            var participantOption = await _context.ParticipantOptions.Where(x => x.ParticipantOptionId == id).FirstOrDefaultAsync();

            if (participantOption == null)
            {
                return NotFound();
            }

            return participantOption;
        }

        [HttpGet]
        [Route("api/participantsOptions/option/{id}")]
        public async Task<ActionResult<IEnumerable<ParticipantOption>>> GetParticipantOptionByOptionId(int id)
        {
            var participantOption = await _context.ParticipantOptions.Where(x => x.OptionId == id).ToListAsync();

            if (participantOption == null)
            {
                return NotFound();
            }

            return participantOption;
        }

        [HttpGet]
        [Route("api/participantsOptions/participant/{dni}")]
        public async Task<ActionResult<IEnumerable<ParticipantOption>>> GetParticipantOptionByParticipantDni(string dni)
        {
            var participantOption = await _context.ParticipantOptions.Where(x => x.UserDni.Equals(dni)).ToListAsync();

            if (participantOption == null)
            {
                return NotFound();
            }

            return participantOption;
        }


        [HttpGet]
        [Route("api/participantsOptions/{id}/{dni}")]
        public async Task<ActionResult<ParticipantOption>> GetParticipantOptionByParticipantDni(int id ,string dni)
        {
            var participantOption = await _context.ParticipantOptions.Where(x => x.UserDni.Equals(dni) && x.OptionId == id).FirstOrDefaultAsync();

            if (participantOption == null)
            {
                return NotFound();
            }

            return participantOption;
        }


        // PUT: api/ParticipantOptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("api/participantsOptions/{id}")]
        public async Task<IActionResult> PutParticipantOption(int id, [FromBody] ParticipantOption participantOption)
        {
            if (id != participantOption.ParticipantOptionId)
            {
                return BadRequest();
            }

            _context.Entry(participantOption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParticipantOptionExists(id))
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

        // POST: api/ParticipantOptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/participantsOptions")]
        public async Task<ActionResult<ParticipantOption>> PostParticipantOption( [FromBody] ParticipantOption participantOption)
        {
            _context.ParticipantOptions.Add(participantOption);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParticipantOption", new { id = participantOption.ParticipantOptionId }, participantOption);
        }

        // DELETE: api/ParticipantOptions/5
        [HttpDelete]
        [Route("api/participantsOptions/{id}")]
        public async Task<IActionResult> DeleteParticipantOption(int id)
        {
            var participantOption = await _context.ParticipantOptions.FindAsync(id);
            if (participantOption == null)
            {
                return NotFound();
            }

            _context.ParticipantOptions.Remove(participantOption);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParticipantOptionExists(int id)
        {
            return _context.ParticipantOptions.Any(e => e.ParticipantOptionId == id);
        }
    }
}
