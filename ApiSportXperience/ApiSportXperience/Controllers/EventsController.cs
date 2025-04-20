using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSportXperience.Models;
using Humanizer;
using Microsoft.Extensions.Logging;

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
                    cityName = _context.Ubications.Where(y => y.UbicationId == x.UbicationId).FirstOrDefault().CityName,
                    latitude = _context.Ubications.Where(y => y.UbicationId == x.UbicationId).FirstOrDefault().Latitude,
                    longitude = _context.Ubications.Where(y => y.UbicationId == x.UbicationId).FirstOrDefault().Longitude
                })
                .ToListAsync();
        }

        [HttpGet]
        [Route("api/events/{lat}/{lon}")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents(float lat, float lon)
        {
            var events = await _context.Events
                .ToListAsync();

            var eventosOrdenados = events
                .Select(e => new
                {
                    Evento = e,
                    Distancia = Localitzacio.CalcularDistancia(lat, lon, (float)e.Ubication.Latitude, (float)e.Ubication.Longitude)
                })
                .OrderBy(x => x.Distancia)
                .Select(x => x.Evento)
                .ToList();

            return Ok(eventosOrdenados);
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
        [Route("api/events/{pagament}/{data}/{ubicacio}/{esport}/{latitude}/{longitude}")]
        public async Task<ActionResult<IEnumerable<EventDTO>>> GetEventFiltre([FromQuery] int? pagament, [FromQuery] DateTime? data, [FromQuery] string? ubicacio, [FromQuery] string? esport, float latitude, float longitude)
        {
            List<EventDTO> query = await _context.Events
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
                    cityName = _context.Ubications.Where(y => y.UbicationId == x.UbicationId).FirstOrDefault().CityName,
                    latitude = _context.Ubications.Where(y => y.UbicationId == x.UbicationId).FirstOrDefault().Latitude,
                    longitude = _context.Ubications.Where(y => y.UbicationId == x.UbicationId).FirstOrDefault().Longitude
                })
                .ToListAsync();

            if (pagament != null)
            {
                switch (pagament)
                {
                    case 0:
                        query = query.Where(x => x.Price == 0).ToList();
                        break;
                    case 1:
                        query = query.Where(x => x.Price > 0).ToList();
                        break;

                }
            }


            if (data != null)
            {
                query = query.Where(x => x.StartDate <= data && x.EndDate >= data).ToList();
            }

            if (!string.IsNullOrWhiteSpace(ubicacio) && ubicacio.ToLower() != "null")
            {
                query = query.Where(x => !string.IsNullOrEmpty(x.cityName) && x.cityName.Contains(ubicacio, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(esport) && esport.ToLower() != "null")
            {
                query = query.Where(x => !string.IsNullOrEmpty(x.SportName) && x.SportName.Contains(esport, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            var orderedEvents = query
                //.Select(e => new
                //{
                //    Evento = e,
                //    Distancia = Localitzacio.CalcularDistancia(latitude, longitude, (float)e.latitude, (float)e.longitude)
                //})
                //.OrderBy(x => x.Distancia)
                //.Select(x => x.Evento)
                .ToList();

            return orderedEvents;
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


        [HttpPost]
        [Route("api/events/image")]
        public async Task<ActionResult<Event>> PostImage(IFormFile imagen)
        {

            var nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(imagen.FileName);
            var rutaCarpeta = Path.Combine(Directory.GetCurrentDirectory(), "Images");
            var rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

            if (!Directory.Exists(rutaCarpeta))
                Directory.CreateDirectory(rutaCarpeta);

            using (var stream = new FileStream(rutaCompleta, FileMode.Create))
            {
                await imagen.CopyToAsync(stream);
            }

            //var url = $"{Request.Scheme}://{Request.Host}/Images/{nombreArchivo}";
            var url = $"Images/{nombreArchivo}";
            return Ok(new { url });
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
