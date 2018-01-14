using System;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mysql.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }

        public DbSet<CustomerContext> Customer { get; set; }
    }
}
