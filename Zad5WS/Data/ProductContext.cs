using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad5WS.Models;
using Microsoft.EntityFrameworkCore;

namespace Zad5WS.Data
{
    public class ProductContext : DbContext
    {

        public ProductContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    
    }
}
