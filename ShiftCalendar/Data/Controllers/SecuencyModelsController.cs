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
    public class SecuencyModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SecuencyModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SecuencyModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SecuencyModel>>> GetSecuencies()
        {
            return await _context.Secuencies.ToListAsync();
        }

        // GET: api/SecuencyModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SecuencyModel>> GetSecuencyModel(int id)
        {
            var secuencyModel = await _context.Secuencies.FindAsync(id);

            if (secuencyModel == null)
            {
                return NotFound();
            }

            return secuencyModel;
        }

        // PUT: api/SecuencyModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable<SecuencyModel>>> PutSecuencyModel(int id, SecuencyModel secuencyModel)
        {
            if (id != secuencyModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(secuencyModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SecuencyModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return NoContent();
            var secuencies = await GetSecuencies();
            return Ok(secuencies);
        }

        // POST: api/SecuencyModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IEnumerable<SecuencyModel>>> PostSecuencyModel(SecuencyModel secuencyModel)
        {
            _context.Secuencies.Add(secuencyModel);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetSecuencyModel", new { id = secuencyModel.Id }, secuencyModel);
            var secuencies = await GetSecuencies();
            return Ok(secuencies);
        }

        // DELETE: api/SecuencyModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<SecuencyModel>>> DeleteSecuencyModel(int id)
        {
            var secuencyModel = await _context.Secuencies.FindAsync(id);
            if (secuencyModel == null)
            {
                return NotFound();
            }

            _context.Secuencies.Remove(secuencyModel);
            await _context.SaveChangesAsync();

            //return NoContent();
            var secuencies = await GetSecuencies();
            return Ok(secuencies);
        }

        private bool SecuencyModelExists(int id)
        {
            return _context.Secuencies.Any(e => e.Id == id);
        }
    }
}
