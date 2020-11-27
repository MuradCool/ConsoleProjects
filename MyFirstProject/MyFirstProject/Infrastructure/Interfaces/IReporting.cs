using System;
using System.Collections.Generic;
using MyFirstProject.Infrastructure.Models;

namespace MyFirstProject.Infrastructure.Interfaces
{
    public interface IReporting
    {
        List<Sale> Sales { get; }

        double MonthlySaleTotal(DateTime startDate, DateTime endDate);
        string MostSaledProduct();
        int GetSaleCountByCategoryName(string categoryName);
        double SaleTotal();
        double GetTotalSaleByProductName(string productName);
        void AddSale(Sale sale);
        void RemoveSaleByIndex(int index);
    }
}
