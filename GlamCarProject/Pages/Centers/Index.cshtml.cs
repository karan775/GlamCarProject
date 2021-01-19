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
    public class IndexModel : PageModel
    {
        private readonly GlamCarProject.Data.GlamCarProjectContext _context;

        public IndexModel(GlamCarProject.Data.GlamCarProjectContext context)
        {
            _context = context;
        }

        public IList<Center> Center { get;set; }

        public async Task OnGetAsync()
        {
            Center = await _context.Center.ToListAsync();
        }
    }
}
