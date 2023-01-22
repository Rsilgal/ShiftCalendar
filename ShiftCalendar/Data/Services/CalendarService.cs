using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly HttpClient _http;
        private readonly ApplicationDbContext _db;

        public CalendarService(HttpClient http, ApplicationDbContext db)
        {
            _http = http;
            _db = db;
        }
        public List<CalendarModel> Calendars { get; set; }

        public async Task<List<CalendarModel>> CreateCalendar(CalendarModel model)
        {
            var result = await _http.PostAsJsonAsync("", model);
            var response = await result.Content.ReadFromJsonAsync<List<CalendarModel>>();
            Calendars = response;
            return await GetCalendarsAsync();
        }

        public async Task<List<CalendarModel>> DeleteCalendar(int id)
        {
            var result = await _http.DeleteAsync($"");
            var response = await result.Content.ReadFromJsonAsync<List<CalendarModel>>();
            Calendars = response;
            return await GetCalendarsAsync();
        }

        public async Task<CalendarModel> GetCalendarAsync(int id)
        {
            var result = await _http.GetFromJsonAsync<CalendarModel>($"");
            if (result != null)
                return result;
            return null;
        }

        public async Task<List<CalendarModel>> GetCalendarsAsync()
        {
            var result = await _http.GetFromJsonAsync<List<CalendarModel>>("");
            Calendars = result;
            return Calendars;

        }

        public async Task<List<CalendarModel>> UpdateCalendar(int id, CalendarModel model)
        {
            var result = await _http.PutAsJsonAsync($"", model);
            var response = await result.Content.ReadFromJsonAsync<List<CalendarModel>>();
            Calendars = response;
            return await GetCalendarsAsync();
        }
    }
}
