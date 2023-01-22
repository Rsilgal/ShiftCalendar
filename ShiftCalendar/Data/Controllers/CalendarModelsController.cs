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
    public class CalendarModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CalendarModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CalendarModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarModel>>> GetCalendars()
        {
            return await _context.Calendars.ToListAsync();
        }

        // GET: api/CalendarModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarModel>> GetCalendarModel(int id)
        {
            var calendarModel = await _context.Calendars.FindAsync(id);

            if (calendarModel == null)
            {
                return NotFound();
            }

            return calendarModel;
        }

        // PUT: api/CalendarModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalendarModel(int id, CalendarModel calendarModel)
        {
            if (id != calendarModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(calendarModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarModelExists(id))
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

        // POST: api/CalendarModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CalendarModel>> PostCalendarModel(CalendarModel calendarModel)
        {
            _context.Calendars.Add(calendarModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalendarModel", new { id = calendarModel.Id }, calendarModel);
        }

        // DELETE: api/CalendarModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalendarModel(int id)
        {
            var calendarModel = await _context.Calendars.FindAsync(id);
            if (calendarModel == null)
            {
                return NotFound();
            }

            _context.Calendars.Remove(calendarModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CalendarModelExists(int id)
        {
            return _context.Calendars.Any(e => e.Id == id);
        }
    }
}
