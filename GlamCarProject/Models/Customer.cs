using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlamCarProject.Models
{
    public class Customer
    {
        // Customers detials table
        [Key]
        public int CustomerId { get; set; } // creating id for customer
        [DisplayName("Customer Name")]
        public string Name { get; set; } // customer name
        [DisplayName("Customer Address")]
        public string Address { get; set; } // acustomer address
        [DisplayName("Customer Phone")]
        public string Phone { get; set; }// customer phne number


        public List<CarSale> CarSales { get; set; } // car sales reference
        public Customer() // ctor
        {
            CarSales = new List<CarSale>();
        }

    }
}
