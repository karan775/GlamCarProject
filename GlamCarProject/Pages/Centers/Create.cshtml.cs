using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GlamCarProject.Data;
using GlamCarProject.Models;

namespace GlamCarProject.Pages.Centers
{
    public class CreateModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public CreateModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Center Center { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Center.Add(Center);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
