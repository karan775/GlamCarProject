using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GlamCarProject.Models
{
    public class SalePerson
    {
        // Sale person detail table
        [Key]
        public int SalePersonId { get; set; } // creating id for sale person
        public string Name { get; set; } // name of the sale person
        public string Address { get; set; } // sale person address
        [ForeignKey("Center")]
        public int CenterNo { get; set; } // center no foreign key
        public Center Centers { get; set; }
        public bool isSenior { get; set; } // is senior sale person check
        public List<CarSale> CarSales { get; set; } // references cAr sales
        public SalePerson() // ctor
        {
            CarSales = new List<CarSale>();
        }

    }
}
