using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DemoContexCodeFirst.Models
{
    public class NorthWindInitializer:DropCreateDatabaseAlways<NorthWindDB>
    {

        protected override void Seed(NorthWindDB context)
        {
            var Categorias = new List<Category>
            {
                new Category {CategoryID=1,CategoryName="Bebidas" },
                new Category {CategoryID=2,CategoryName="Condimentos" },
                new Category {CategoryID=3,CategoryName="Lacteos" },
                new Category {CategoryID=4,CategoryName="Frutas" }

            };
            Categorias.ForEach(c => context.Categories.Add(c));

            context.SaveChanges();


            var Products = new List<Product>
            {
                new Product   { CategoryID=1,ID = 1,ProductName = "Soda" },
                 new Product   { CategoryID=1,ID = 2,ProductName = "Cerveza" },
                  new Product   { CategoryID=2,ID = 3,ProductName = "Ajo" },
                   new Product   { CategoryID=2,ID = 4,ProductName = "Canela" }
            };

            Products.ForEach(p => context.Products.Add(p));

            context.SaveChanges();
        }

    }
}