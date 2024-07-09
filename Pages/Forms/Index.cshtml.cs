using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoForms;
using DemoForms.Data;

namespace DemoForms.Pages.Forms
{
    public class IndexModel : PageModel
    {
        private readonly DemoForms.Data.DemoFormsContext _context;

        public IndexModel(DemoForms.Data.DemoFormsContext context)
        {
            _context = context;
        }

        public IList<Form> Form { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Form = await _context.Form.ToListAsync();
        }
    }
}
