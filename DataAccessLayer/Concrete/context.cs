using EntityLayer.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERT\\SQLEXPRESS;database=DbNewOOpCore1;integrated security=true;");

        }

        public DbSet<Product>products { get; set; }
        public DbSet<Customer>customers { get; set; }
        public DbSet<Category>categories { get; set; }
    }
}
