using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TerminalY.Data;
using TerminalY.Models;
using Microsoft.AspNetCore.Authorization;

namespace TerminalY.Controllers
{
    [Authorize]
    public class CartItemsController : Controller
    {
        private readonly TerminalYContext _context;

        public CartItemsController(TerminalYContext context)
        {
            _context = context;
        }

        // GET: CartItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartItem.ToListAsync());
        }

        // POST: CartItems/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<double> Delete(int id)
        {
            var cartItem = await _context.CartItem.Include(c => c.Cart).FirstOrDefaultAsync(c => c.Id == id);
            cartItem.Cart.TotalPrice -= cartItem.Price;
            _context.CartItem.Remove(cartItem);
            await _context.SaveChangesAsync();
            return cartItem.Cart.TotalPrice;
        }

        // POST: CartItems/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<double[]> Update(int id, int quantity)
        {
            var cartItem = await _context.CartItem.Include(c => c.Cart).Include(p => p.Product).FirstOrDefaultAsync(c => c.Id == id);

            cartItem.Quantity += quantity;
            cartItem.Cart.TotalPrice -= cartItem.Price;
            cartItem.Price += (cartItem.Product.Price * quantity);
            cartItem.Cart.TotalPrice += cartItem.Price;

            await _context.SaveChangesAsync();

            double[] arr = { cartItem.Price, cartItem.Cart.TotalPrice };
            return arr;
        }

        private bool CartItemExists(int id)
        {
            return _context.CartItem.Any(e => e.Id == id);
        }
    }
}
