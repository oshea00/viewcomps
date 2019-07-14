using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewcomps.Models;

namespace viewcomps.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository repository;

        public HomeController(IProductRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            repository.AddProduct(product);
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
