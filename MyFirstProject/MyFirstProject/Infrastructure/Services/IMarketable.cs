using System;
using System.Collections.Generic;
using MyFirstProject.Infrastructure.Models;

namespace MyFirstProject.Infrastructure.Services
{
    public interface IMarketable
    {
        List<Sale>Sale { get;  }
        List<Product>Product { get;  }
        void Add(Sale sale);
        void RemoveSaleByCodel(int codel);
        void GetproductByName(string Name);
        List<Product> GetProducts();
    }
}
