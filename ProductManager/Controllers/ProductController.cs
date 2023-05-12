using Microsoft.AspNetCore.Mvc;
using ProductManager.Data;
using ProductManager.Data.Entities;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        public ProductController(ApplicationDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddProduct");
            }

            context.Products.AddRange(product);
            context.SaveChanges();
            return RedirectToAction("AllProducts");
        }

        
        public IActionResult AllProducts()
        {
            var prods = context
                .Products
                .ToList();
            return View(prods);
        }

    }
}
