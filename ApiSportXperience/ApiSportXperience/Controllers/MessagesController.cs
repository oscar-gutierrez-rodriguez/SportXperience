using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSportXperience.Models;
using Microsoft.Extensions.Logging;

namespace ApiSportXperience.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public MessagesController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Messages
        [HttpGet]
        [Route("api/messages/comments/{eventId}")]
        public async Task<ActionResult<IEnumerable<MessageDTO>>> GetMessagesByEvent(int eventId)
        {
            return await _context.Messages.Where(x => x.EventId == eventId && x.PublicMessage == true)
                .Select( x => new MessageDTO
                {
                    MessageId = x.MessageId,
                    Comment = x.Comment,
                    PublicMessage = x.PublicMessage,
                    PublishedDate = x.PublishedDate,
                    UserDni = x.UserDni,
                    DniOrganizer = _context.Participants.Where(y => y.EventId == x.EventId && y.Organizer == true).FirstOrDefault().UserDni,
                    UsernameOrganizer = _context.Users.Where(y => y.Dni.Equals(_context.Participants.Where(y => y.EventId == x.EventId && y.Organizer == true).FirstOrDefault().UserDni)).FirstOrDefault().Username
                })
                .ToListAsync();
        }


        // GET: api/Messages
        [HttpGet]
        [Route("api/messages/chat/{eventId}")]
        public async Task<ActionResult<IEnumerable<MessageDTO>>> GetMessagesChatByEvent(int eventId)
        {
            return await _context.Messages.Where(x => x.EventId == eventId && x.PublicMessage == false)
                .Select(x => new MessageDTO
                {
                    MessageId = x.MessageId,
                    Comment = x.Comment,
                    PublicMessage = x.PublicMessage,
                    PublishedDate = x.PublishedDate,
                    UserDni = x.UserDni,
                    DniOrganizer = _context.Participants.Where(y => y.EventId == x.EventId && y.Organizer == true).FirstOrDefault().UserDni,
                    UsernameOrganizer = _context.Users.Where(y => y.Dni.Equals(_context.Participants.Where(y => y.EventId == x.EventId && y.Organizer == true).FirstOrDefault().UserDni)).FirstOrDefault().Username
                })
                .ToListAsync();
        }


        [HttpGet]
        [Route("api/messages/user/{dniUser}/{eventId}")]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessagesByUser(string dniUser, int eventId)
        {
            return await _context.Messages.Where(x => x.UserDni.Equals(dniUser) && x.EventId == eventId).ToListAsync();
        }

        [HttpGet]
        [Route("api/messages/organizer/{dniUser}/{eventId}")]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessagesOrganizer(string dniUser, int eventId)
        {
            return await _context.Messages.Where(x => x.UserDni.Equals(dniUser) && x.EventId == eventId).ToListAsync();
        }

        [HttpGet]
        [Route("api/messages/{comment}/{eventId}")]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessagesFiltre(String comment, int eventId)
        {
            return await _context.Messages.Where(x => x.Comment.Contains(comment) && x.EventId == eventId).ToListAsync();
        }


        // PUT: api/Messages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("api/messages/{id}")]
        public async Task<IActionResult> PutMessage(int id, [FromBody] Message message)
        {
            if (id != message.MessageId)
            {
                return BadRequest();
            }

            _context.Entry(message).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessageExists(id))
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

        // POST: api/Messages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/messages")]
        public async Task<ActionResult<Message>> PostMessage( [FromBody] Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessage", new { id = message.MessageId }, message);
        }

        // DELETE: api/Messages/5
        [HttpDelete]
        [Route("api/messages/{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var message = await _context.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }

            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessageExists(int id)
        {
            return _context.Messages.Any(e => e.MessageId == id);
        }
    }
}
