using System;
using System.Collections.Generic;

namespace MyFirstProject.Infrastructure.Models
{
    public class Sale
    {
        public int Number{ get; set; }
        public int DateTime { get; set; }
        public List<SaleItems>SaleItem { get; set; }
        public double Amount { get; set; }
        public string CategoryName { get; internal set; }
        public int Quantity { get; internal set; }
        public string ProductName { get; internal set; }
        public DateTime Date { get; internal set; }
    }
}
