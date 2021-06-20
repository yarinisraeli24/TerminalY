using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TerminalY.Data;
using TerminalY.Models;

namespace TerminalY.Controllers
{
    public class ProductsController : Controller
    {
        private readonly TerminalYContext _context;

        public ProductsController(TerminalYContext context)
        {
            _context = context;
        }


        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        public async Task<IActionResult> SearchProducts(string term)
        {
            var products = await _context.Product.Where(s => s.Name.Contains(term) || s.Description.Contains(term)).ToListAsync();
            TempData["term"] = term;
            return View(products);
        }
        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
