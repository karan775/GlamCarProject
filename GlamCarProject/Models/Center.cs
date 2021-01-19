using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlamCarProject.Models
{
    public class Center
    {
        // Glam cars center details
        [Key]
        public int CenterNo { get; set; } // creating id for the table
        [DisplayName("Center Name")]
        public string Name { get; set; } // center name
        [DisplayName("Center Address")]
        public string Address { get; set; } // center address
        [DisplayName("Center Opening Date")]
        public DateTime OpeningDate { get; set; } // center opening date
        public List<SalePerson> SalePersons { get; set; } // sales persons references
        public Center() // ctor
        {
            SalePersons = new List<SalePerson>();
        }

    }
}
