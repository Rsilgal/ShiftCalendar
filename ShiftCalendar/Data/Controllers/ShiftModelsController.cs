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
    public class ShiftModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShiftModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ShiftModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShiftModel>>> GetShifts()
        {
            return await _context.Shifts.ToListAsync();
        }

        // GET: api/ShiftModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShiftModel>> GetShiftModel(int id)
        {
            var shiftModel = await _context.Shifts.FindAsync(id);

            if (shiftModel == null)
            {
                return NotFound();
            }

            return shiftModel;
        }

        // PUT: api/ShiftModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable<ShiftModel>>> PutShiftModel(int id, ShiftModel shiftModel)
        {
            if (id != shiftModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(shiftModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return NoContent();
            var shifts = await GetShifts();
            return Ok(shifts);
        }

        // POST: api/ShiftModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IEnumerable<ShiftModel>>> PostShiftModel(ShiftModel shiftModel)
        {
            _context.Shifts.Add(shiftModel);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetShiftModel", new { id = shiftModel.Id }, shiftModel);
            var shifts = await GetShifts();
            return Ok(shifts);
        }

        // DELETE: api/ShiftModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<ShiftModel>>> DeleteShiftModel(int id)
        {
            var shiftModel = await _context.Shifts.FindAsync(id);
            if (shiftModel == null)
            {
                return NotFound();
            }

            _context.Shifts.Remove(shiftModel);
            await _context.SaveChangesAsync();

            //return NoContent();
            var shifts = await GetShifts();
            return Ok(shifts);
        }

        private bool ShiftModelExists(int id)
        {
            return _context.Shifts.Any(e => e.Id == id);
        }
    }
}
