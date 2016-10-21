using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ODataService.Models;

namespace ODataService.DAL
{
    public class MainDbInitializer : DropCreateDatabaseAlways<MainDbContext>
    {
        protected override void Seed(MainDbContext context)
        {
            context.Products.Add(new Product { Id = 1, Name = "IPhone", Category = "Phones", Price = 900 });
            context.Products.Add(new Product { Id = 2, Name = "Samsung", Category = "Phones", Price = 600 });
            context.Products.Add(new Product { Id = 3, Name = "LG", Category = "Phones", Price = 300 });
            context.Products.Add(new Product { Id = 4, Name = "Mac Book Pro", Category = "Laptops", Price = 1900 });
            context.Products.Add(new Product { Id = 5, Name = "Mac Book Air", Category = "Laptops", Price = 1300 });

            base.Seed(context);
        }
    }
}