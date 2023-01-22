using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models
{
    public class CalendarModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
