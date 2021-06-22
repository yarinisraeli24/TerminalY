using System;
using System.Collections;
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
    public class CategoriesController : Controller
    {
        private readonly TerminalYContext _context;

        public CategoriesController(TerminalYContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Shop(string? id)
        {
            var category = new Category();
            ViewBag.Categories = new ArrayList(_context.Category.ToList());

            var isValidId = int.TryParse(id, out int categoryId);

            if (id == null)
            {
                category = await _context.Category
                    .Include(p => p.Products).FirstAsync();
                return Redirect("/Categories/Shop/" + category.Id.ToString());
            }
            else if (!isValidId)
            {
                throw new Exception("Id is not valid");
            }
            else
            {
                category = await _context.Category
                    .Include(p => p.Products)
                    .FirstOrDefaultAsync(m => m.Id == categoryId);
                if (category == null)
                {
                    return NotFound();
                }
            }

            return View(category.Products);
        }
        public async Task<IActionResult> SearchByPriceAndCategory(string minamount, string maxamount, String category)
        {
            int minim = Int32.Parse(minamount.Substring(1));
            int maxim = Int32.Parse(maxamount.Substring(1));
            var query = from p in _context.Product
                        where ((p.Category.Id.ToString() == category) && (p.Price >= minim && p.Price <= maxim))
                        select p;
            
            return Json(await query.ToListAsync()); //TODO

        }
    }
}
