using System.ComponentModel.DataAnnotations;

namespace ShiftCalendar.Data.Models
{
    public class PersonModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ShiftModel Shift { get; set; }
    }
}
