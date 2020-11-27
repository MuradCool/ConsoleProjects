using System;
namespace MyFirstProject.Infrastructure.Models
{
    public class SaleItems
    {
        public int Number { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
