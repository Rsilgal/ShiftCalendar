using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models.Dtos
{
    public class CalendarDto
    {
        [Required, MinLength(2)]
        public string Name { get; set; } = string.Empty;
    }
}
