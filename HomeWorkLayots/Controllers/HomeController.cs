using HomeWorkLayots.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkLayots.Data;
using HomeWorkLayots.Data.Interfaces;
using Microsoft.AspNetCore.Http;

namespace HomeWorkLayots.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
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
                result = View(_categoryRepository.GetCategories());
            }

            return result;
        }

        [HttpGet]
        public IActionResult Category(int categoryid)
        {
            var productsList = _productRepository.GetCategoryProducts(categoryid);
            return View(productsList);
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
