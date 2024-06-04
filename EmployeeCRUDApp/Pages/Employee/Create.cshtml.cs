using EmployeeCRUDApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeCRUDApp.Pages.Employee
{
    public class CreateModel : PageModel
    {
        private readonly EmployeeCRUDApp.Data.EmployeeCRUDAppContext _context;

        public CreateModel(EmployeeCRUDApp.Data.EmployeeCRUDAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Model.Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            var savedData =await _context.SaveChangesAsync();

            var history = new EmployeeHistory
            {
                History = "Created",
                Employee = Employee.Name,
                UpdatedDate = DateTime.Now,
            };
            _context.EmployeeHistory.Add(history);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
