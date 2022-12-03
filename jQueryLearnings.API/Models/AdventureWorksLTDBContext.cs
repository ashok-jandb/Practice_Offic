using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryLearnings.API.Models
{
    public class AdventureWorksLTDBContext : DbContext
    {
        public AdventureWorksLTDBContext(DbContextOptions<AdventureWorksLTDBContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
