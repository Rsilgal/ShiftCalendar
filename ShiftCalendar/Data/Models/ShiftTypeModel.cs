using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models
{
    public class ShiftTypeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
