using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class PersonService : IPersonService
    {
        public List<PersonModel> People { get; set; }

        public Task<List<PersonModel>> CreatePerson(PersonModel person)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonModel>> DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> GetPeopleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonModel>> GetPeopleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonModel>> UpdatePerson(int id, PersonModel person)
        {
            throw new NotImplementedException();
        }
    }
}
