using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDApp.Pages.Employee
{
    public class EmployeeHistoryListModel : PageModel
    {
        private readonly EmployeeCRUDApp.Data.EmployeeCRUDAppContext _context;

        public EmployeeHistoryListModel(EmployeeCRUDApp.Data.EmployeeCRUDAppContext context)
        {
            _context = context;
        }
        public IList<Model.EmployeeHistory> EmployeeHistory { get; set; } = default!;
        public async Task OnGetAsync()
        {
            EmployeeHistory = await _context.EmployeeHistory.ToListAsync();
        }
    }
}
