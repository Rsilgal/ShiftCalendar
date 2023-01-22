using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShiftCalendar.Data;
using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PersonModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonModel>>> GetPersons()
        {
            return await _context.Persons.ToListAsync();
        }

        // GET: api/PersonModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonModel>> GetPersonModel(int id)
        {
            var personModel = await _context.Persons.FindAsync(id);

            if (personModel == null)
            {
                return NotFound();
            }

            return personModel;
        }

        // PUT: api/PersonModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonModel(int id, PersonModel personModel)
        {
            if (id != personModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(personModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonModelExists(id))
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

        // POST: api/PersonModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonModel>> PostPersonModel(PersonModel personModel)
        {
            _context.Persons.Add(personModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonModel", new { id = personModel.Id }, personModel);
        }

        // DELETE: api/PersonModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonModel(int id)
        {
            var personModel = await _context.Persons.FindAsync(id);
            if (personModel == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(personModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonModelExists(int id)
        {
            return _context.Persons.Any(e => e.Id == id);
        }
    }
}
