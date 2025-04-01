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
    public class UsersController : ControllerBase
    {
        private readonly SportXperienceContext _context;

        public UsersController(SportXperienceContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        [Route("api/users")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet]
        [Route("api/users/username/{username}")]
        public async Task<ActionResult<User>> GetUserByUsername(string username)
        {
            var user = await _context.Users.Where(x => x.Username.Equals(username)).FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet]
        [Route("api/users/mail/{mail}")]
        public async Task<ActionResult<User>> GetUserByMail(string mail)
        {
            var user = await _context.Users.Where(x => x.Mail.Equals(mail)).FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet]
        [Route("api/users/dni/{dni}")]
        public async Task<ActionResult<User>> GetUserByDni(string dni)
        {
            var user = await _context.Users.Where(x => x.Dni.Equals(dni)).FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }


        [HttpGet]
        [Route("api/users/{usernameOrMail}/{password}")]
        public async Task<ActionResult<User>> GetUserAndPassword(string usernameOrMail, string password)
        {
            var user = await _context.Users.Where(x => (x.Username.Equals(usernameOrMail) || x.Mail.Equals(usernameOrMail)) && x.Password.Equals(password)).FirstOrDefaultAsync();

            if (user == null)
            {
                return null;
            }

            return user;
        }



        [HttpPost]
        [Route("api/users")]
        public async Task<ActionResult<User>> PostUser([FromBody] User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = user.Dni }, user);
        }


        // DELETE: api/Users/5
        [HttpDelete]
        [Route("api/users/{dni}")]
        public async Task<IActionResult> DeleteUser(string dni)
        {
            var user = await _context.Users.FindAsync(dni);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(string dni)
        {
            return _context.Users.Any(e => e.Dni == dni);
        }
    }
}