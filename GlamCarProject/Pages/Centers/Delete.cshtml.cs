using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GlamCarProject.Data;
using GlamCarProject.Models;

namespace GlamCarProject.Pages.Centers
{
    public class DeleteModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public DeleteModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Center Center { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Center = await _context.Center.FirstOrDefaultAsync(m => m.CenterNo == id);

            if (Center == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Center = await _context.Center.FindAsync(id);

            if (Center != null)
            {
                _context.Center.Remove(Center);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
