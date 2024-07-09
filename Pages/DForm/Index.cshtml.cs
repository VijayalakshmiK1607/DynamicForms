using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoForms.Pages.DForm
{
    public class IndexModel : PageModel
    {
        private readonly DemoForms.Data.DemoFormsContext _context;

        public IndexModel(DemoForms.Data.DemoFormsContext context)
        {
            _context = context;
        }

        public  Form  Forms { get; set; } = default!;

        public void OnGet()
        {
            Forms= _context.Form.Include(s => s.FormFields).FirstOrDefault();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Form.Add(Forms);
           // await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
