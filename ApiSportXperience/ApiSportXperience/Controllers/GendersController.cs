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
    public class GendersController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public GendersController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Genders
        [HttpGet]
        [Route("api/gender")]
        public async Task<ActionResult<IEnumerable<Gender>>> GetGenders()
        {
            return await _context.Genders.ToListAsync();
        }

        // GET: api/Genders/5
        [HttpGet]
        [Route("api/gender/{id:int}")]
        public async Task<ActionResult<Gender>> GetGender(int id)
        {
            var gender = await _context.Genders.FindAsync(id);

            if (gender == null)
            {
                return NotFound();
            }

            return gender;
        }

        [HttpGet]
        [Route("api/gender/{name}")]
        public async Task<ActionResult<Gender>> GetGenderByName(String name)
        {
            var gender = await _context.Genders.Where(x => x.Name.Equals(name)).FirstOrDefaultAsync();

            if (gender == null)
            {
                return NotFound();
            }

            return gender;
        }

    }
}
