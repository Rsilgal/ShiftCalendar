using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models.Dtos
{
    public class ShiftDto
    {
        [Required, MinLength(3)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public ShiftTypeModel ShiftType { get; set; }
    }
}
