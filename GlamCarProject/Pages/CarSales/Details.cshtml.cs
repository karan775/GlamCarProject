﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GlamCarProject.Data;
using GlamCarProject.Models;

namespace GlamCarProject.Pages.CarSales
{
    public class DetailsModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public DetailsModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
