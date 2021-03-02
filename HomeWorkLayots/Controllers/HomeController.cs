using HomeWorkLayots.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkLayots.Business.Interfaces;
using HomeWorkLayots.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkLayots.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _logger = logger;
        }

        public IActionResult Index(string name)
        {
            IActionResult result = null;
            if (!string.IsNullOrEmpty(name))
            {
                HttpContext.Session.SetString("UserName", name);
                result = RedirectToAction(nameof(this.Index));
            }
            else
            {
                ViewBag.Categories = _categoryRepository.GetAllCategories();
                ViewBag.FirstCategoryProducts = _productRepository.GetFirstCategoryProducts();
                ViewBag.FirstCategoryName = _categoryRepository.GetFirstCategoryName();
                result = View();
            }

            return result;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Category(int categoryid)
        {
            ViewBag.Products = _productRepository.GetProductsByCategory(categoryid);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
