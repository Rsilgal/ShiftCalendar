using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShiftCalendar.Data.Models;

namespace ShiftCalendar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CalendarModel> Calendars { get; set; }
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<SecuencyModel> Secuencies { get; set; }
        public DbSet<ShiftModel> Shifts { get; set; }
        public DbSet<ShiftTypeModel> ShiftTypes { get; set; }
    }
}