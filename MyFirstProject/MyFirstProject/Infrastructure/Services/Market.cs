
using System;
using System.Collections.Generic;
using System.Linq;
using MyFirstProject.Infrastructure.Models;

namespace MyFirstProject.Infrastructure.Services
{
    public class Market : IMarketable

    {
        private readonly List<Sale> _sales;
        private readonly List<Product> _products;
        public List<Sale> Sale => _sales;

        public List<Product> Product => _products;
        public Market()
            {
            _products = new List<Product>()
            {
                new Product
                {
                    Name="Iphone",
                    Quantity=12,
                    Cost=1400,
                    Code="AAA",
                    CategoryType=Enums.CategoryType.Telefon
                }

            };

            }


        public void Add(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void AddSale(Sale sale)
        {
          
        }

        public void GetproductByName(string Name)
        {
            var list=_products.FindAll(p => p.Name == Name).ToList();
            foreach (var item in list)
            {
                Console.WriteLine("Qiymeti: "+item.Cost);
                Console.WriteLine("Qiymeti: " + item.Cost);
            }
        }

        public void RemoveSaleByCodel(int codel)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
