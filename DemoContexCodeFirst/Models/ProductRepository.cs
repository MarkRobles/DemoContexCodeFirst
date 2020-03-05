using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoContexCodeFirst.Models
{
    public class ProductRepository : IProductRepository
    {
        public ICollection<Product> GetProducts(int categoryID)
        {
            ICollection<Product> Products;

            using ( var Context = new NorthWindDB())
            {
                Products = Context.Products.Where(p => p.CategoryID == categoryID).ToList();
            }
            return Products;
        }
    }
}