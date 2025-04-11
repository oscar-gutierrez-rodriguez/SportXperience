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
        public async Task<ActionResult<IEnumerable<EventDTO>>> GetEvents()
        {
            return await _context.Events
                .Select(x => new EventDTO
                {
                    EventId = x.EventId,
                    Name = x.Name,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Image = x.Image,
                    Description = x.Description,
                    MinAge = x.MinAge,
                    MaxAge = x.MaxAge,
                    MaxParticipantsNumber = x.MaxParticipantsNumber,
                    Price = x.Price,
                    Reward = x.Reward,
                    UbicationId = x.UbicationId,
                    RecommendedLevelId = x.RecommendedLevelId,
                    SportId = x.SportId,
                    RecommendedLevelName = _context.RecommendedLevels.Where(y => y.RecommendedLevelId == x.RecommendedLevelId).FirstOrDefault().Name,
                    SportName = _context.Sports.Where(y => y.SportId == x.SportId).FirstOrDefault().Name,
                    cityName = _context.Ubications.Where(y => y.UbicationId == x.UbicationId).FirstOrDefault().CityName
                })
                .ToListAsync();
        }

        [HttpGet]
        [Route("api/events/{lat}/{lon}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents(float lat, float lon)
        {
            // Obtener todos los eventos con sus relaciones (incluyendo Ubicacion)
            var events = await _context.Events
                .ToListAsync();

            // Ordenar los eventos por distancia a la ubicación proporcionada
            var eventosOrdenados = events
                .Select(e => new
                {
                    Evento = e,
                    Distancia = Localitzacio.CalcularDistancia(lat, lon, (float)e.Ubication.Latitude, (float)e.Ubication.Longitude)
                })
                .OrderBy(x => x.Distancia)
                .Select(x => x.Evento)  // Devolver solo los eventos
                .ToList();

            return Ok(eventosOrdenados); // Retornamos la lista de eventos ordenada
        }


        [HttpGet]
        [Route("api/events/max")]
        public async Task<ActionResult<Event>> GetEventMax()
        {
            int maxId = await _context.Events.MaxAsync(x => x.EventId);

            return await _context.Events
                .Where(x => x.EventId == maxId).FirstOrDefaultAsync();
        }

        [HttpGet]
        [Route("api/events/{userdni}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEventByOrganizer(String userdni)
        {
            return await _context.Events
                .Where(e => e.Participants.Any(p => p.UserDni.Equals(userdni) && p.Organizer == true)).ToListAsync();
        }

        [HttpGet]
        [Route("api/events/{pagament}/{data}/{ubicacio}/{esport}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEventFiltre(int? pagament, DateTime? data, string? ubicacio, string? esport)
        {
            IQueryable<Event> query = _context.Events;

            if (pagament != null)
            {
                switch (pagament)
                {
                    case 0:
                        query = query.Where(x => x.Price == 0);
                        break;
                    case 1:
                        query = query.Where(x => x.Price > 0);
                        break;

                }
            }

            if (data != null)
            {
                query = query.Where(x => x.EndDate <= data && x.StartDate >= data);
            }

            if (!string.IsNullOrEmpty(ubicacio))
            {
                query = query.Where(x => x.Ubication.CityName.Contains(ubicacio));
            }

            if (!string.IsNullOrEmpty(esport))
            {
                query = query.Where(x => x.Sport.Name.Contains(esport));
            }

            var result = await query
                .ToListAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("api/events/{id:int}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            Event e = await _context.Events
                .Where( x => x.EventId == id).FirstOrDefaultAsync();

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

            if (e.Sport != null)
            {
                 _context.Attach(e.Sport);
            }

            return CreatedAtAction("GetEvent", new { id = e.EventId }, e);
        }

        // DELETE: api/Events/5        
        [HttpDelete]
        [Route("api/events/{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var e = await _context.Events.FindAsync(id);
            if (e == null)
            {
                return NotFound();
            }



            _context.Events.Remove(e);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        [Route("api/events/all/{id}")]
        public async Task<IActionResult> DeleteAllEvent(int id)
        {
            var e = await _context.Events.FindAsync(id);
            if (e == null)
            {
                return NotFound();
            }

            List<Participant> part = await _context.Participants.Where(x => x.EventId == e.EventId).ToListAsync();

            Lot l = await _context.Lots.Where(x => x.EventId == e.EventId).FirstOrDefaultAsync();

            if (l != null)
            {

                List<Product> products = await _context.Products.Where(x => x.LotId == l.LotId).ToListAsync();

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

                
                 _context.Lots.Remove(l);
                
            }

            _context.Participants.RemoveRange(part);

            _context.Messages.RemoveRange(e.Messages);

            _context.Events.Remove(e);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}
