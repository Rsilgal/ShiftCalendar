using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class ShiftTypeService : IShiftTypeService
    {
        public List<ShiftTypeModel> ShiftTypes { get; set; }

        public Task<List<ShiftTypeModel>> CreateShiftType(ShiftTypeModel shiftType)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftTypeModel>> DeleteShiftTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftTypeModel>> GetShiftTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ShiftTypeModel> GetShiftTypesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftTypeModel>> UpdateShiftTypeAsync(int id, ShiftTypeModel shiftType)
        {
            throw new NotImplementedException();
        }
    }
}
