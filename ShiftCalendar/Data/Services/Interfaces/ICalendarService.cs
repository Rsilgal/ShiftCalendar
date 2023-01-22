using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface ICalendarService
    {
        List<CalendarModel> Calendars { get; set; }
        Task<List<CalendarModel>> GetCalendarsAsync();
        Task<CalendarModel> GetCalendarAsync(int id);
        Task<List<CalendarModel>> CreateCalendar(CalendarModel model);
        Task<List<CalendarModel>> DeleteCalendar(int id);
        Task<List<CalendarModel>> UpdateCalendar(int id, CalendarModel model);
    }
}
