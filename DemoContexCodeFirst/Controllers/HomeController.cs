using DemoContexCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoContexCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var Context = new NorthWindDB();

            return View(Context.Categories.ToList());
        }

        public ActionResult Show(int id = 0)
        {
            List<Category> Categories;
            var Context = new NorthWindDB();

            if(id==0)
            {
                Categories = Context.Categories.ToList();
            }else
            {
                Categories = (from c in Context.Categories where c.CategoryID == id select c).ToList();
            }
            return View("Index", Categories);
        }
    }
}