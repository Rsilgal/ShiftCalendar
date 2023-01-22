using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface ICalendarService
    {
        List<CalendarModel> Calendars { get; set; }
        Task GetCalendarsAsync();
        Task<CalendarModel> GetCalendarAsync(int id);
        Task CreateCalendar(CalendarModel model);
        Task DeleteCalendar(int id);
        Task UpdateCalendar(int id, CalendarModel model);
    }
}
