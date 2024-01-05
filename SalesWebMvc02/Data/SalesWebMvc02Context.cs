using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc02.Models;

namespace SalesWebMvc02.Data
{
    public class SalesWebMvc02Context : DbContext
    {
        public SalesWebMvc02Context (DbContextOptions<SalesWebMvc02Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet <Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
