using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDApp.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeCRUDApp.Data.EmployeeCRUDAppContext _context;

        public IndexModel(EmployeeCRUDApp.Data.EmployeeCRUDAppContext context)
        {
            _context = context;
        }

        public IList<Model.Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
