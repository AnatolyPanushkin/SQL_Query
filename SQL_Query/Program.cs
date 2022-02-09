using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using SQL_Query.Data;
using SQL_Query.Data.Models;


namespace SQL_Query
{
    class Program
    {
        
        static void Main(string[] args)
        {
            QueryContext context = new QueryContext();

            var productCategories = context.ProductCategories
                .Where(e => e.ProductId==e.Product.ProductId && e.CatigoryId==e.Catigory.CatigoryId)
                .Select(e =>new{e.Product,e.Catigory}).ToList();
            foreach (var t in productCategories)
            {
                Console.WriteLine($"{t.Product.Name} - {t.Catigory.Name}");
            }
            
        }
    }
}