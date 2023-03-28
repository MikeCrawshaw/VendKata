using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VendKata.Data;
using System;
using System.Linq;
using System.ComponentModel;

namespace VendKata.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VendKataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VendKataContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Cola",
                        Price =1.00M
                    },

                    new Product
                    {
                        Name = "Crisps",
                        Price = 0.5M
                    },

                    new Product
                    {
                        Name = "Chocolate",
                        Price = 0.65M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
