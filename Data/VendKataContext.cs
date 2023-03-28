using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendKata.Models;

namespace VendKata.Data
{
    public class VendKataContext : DbContext
    {
        public VendKataContext (DbContextOptions<VendKataContext> options)
            : base(options)
        {
        }

        public DbSet<VendKata.Models.Product> Product { get; set; } = default!;
    }
}
