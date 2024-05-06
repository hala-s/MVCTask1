using Microsoft.EntityFrameworkCore;
using MVCTask.Models;

namespace MVCTask.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=MVCTASK1;trusted_connection=true;trustServerCertificate=true");
        }
    }
}
