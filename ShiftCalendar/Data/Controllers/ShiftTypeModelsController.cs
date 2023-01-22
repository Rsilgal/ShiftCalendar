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
    public class ShiftTypeModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShiftTypeModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ShiftTypeModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShiftTypeModel>>> GetShiftTypes()
        {
            return await _context.ShiftTypes.ToListAsync();
        }

        // GET: api/ShiftTypeModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShiftTypeModel>> GetShiftTypeModel(int id)
        {
            var shiftTypeModel = await _context.ShiftTypes.FindAsync(id);

            if (shiftTypeModel == null)
            {
                return NotFound();
            }

            return shiftTypeModel;
        }

        // PUT: api/ShiftTypeModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShiftTypeModel(int id, ShiftTypeModel shiftTypeModel)
        {
            if (id != shiftTypeModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(shiftTypeModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftTypeModelExists(id))
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

        // POST: api/ShiftTypeModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShiftTypeModel>> PostShiftTypeModel(ShiftTypeModel shiftTypeModel)
        {
            _context.ShiftTypes.Add(shiftTypeModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShiftTypeModel", new { id = shiftTypeModel.Id }, shiftTypeModel);
        }

        // DELETE: api/ShiftTypeModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShiftTypeModel(int id)
        {
            var shiftTypeModel = await _context.ShiftTypes.FindAsync(id);
            if (shiftTypeModel == null)
            {
                return NotFound();
            }

            _context.ShiftTypes.Remove(shiftTypeModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShiftTypeModelExists(int id)
        {
            return _context.ShiftTypes.Any(e => e.Id == id);
        }
    }
}
