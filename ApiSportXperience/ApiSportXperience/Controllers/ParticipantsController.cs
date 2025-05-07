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
    public class ParticipantsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public ParticipantsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Participants

        [HttpGet]
        [Route("api/participants")]
        public async Task<ActionResult<IEnumerable<Participant>>> GetParticipants()
        {
            return await _context.Participants.ToListAsync();
        }

        [HttpGet]
        [Route("api/participants/{eventId:int}")]
        public async Task<ActionResult<IEnumerable<Participant>>> GetParticipantsByEvent(int eventId)
        {
            return await _context.Participants.Where(x => x.EventId == eventId).ToListAsync();
        }

        [HttpGet]
        [Route("api/participants/noorganizer/{eventId}")]
        public async Task<ActionResult<IEnumerable<ParticipantDTO>>> GetNoOrganizerByEvent(int eventId)
        {
            return await _context.Participants
               .Where(x => x.EventId == eventId && x.Organizer == false)
               .Select(x => new ParticipantDTO
               {
                   Organizer = x.Organizer,
                   EventId = x.EventId,
                   UserDni = x.UserDni,
                   username = _context.Users.Where(y => y.Dni == x.UserDni).FirstOrDefault().Username,
               }).ToListAsync();
        }

        [HttpGet]
        [Route("api/participants/organizer/{eventId}")]
        public async Task<ActionResult<Participant>> GetOrganizerByEvent(int eventId)
        {
            return await _context.Participants.Where(x => x.EventId == eventId && x.Organizer == true).FirstOrDefaultAsync();
        }

        // GET: api/Participants/5
        [HttpGet]
        [Route("api/participants/{id}")]
        public async Task<ActionResult<Participant>> GetParticipantByDni(string dni)
        {
            var participant = await _context.Participants.Where(x => x.UserDni.Equals(dni)).FirstOrDefaultAsync();

            if (participant == null)
            {
                return NotFound();
            }

            return participant;
        }

        // PUT: api/Participants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("api/participants/{id}")]
        public async Task<IActionResult> PutParticipant(int id, [FromBody] Participant participant)
        {
            if (id != participant.EventId)
            {
                return BadRequest();
            }

            _context.Entry(participant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParticipantExists(id))
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

        // POST: api/Participants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/participants")]
        public async Task<ActionResult<Participant>> PostParticipant([FromBody] Participant participant)
        {
            _context.Participants.Add(participant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParticipants", new { id = participant.EventId }, participant);
        }

        // DELETE: api/Participants/5
        [HttpDelete]
        [Route("api/participants/{eventId}/{userDni}")]
        public async Task<IActionResult> DeleteParticipant(int eventId, string userDni)
        {
            var participant = await _context.Participants.Where(x => x.EventId == eventId && x.UserDni.Equals(userDni)).FirstOrDefaultAsync();
            if (participant == null)
            {
                return NotFound();
            }

            _context.Participants.Remove(participant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParticipantExists(int id)
        {
            return _context.Participants.Any(e => e.EventId == id);
        }
    }
}
