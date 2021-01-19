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
    public class IndexModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public IndexModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

        public IList<SalePerson> SalePerson { get;set; }

        public async Task OnGetAsync()
        {
            SalePerson = await _context.SalePerson.ToListAsync();
        }
    }
}
