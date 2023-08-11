using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop_Registration.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Coffee_Shop_Registration.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeDbContext _coffeeDbContext = new CoffeeDbContext();

        public IActionResult Index()
        {
            List<Product> result = _coffeeDbContext.Product.ToList();
           
            return View(result);
        }

        public IActionResult Detail(int id)
        {
            Product p = _coffeeDbContext.Product.FirstOrDefault(x => x.Id == id);
            return View(p);
        }
    }
}

