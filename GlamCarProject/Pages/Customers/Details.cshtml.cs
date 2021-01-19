using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GlamCarProject.Data;
using GlamCarProject.Models;

namespace GlamCarProject.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public DetailsModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
