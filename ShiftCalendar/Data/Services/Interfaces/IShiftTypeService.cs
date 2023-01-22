using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface IShiftTypeService
    {
        List<ShiftTypeModel> ShiftTypes { get; set; }
        Task GetShiftTypesAsync();
        Task<ShiftTypeModel> GetShiftTypesAsync(int id);
        Task CreateShiftType(ShiftTypeModel shiftType);
        Task DeleteShiftTypeAsync(int id);
        Task UpdateShiftTypeAsync(int id, ShiftTypeModel shiftType);
    }
}
