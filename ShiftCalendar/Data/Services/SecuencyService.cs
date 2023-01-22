using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class SecuencyService : ISecuencyService
    {
        private readonly HttpClient _http;

        public SecuencyService(HttpClient http)
        {
            _http = http;
        }

        public List<SecuencyModel> Secuencies { get; set; }

        public async Task CreateSecuency(SecuencyModel secuency)
        {
            var result = await _http.PostAsJsonAsync("", secuency);
            var response = await result.Content.ReadFromJsonAsync<List<SecuencyModel>>();
            Secuencies = response;
        }

        public async Task DeleteSecuencyAsync(int id)
        {
            var result = await _http.DeleteAsync($"");
            var response = await result.Content.ReadFromJsonAsync<List<SecuencyModel>>();
            Secuencies = response;
        }

        public async Task GetSecuenciesAsync()
        {
            var result = await _http.GetFromJsonAsync<List<SecuencyModel>>("");
            Secuencies = result;
        }

        public async Task<SecuencyModel> GetSecuencyAsync(int id)
        {
            var result = await _http.GetFromJsonAsync<SecuencyModel>($"");
            return result;
        }

        public async Task UpdateSecuencyAsync(int id, SecuencyModel secuency)
        {
            var result = await _http.PutAsJsonAsync($"", secuency);
            var response = await result.Content.ReadFromJsonAsync<List<SecuencyModel>>();
            Secuencies = response;
        }
    }
}
