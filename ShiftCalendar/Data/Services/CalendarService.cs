using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class CalendarService : ICalendarService
    {
        public List<CalendarModel> Calendars { get; set; }

        public Task<List<CalendarModel>> CreateCalendar(CalendarModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<CalendarModel>> DeleteCalendar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CalendarModel> GetCalendarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CalendarModel>> GetCalendarsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CalendarModel>> UpdateCalendar(int id, CalendarModel model)
        {
            throw new NotImplementedException();
        }
    }
}
