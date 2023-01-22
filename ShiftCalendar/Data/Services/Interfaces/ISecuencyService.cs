using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface ISecuencyService
    {
        List<SecuencyModel> Secuencies { get; set; }
        Task GetSecuenciesAsync();
        Task<SecuencyModel> GetSecuencyAsync(int id);
        Task CreateSecuency(SecuencyModel secuency);
        Task DeleteSecuencyAsync(int id);
        Task UpdateSecuencyAsync(int id, SecuencyModel secuency);
    }
}
