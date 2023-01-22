using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly HttpClient _http;

        public CalendarService(HttpClient http)
        {
            _http = http;
        }
        public List<CalendarModel> Calendars { get; set; }

        public async Task CreateCalendar(CalendarModel model)
        {
            var result = await _http.PostAsJsonAsync("", model);
            var response = await result.Content.ReadFromJsonAsync<List<CalendarModel>>();
            Calendars = response;
        }

        public async Task DeleteCalendar(int id)
        {
            var result = await _http.DeleteAsync($"");
            var response = await result.Content.ReadFromJsonAsync<List<CalendarModel>>();
            Calendars = response;
        }

        public async Task<CalendarModel> GetCalendarAsync(int id)
        {
            var result = await _http.GetFromJsonAsync<CalendarModel>($"");
            if (result != null)
                return result;
            return null;
        }

        public async Task GetCalendarsAsync()
        {
            var result = await _http.GetFromJsonAsync<List<CalendarModel>>("");
            Calendars = result;

        }

        public async Task UpdateCalendar(int id, CalendarModel model)
        {
            var result = await _http.PutAsJsonAsync($"", model);
            var response = await result.Content.ReadFromJsonAsync<List<CalendarModel>>();
            Calendars = response;
        }
    }
}
