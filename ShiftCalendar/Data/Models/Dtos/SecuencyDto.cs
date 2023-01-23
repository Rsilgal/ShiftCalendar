using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models.Dtos
{
    public class SecuencyDto
    {
        [Required, MinLength(2)]
        public string Name { get; set; } = string.Empty;
        [Required, MinLength(5)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public CalendarModel Calendar { get; set; }
        [Required]
        public ICollection<ShiftModel> Shift { get; set; }
    }
}
