using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models.Dtos
{
    public class PersonDto
    {
        [Required, MinLength(5)]
        public string FirstName { get; set; }
        [Required, MinLength(5)]
        public string LastName { get; set; }
        [Required]
        public ShiftModel Shift { get; set; }
    }
}
