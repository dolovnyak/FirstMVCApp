using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCApp.Context;
using FirstMVCApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
        
        [HttpPost]
        public string Buy(PurchaseViewModel purchaseViewModel)
        {
            if (ModelState.IsValid)
            {
                var purchase = new Purchase
                {
                    Address = purchaseViewModel.Address,
                    Person = purchaseViewModel.Person,
                    Date = DateTime.Now,
                    ProductId = purchaseViewModel.ProductId
                };
                _appDbContext.Purchases.Add(purchase);
                _appDbContext.SaveChanges();

                return "Thank you, " + purchase.Person + ", for your purchase!";
            }

            return "Name or address doesn't correct.";
        }

        public IActionResult Index()
        {
            var products = _appDbContext.Products;
            ViewBag.Products = products;
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}