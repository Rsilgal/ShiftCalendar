using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _http;

        public PersonService(HttpClient http)
        {
            _http = http;
        }

        public List<PersonModel> People { get; set; }

        public async Task CreatePerson(PersonModel person)
        {
            var result = await _http.PostAsJsonAsync("", person);
            var response = await result.Content.ReadFromJsonAsync<List<PersonModel>>();
            People = response;
        }

        public async Task DeletePerson(int id)
        {
            var result = await _http.DeleteAsync($"");
            var response = await result.Content.ReadFromJsonAsync<List<PersonModel>>();
            People = response;
        }

        public async Task GetPeopleAsync()
        {
            var result = await _http.GetFromJsonAsync<List<PersonModel>>("");
            People= result;
        }

        public async Task<PersonModel> GetPeopleAsync(int id)
        {
            var result = await _http.GetFromJsonAsync<PersonModel>($"");
            return result;
        }

        public async Task UpdatePerson(int id, PersonModel person)
        {
            var result = await _http.PutAsJsonAsync($"", person);
            var response = await result.Content.ReadFromJsonAsync<List<PersonModel>>();
            People = response;
        }
    }
}
