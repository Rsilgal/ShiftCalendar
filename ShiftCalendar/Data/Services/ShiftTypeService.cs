using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class ShiftTypeService : IShiftTypeService
    {
        private readonly HttpClient _http;

        public ShiftTypeService(HttpClient http)
        {
            _http = http;
        }

        public List<ShiftTypeModel> ShiftTypes { get; set; }

        public async Task CreateShiftType(ShiftTypeModel shiftType)
        {
            var result = await _http.PostAsJsonAsync("", shiftType);
            var response = await result.Content.ReadFromJsonAsync<List<ShiftTypeModel>>();
            ShiftTypes = response;
        }

        public async Task DeleteShiftTypeAsync(int id)
        {
            var result = await _http.DeleteAsync($"");
            var response = await result.Content.ReadFromJsonAsync<List<ShiftTypeModel>>();
            ShiftTypes = response;
        }

        public async Task GetShiftTypesAsync()
        {
            var result = await _http.GetFromJsonAsync<List<ShiftTypeModel>>("");
            ShiftTypes = result;
        }

        public async Task<ShiftTypeModel> GetShiftTypesAsync(int id)
        {
            var result = await _http.GetFromJsonAsync<ShiftTypeModel>($"");
            return result;
        }

        public async Task UpdateShiftTypeAsync(int id, ShiftTypeModel shiftType)
        {
            var result = await _http.PutAsJsonAsync($"", shiftType);
            var response = await result.Content.ReadFromJsonAsync<List<ShiftTypeModel>>();
            ShiftTypes = response;
        }
    }
}
