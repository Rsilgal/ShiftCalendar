using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class ShiftService : IShiftService
    {
        private readonly HttpClient _http;

        public ShiftService(HttpClient http)
        {
            _http = http;
        }

        public List<ShiftModel> Shifts { get; set; }

        public async Task CreateShit(ShiftModel shift)
        {
            var result = await _http.PostAsJsonAsync("/api/ShiftModels", shift);
            var response = await result.Content.ReadFromJsonAsync<List<ShiftModel>>();
            Shifts = response;
        }

        public async Task DeleteShiftAsync(int id)
        {
            var result = await _http.DeleteAsync($"/api/ShiftModels/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<ShiftModel>>();
            Shifts = response;
        }

        public async Task<ShiftModel> GetShiftAsync(int id)
        {
            var result = await _http.GetFromJsonAsync<ShiftModel>($"/api/ShiftModels");
            return result;
        }

        public async Task GetShiftsAsync()
        {
            var result = await _http.GetFromJsonAsync<List<ShiftModel>>("/api/ShiftModels/{id}");
            Shifts = result;
        }

        public async Task UpdateShiftAsync(int id, ShiftModel shift)
        {
            var result = await _http.PutAsJsonAsync($"/api/ShiftModels/{id}", shift);
            var response = await result.Content.ReadFromJsonAsync<List<ShiftModel>>();
            Shifts = response;
        }
    }
}
