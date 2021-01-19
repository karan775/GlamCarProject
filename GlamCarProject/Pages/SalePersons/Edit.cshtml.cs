using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GlamCarProject.Data;
using GlamCarProject.Models;

namespace GlamCarProject.Pages.SalePersons
{
    public class EditModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public EditModel(GlamCarProject.Data.GlamCarProjectContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SalePerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalePersonExists(SalePerson.SalePersonId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SalePersonExists(int id)
        {
            return _context.SalePerson.Any(e => e.SalePersonId == id);
        }
    }
}
