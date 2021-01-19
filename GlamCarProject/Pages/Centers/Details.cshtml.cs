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
    public class DetailsModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public DetailsModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

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
    }
}
