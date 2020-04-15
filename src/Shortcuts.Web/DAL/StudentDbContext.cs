using Microsoft.EntityFrameworkCore;
using Shortcuts.Web.DAL.Entities;
namespace Shortcuts.Web.DAL
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
    }
}
