using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DATA
{
    public class StoreContext : DbContext
    {
       public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> products { get; set;}
    }
}