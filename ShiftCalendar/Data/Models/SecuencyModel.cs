using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models
{
    public class SecuencyModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public CalendarModel Calendar { get; set; }
        public ICollection<ShiftModel> Shift { get; set; }
    }
}
