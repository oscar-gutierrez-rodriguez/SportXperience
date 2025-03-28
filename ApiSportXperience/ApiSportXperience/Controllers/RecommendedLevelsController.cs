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
    public class RecommendedLevelsController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public RecommendedLevelsController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/RecommendedLevels
        [HttpGet]
        [Route("api/recommendedLevel")]
        public async Task<ActionResult<IEnumerable<RecommendedLevel>>> GetRecommendedLevels()
        {
            return await _context.RecommendedLevels.ToListAsync();
        }

        // GET: api/RecommendedLevels/5
        [HttpGet]
        [Route("api/recommendedLevel/{id}")]
        public async Task<ActionResult<RecommendedLevel>> GetRecommendedLevel(int id)
        {
            var recommendedLevel = await _context.RecommendedLevels.FindAsync(id);

            if (recommendedLevel == null)
            {
                return NotFound();
            }

            return recommendedLevel;
        }
        
    }
}
