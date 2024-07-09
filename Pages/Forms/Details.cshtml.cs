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
    public class DetailsModel : PageModel
    {
        private readonly DemoForms.Data.DemoFormsContext _context;

        public DetailsModel(DemoForms.Data.DemoFormsContext context)
        {
            _context = context;
        }

        public Form Form { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var form = await _context.Form.FirstOrDefaultAsync(m => m.ID == id);
            if (form == null)
            {
                return NotFound();
            }
            else
            {
                Form = form;
            }
            return Page();
        }
    }
}
