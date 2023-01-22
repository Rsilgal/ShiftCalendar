using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface IPersonService
    {
        List<PersonModel> People { get; set; }
        Task<PersonModel> GetPeopleAsync();
        Task<List<PersonModel>> GetPeopleAsync(int id);
        Task<List<PersonModel>> CreatePerson(PersonModel person);
        Task<List<PersonModel>> DeletePerson(int id);
        Task<List<PersonModel>> UpdatePerson(int id, PersonModel person);
    }
}
