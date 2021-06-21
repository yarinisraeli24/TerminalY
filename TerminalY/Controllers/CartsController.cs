using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        [HttpPost]
        public async Task<double[]> Plus(int id)
        {
            var query = await _context.CartItem.Include(p => p.Product).FirstOrDefaultAsync(s => s.Id == id);
            if (query != null)
            {
                query.Quantity += 1;
                query.Price = query.Product.Price * query.Quantity;
                await _context.SaveChangesAsync();
                await UpdateTotalPrice(query.Product.Price);
            }
            double[] arr = { query.Price, query.Cart.TotalPrice };
            return arr;
        }

        [HttpPost]
        public async Task<double[]> Minus(int id)
        {
            var query = await _context.CartItem.Include(p => p.Product).FirstOrDefaultAsync(s => s.Id == id);
            if (query != null)
            {
                query.Quantity -= 1;
                query.Price = query.Product.Price * query.Quantity;
                await _context.SaveChangesAsync();
                await UpdateTotalPrice(-query.Product.Price);
            }
            double[] arr = { query.Price, query.Cart.TotalPrice };
            return arr;
        }
        public async Task UpdateTotalPrice(double price)
        {
            var user = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var cart = await _context.Cart.FirstOrDefaultAsync(s => s.Account.Username == user);
            //if cart==null  TODO
            cart.TotalPrice += price;
            await _context.SaveChangesAsync();
        }

        //Post request endpoint
        public async Task<bool> AddToCart(int productId, int quantity = 1)
        {
            var user = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (user == null)
            {
                return false;
            }

            var query = _context.Cart.Where(s => s.Account.Username == user).FirstOrDefault<Cart>();
            if (query == null)
            {
                Account account = _context.Account.First(s => s.Name == user);
                Cart cart = new Cart { Account = account, AccountId = account.Id, TotalPrice = 0 };
                _context.Cart.Add(cart);
                await _context.SaveChangesAsync();
                query = cart;
            }

            var c = _context.CartItem.Where(s => s.Cart == query).Where(p => p.Product.Id == productId).FirstOrDefault<CartItem>();
            if (c == null)
            {
                CartItem cartItem = new CartItem();
                cartItem.Quantity = quantity;
                var product = await _context.Product.FirstOrDefaultAsync(s => s.Id == productId);
                cartItem.Product = product;
                cartItem.Price = product.Price * cartItem.Quantity;
                cartItem.Cart = query;
                if (ModelState.IsValid)
                {
                    _context.Add(cartItem);
                    await _context.SaveChangesAsync();
                    await UpdateTotalPrice(cartItem.Price);
                }
            }
            else
            {
                for (int i = 0; i < quantity; i++)
                {
                    await Plus(c.Id);
                }

            }
            return true;
            //return RedirectToAction("ProductDetails","Products", new { id = (productId) });

        }

        [Authorize]
        public async Task AddProduct(int id)
        {
            this.AddToCart(id, 1);
        }

    }
}
