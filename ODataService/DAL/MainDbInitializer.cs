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
            base.Seed(context);
        }
    }
}