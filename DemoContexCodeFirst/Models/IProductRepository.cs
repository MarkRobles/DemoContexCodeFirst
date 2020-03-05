using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContexCodeFirst.Models
{
    interface IProductRepository
    {
        /*Exponer metodo que devuelva una coleccion de productos de una categoria*/
        ICollection<Product> GetProducts(int categoryID);
    }



}
