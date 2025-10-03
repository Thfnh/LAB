using Day05Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace Day05Lab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
