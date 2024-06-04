using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDApp.Data
{
    public class EmployeeCRUDAppContext : DbContext
    {
        public EmployeeCRUDAppContext (DbContextOptions<EmployeeCRUDAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeCRUDApp.Model.Employee> Employee { get; set; } = default!;
        public DbSet<EmployeeCRUDApp.Model.EmployeeHistory> EmployeeHistory { get; set; } = default!;
    }
}
