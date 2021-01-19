using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GlamCarProject.Models
{
    public class CarSale
    {

        // Car Sale table containing all the sales
        // this class represents the table
        [Key]
        public int CarSaleId { get; set; } // creating id for the table
        [ForeignKey("Customer")]
        public int CustomerId { get; set; } // customer foreign key
        public Customer Customers { get; set; }
        [ForeignKey("SalePerson")]
        public int SalePersonId { get; set; } // sale person foreign key
        public SalePerson SalePersons { get; set; }
        public double AgreedAmount { get; set; } // agreed amount on car sale
        public DateTime SaleDate { get; set; } // date of sale


    }
}
