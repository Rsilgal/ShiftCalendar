using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface IShiftService
    {
        List<ShiftModel> Shifts { get; set; }
        Task<List<ShiftModel>> GetShiftsAsync();
        Task<ShiftModel> GetShiftAsync(int id);
        Task<List<ShiftModel>> CreateShit(ShiftModel shift);
        Task<List<ShiftModel>> DeleteShiftAsync(int id);
        Task<List<ShiftModel>> UpdateShiftAsync(int id, ShiftModel shift);
    }
}
