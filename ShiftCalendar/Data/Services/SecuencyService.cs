using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class SecuencyService : ISecuencyService
    {
        public List<SecuencyModel> Secuencies { get; set; }

        public Task<List<SecuencyModel>> CreateSecuency(SecuencyModel secuency)
        {
            throw new NotImplementedException();
        }

        public Task<List<SecuencyModel>> DeleteSecuencyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SecuencyModel>> GetSecuenciesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SecuencyModel> GetSecuencyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SecuencyModel>> UpdateSecuencyAsync(int id, SecuencyModel secuency)
        {
            throw new NotImplementedException();
        }
    }
}
