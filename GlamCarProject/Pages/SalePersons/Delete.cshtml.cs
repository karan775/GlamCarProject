using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GlamCarProject.Data;
using GlamCarProject.Models;

namespace GlamCarProject.Pages.SalePersons
{
    public class DeleteModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public DeleteModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SalePerson SalePerson { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SalePerson = await _context.SalePerson.FirstOrDefaultAsync(m => m.SalePersonId == id);

            if (SalePerson == null)
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

            SalePerson = await _context.SalePerson.FindAsync(id);

            if (SalePerson != null)
            {
                _context.SalePerson.Remove(SalePerson);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
