using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface IPersonService
    {
        List<PersonModel> People { get; set; }
        Task GetPeopleAsync();
        Task<PersonModel> GetPeopleAsync(int id);
        Task CreatePerson(PersonModel person);
        Task DeletePerson(int id);
        Task UpdatePerson(int id, PersonModel person);
    }
}
