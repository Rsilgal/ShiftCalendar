using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface ISecuencyService
    {
        List<SecuencyModel> Secuencies { get; set; }
        Task<List<SecuencyModel>> GetSecuenciesAsync();
        Task<SecuencyModel> GetSecuencyAsync(int id);
        Task<List<SecuencyModel>> CreateSecuency(SecuencyModel secuency);
        Task<List<SecuencyModel>> DeleteSecuencyAsync(int id);
        Task<List<SecuencyModel>> UpdateSecuencyAsync(int id, SecuencyModel secuency);
    }
}
