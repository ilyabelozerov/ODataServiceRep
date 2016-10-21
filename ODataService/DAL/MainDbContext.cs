using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ODataService.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ODataService.DAL
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
                : base("name=MainConnectionString")
        {
           Database.SetInitializer<MainDbContext>(new MainDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Product> Products { get; set; }
    }
}