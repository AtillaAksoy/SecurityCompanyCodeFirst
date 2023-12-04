using Microsoft.EntityFrameworkCore;
using SecurityCompanyCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityCompanyCodeFirst.Context
{
    public class ProjectContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=SecurityCodeFirst;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
