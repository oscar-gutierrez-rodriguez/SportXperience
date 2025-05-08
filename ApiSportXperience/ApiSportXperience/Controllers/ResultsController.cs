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
    public class ResultsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public ResultsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Results
        [HttpGet]
        [Route("api/results/events/{eventId}")]
        public async Task<ActionResult<IEnumerable<ResultDTO>>> GetResultsByEvent(int eventId)
        {
            return await _context.Results.Where(x => x.EventId == eventId)
               .Select(x => new ResultDTO
               {
                   ResultId = x.ResultId,
                   EventId = x.EventId,
                   UserDni = x.UserDni,
                   Name = _context.Users.Where(y => y.Dni == x.UserDni).FirstOrDefault().Username,
                   Position = x.Position
               }).ToListAsync();
        }

        [HttpGet]
        [Route("api/results/users/{userDni}")]
        public async Task<ActionResult<IEnumerable<Result>>> GetResultsByUser(string userDni)
        {
            return await _context.Results.Where(x => x.UserDni.Equals(userDni)).ToListAsync();
        }

        // GET: api/Results/5
        [HttpGet]
        [Route("api/results/{id}")]
        public async Task<ActionResult<Result>> GetResult(int id)
        {
            var result = await _context.Results.FindAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }


        [HttpGet]
        [Route("api/results/{eventId}/{userDni}")]
        public async Task<ActionResult<Result>> GetResult(int eventId, string userDni)
        {
            var result = await _context.Results.Where(x => x.EventId == eventId && x.UserDni.Equals(userDni)).FirstOrDefaultAsync();

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        // PUT: api/Results/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("api/results/{id}")]
        public async Task<IActionResult> PutResult(int id, [FromBody] Result result)
        {
            if (id != result.ResultId)
            {
                return BadRequest();
            }

            _context.Entry(result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultExists(id))
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

        // POST: api/Results
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("api/results")]
        public async Task<ActionResult<Result>> PostResult( [FromBody] Result result)
        {
            _context.Results.Add(result);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResult", new { id = result.ResultId }, result);
        }

        // DELETE: api/Results/5
        [HttpDelete]
        [Route("api/results/{id}")]
        public async Task<IActionResult> DeleteResult(int id)
        {
            var result = await _context.Results.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            _context.Results.Remove(result);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResultExists(int id)
        {
            return _context.Results.Any(e => e.ResultId == id);
        }
    }
}
