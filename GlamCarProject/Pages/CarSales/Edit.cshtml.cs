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

namespace GlamCarProject.Pages.CarSales
{
    public class EditModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public EditModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CarSale CarSale { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarSale = await _context.CarSale
                .Include(c => c.Customers)
                .Include(c => c.SalePersons).FirstOrDefaultAsync(m => m.CarSaleId == id);

            if (CarSale == null)
            {
                return NotFound();
            }
           ViewData["CustomerId"] = new SelectList(_context.Set<Customer>(), "CustomerId", "CustomerId");
           ViewData["SalePersonId"] = new SelectList(_context.Set<SalePerson>(), "SalePersonId", "SalePersonId");
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

            _context.Attach(CarSale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarSaleExists(CarSale.CarSaleId))
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

        private bool CarSaleExists(int id)
        {
            return _context.CarSale.Any(e => e.CarSaleId == id);
        }
    }
}
