using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models.Dtos
{
    public class ShiftTypeDto
    {
        [Required, MinLength(1)]
        public string Name { get; set; } = string.Empty;

        [Required, MinLength(5)]
        public string Description { get; set; } = string.Empty;
    }
}
