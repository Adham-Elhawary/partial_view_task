using Microsoft.EntityFrameworkCore;
using partial_view_task.Models;

namespace partial_view_task.Data
{
    public class DrAppdbContext : DbContext
    {
        public DrAppdbContext(DbContextOptions<DrAppdbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
