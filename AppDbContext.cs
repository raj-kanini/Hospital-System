using Microsoft.EntityFrameworkCore;
using Hospital.Class;

namespace Hospital.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Register> Register { get; set; }
        public DbSet<Appointment> Appointments { get; set; } // Add this line

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
