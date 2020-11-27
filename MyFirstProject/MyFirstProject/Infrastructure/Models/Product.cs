using System;
using MyFirstProject.Infrastructure.Enums;

namespace MyFirstProject.Infrastructure.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public string Code { get; set; }
        public CategoryType CategoryType { get; set; }


    }
}
