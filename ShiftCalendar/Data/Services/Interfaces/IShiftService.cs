using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface IShiftService
    {
        List<ShiftModel> Shifts { get; set; }
        Task GetShiftsAsync();
        Task<ShiftModel> GetShiftAsync(int id);
        Task CreateShit(ShiftModel shift);
        Task DeleteShiftAsync(int id);
        Task UpdateShiftAsync(int id, ShiftModel shift);
    }
}
