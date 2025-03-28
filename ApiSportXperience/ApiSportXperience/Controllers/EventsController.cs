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
    public class EventsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public EventsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Events
        [HttpGet]
        [Route("api/events")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        [HttpGet]
        [Route("api/events/{userdni}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEventByOrganizer(String userdni)
        {
            return await _context.Events.Where(e => e.Participants.Any(p => p.UserDni.Equals(userdni) && p.Organizer == true)).ToListAsync();
        }

        [HttpGet]
        [Route("api/events/{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            Event e = await _context.Events.FindAsync(id);

            if (e == null)
            {
                return NotFound();
            }

            return e;
        }

        // PUT: api/Events/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754        
        [HttpPut]
        [Route("api/events/{id}")]
        public async Task<IActionResult> PutEvent(int id, [FromBody] Event e)
        {
            if (id != e.EventId)
            {
                return BadRequest();
            }

            _context.Entry(e).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
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

        // POST: api/Events
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754        
        [HttpPost]
        [Route("api/events")]
        public async Task<ActionResult<Event>> PostEvent([FromBody] Event e)
        {
            _context.Events.Add(e);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvent", new { id = e.EventId }, e);
        }

        // DELETE: api/Events/5        
        [HttpDelete]
        [Route("api/events/{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}
