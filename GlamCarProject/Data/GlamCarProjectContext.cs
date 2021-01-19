using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GlamCarProject.Models;

namespace GlamCarProject.Data
{
    public class GlamCarProjectContext : DbContext
    {
        public GlamCarProjectContext (DbContextOptions<GlamCarProjectContext> options)
            : base(options)
        {
        }

        public DbSet<GlamCarProject.Models.CarSale> CarSale { get; set; }

        public DbSet<GlamCarProject.Models.Center> Center { get; set; }

        public DbSet<GlamCarProject.Models.Customer> Customer { get; set; }

        public DbSet<GlamCarProject.Models.SalePerson> SalePerson { get; set; }
    }
}
