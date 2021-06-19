using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TerminalY.Data;
using TerminalY.Models;

namespace TerminalY.Controllers
{
    public class CartsController : Controller
    {
        private readonly TerminalYContext _context;

        public CartsController(TerminalYContext context)
        {
            _context = context;
        }


        // GET: Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                var user = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                if (user == null)
                {
                    return RedirectToAction("Login", "Accounts");
                }

                var c = _context.Cart.Where(s => s.Account.Username == user).FirstOrDefault();
                if (c == null)
                    return NotFound();
                id = c.Id;


            }

            var cart = await _context.Cart
                .Include(c => c.Account)
                .Include(ci => ci.CartItems)
                .ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

    }
}
