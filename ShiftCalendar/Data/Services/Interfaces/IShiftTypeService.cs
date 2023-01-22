using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data.Services.Interfaces
{
    public interface IShiftTypeService
    {
        List<ShiftTypeModel> ShiftTypes { get; set; }
        Task<List<ShiftTypeModel>> GetShiftTypesAsync();
        Task<ShiftTypeModel> GetShiftTypesAsync(int id);
        Task<List<ShiftTypeModel>> CreateShiftType(ShiftTypeModel shiftType);
        Task<List<ShiftTypeModel>> DeleteShiftTypeAsync(int id);
        Task<List<ShiftTypeModel>> UpdateShiftTypeAsync(int id, ShiftTypeModel shiftType);
    }
}
