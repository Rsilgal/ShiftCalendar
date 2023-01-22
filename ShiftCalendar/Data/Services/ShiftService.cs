using ShiftCalendar.Data.Models;
using ShiftCalendar.Data.Services.Interfaces;

namespace ShiftCalendar.Data.Services
{
    public class ShiftService : IShiftService
    {
        public List<ShiftModel> Shifts { get; set; }

        public Task<List<ShiftModel>> CreateShit(ShiftModel shift)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftModel>> DeleteShiftAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ShiftModel> GetShiftAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftModel>> GetShiftsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftModel>> UpdateShiftAsync(int id, ShiftModel shift)
        {
            throw new NotImplementedException();
        }
    }
}
