using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExerciceConnectLime.Models;

namespace ExerciceConnectLime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingularPersonsController : ControllerBase
    {
        private readonly DataContext _context;

        public SingularPersonsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/SingularPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingularPerson>>> GetSingularPersons()
        {
            return await _context.SingularPersons.ToListAsync();
        }

        // GET: api/SingularPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingularPerson>> GetSingularPerson(long id)
        {
            var singularPerson = await _context.SingularPersons.FindAsync(id);

            if (singularPerson == null)
            {
                return NotFound();
            }

            return singularPerson;
        }

        // PUT: api/SingularPersons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingularPerson(long id, SingularPerson singularPerson)
        {
            if (id != singularPerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(singularPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingularPersonExists(id))
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

        // POST: api/SingularPersons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingularPerson>> PostSingularPerson(SingularPerson singularPerson)
        {
            _context.SingularPersons.Add(singularPerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSingularPerson), new { id = singularPerson.Id }, singularPerson);
        }

        // DELETE: api/SingularPersons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingularPerson(long id)
        {
            var singularPerson = await _context.SingularPersons.FindAsync(id);
            if (singularPerson == null)
            {
                return NotFound();
            }

            _context.SingularPersons.Remove(singularPerson);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingularPersonExists(long id)
        {
            return _context.SingularPersons.Any(e => e.Id == id);
        }
    }
}
