using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models
{
    public class ShiftModel
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public ShiftTypeModel ShiftType { get; set; }
    }
}
