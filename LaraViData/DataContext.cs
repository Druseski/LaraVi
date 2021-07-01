using LaraViEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViData
{
    public class DataContext: IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
       
    }
}
