﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TerminalY.Data;
using TerminalY.Models;

namespace TerminalY.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly TerminalYContext _context;

        public AdminController(TerminalYContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tables()
        {
            Admin ap = new Admin
            {
                Accounts = _context.Account.ToList(),
                Orders = _context.Order.ToList(),
                Products = _context.Product.ToList(),
                Categories = _context.Category.ToList(),
                Contacts = _context.Contact.ToList(),
                CartItems = _context.CartItem.Include(p => p.Product).ToList(),
                OrderItems = _context.OrderItem.Include(p => p.Product).ToList(),
                Carts = _context.Cart.Include(o => o.Account).ToList()

            };

            return View(ap);
        }

        // Search-Auto Complete
        public async Task<IActionResult> Search(string term)
        {
            Admin admin = new Admin
            {
                Accounts = await _context.Account.Where(s => (s.Name.Contains(term))
                                                    || (s.Username.Contains(term)))
                                                    .ToListAsync(),
                Orders = await _context.Order.Where(s => (s.Address.Contains(term))
                                                    || (s.City.Contains(term))
                                                    || (s.Country.Contains(term))
                                                    || (s.PostalCode.Contains(term))
                                                    || (s.PhoneNumber.Contains(term)))
                                                    .ToListAsync(),
                Products = await _context.Product.Where(s => s.Name.Contains(term)
                                                    || (s.Description.Contains(term))
                                                    || (s.Price.ToString().Equals(term)))
                                                    .ToListAsync(),
                Categories = await _context.Category.Where(s => s.Name.Contains(term)).ToListAsync(),
                Contacts = await _context.Contact.Where(s => s.Subject.Contains(term)
                                                    || s.Body.Contains(term)
                                                    || s.Email.Contains(term))
                                                    .ToListAsync()

            };

            return View(admin);
        }

        public ActionResult Charts()
        {
            var result = (from o in _context.OrderItem
                          group o by o.Product.Name into o
                          orderby o.Sum(c => c.Quantity) descending
                          select new { o.Key, Total = o.Sum(c => c.Quantity) })
             .ToDictionary(x => x.Key, x => x.Total);
            ViewBag.OrderCount = result;
            var DateResult = _context.Order.GroupBy(x => x.OrderTime.Date, x => x.Id)
                        .Select(x => new { Date = x.Key.ToShortDateString(), Count = x.Count() }).ToList();
            ViewBag.DateResult = DateResult;
            return View();
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> AccountDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(o => o.Orders)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Accounts/Details.cshtml", account);
        }

        // GET: Accounts/Create
        public IActionResult AccountCreate()
        {
            return View("~/Views/Admin/Accounts/Create.cshtml");
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AccountCreate([Bind("Id,Username,Password,Gender,Name,BirthDate,Registered,Role")] Account account)
        {
            if (!_context.Account.Any(u => u.Username == account.Username))
            {
                if (ModelState.IsValid)
                {
                    account.Registered = DateTime.Now;
                    account.Cart = new Cart();
                    _context.Add(account);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Tables));
                }
            }
            return View("~/Views/Admin/Accounts/Create.cshtml", account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> AccountEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Accounts/Edit.cshtml", account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AccountEdit(int id, [Bind("Id,Username,Password,Gender,Name,BirthDate,Registered,Role")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Accounts/Edit.cshtml", account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> AccountDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Accounts/Delete.cshtml", account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("AccountDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AccountDeleteConfirmed(int id)
        {
            var account = await _context.Account
                .Include(c => c.Cart).ThenInclude(c => c.CartItems)
                .Include(o => o.Orders).ThenInclude(o => o.OrderItems)
                .FirstOrDefaultAsync(a => a.Id == id);
            foreach (CartItem ci in account.Cart.CartItems)
            {
                _context.CartItem.Remove(ci);
            }
            _context.Cart.Remove(account.Cart);
            foreach (Order o in account.Orders)
            {
                foreach (OrderItem oi in o.OrderItems)
                {
                    _context.OrderItem.Remove(oi);
                }
                _context.Order.Remove(o);
            }
            _context.Account.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }
        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.Id == id);
        }


        // GET: Products/Details/5
        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Products/Details.cshtml", product);
        }

        // GET: Products/Create
        public IActionResult ProductCreate()
        {
            ViewData["categories"] = new SelectList(_context.Category, nameof(Category.Id), nameof(Category.Name));
            return View("~/Views/Admin/Products/Create.cshtml");
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate([Bind("Id,Name,Description,Price,Image,Created")] Product product, string categoryId)
        {
            if (ModelState.IsValid)
            {
                product.Created = DateTime.Now;

                var category = await _context.Category.FirstOrDefaultAsync(c => c.Id.ToString().CompareTo(categoryId) == 0);

                product.Category = category;

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/AdminPanels/Products/Create.cshtml", product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> ProductEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Products/Edit.cshtml", product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductEdit(int id, [Bind("Id,Name,Description,Price,Image,Created")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Products/Edit.cshtml", product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> ProductDelete(int? id)
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

            return View("~/Views/Admin/Products/Delete.cshtml", product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("ProductDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductDeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> ContactDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Contacts/Details.cshtml", contact);
        }

        // GET: Contacts/Create
        public IActionResult ContactCreate()
        {
            return View("~/Views/Admin/Contacts/Create.cshtml");
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactCreate([Bind("Id,Name,Email,Subject,Body")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                ViewData["products"] = new SelectList(_context.Product.Where(x => x.Category == null), nameof(Product.Id), nameof(Product.Name));
                _context.Add(contact);
                await _context.SaveChangesAsync();
                RedirectToAction("SendEmail", "Contacts", new { contact.Email, contact.Name });
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Contacts/Create.cshtml", contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> ContactEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Contacts/Edit.cshtml", contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactEdit(int id, [Bind("Id,Name,Email,Subject,Body")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Contacts/Edit.cshtml", contact);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> ContactDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Contacts/Delete.cshtml", contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("ContactDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactDeleteConfirmed(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
        // GET: Categories/Details/5
        public async Task<IActionResult> CategoryDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Categories/Details.cshtml", category);
        }

        // GET: Categories/Create
        public IActionResult CategoryCreate()
        {
            ViewData["products"] = new SelectList(_context.Product.Where(x => x.Category == null), nameof(Product.Id), nameof(Product.Name));
            return View("~/Views/Admin/Categories/Create.cshtml");
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CategoryCreate([Bind("Id,Name")] Category category, int[] products)
        {
            if (ModelState.IsValid)
            {
                category.Products = new List<Product>();
                category.Products.AddRange(_context.Product.Where(x => products.Contains(x.Id)));
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Categories/Create.cshtml", category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> CategoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Categories/Edit.cshtml", category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CategoryEdit(int id, [Bind("Id,Name")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Categories/Edit.cshtml", category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> CategoryDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Categories/Delete.cshtml", category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("CategoryDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CategoryDeleteConfirmed(int id)
        {
            var category = await _context.Category.FindAsync(id);
            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }


        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.Id == id);
        }

        // GET: CartItems/Details/5
        public async Task<IActionResult> CartItemDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/CartItems/Details.cshtml", cartItem);
        }

        // GET: CartItems/Create
        public IActionResult CartItemCreate()
        {
            ViewData["Accounts"] = new SelectList(_context.Account, "Id", "Name");
            ViewData["Products"] = new SelectList(_context.Product, "Id", "Name");
            return View("~/Views/Admin/CartItems/Create.cshtml");
        }

        // POST: CartItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CartItemCreate([Bind("Id, Quantity, TotalPrice")] CartItem cartItem, int productId, int accountId)
        {
            if (ModelState.IsValid)
            {
                cartItem.Cart = await _context.Cart.FirstOrDefaultAsync(p => p.AccountId == accountId);
                cartItem.Product = await _context.Product.FirstOrDefaultAsync(p => p.Id == productId);
                cartItem.Price = cartItem.Product.Price * cartItem.Quantity;
                _context.Add(cartItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/CartItems/Create.cshtml", cartItem);
        }

        // GET: CartItems/Edit/5
        public async Task<IActionResult> CartItemEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem.FindAsync(id);
            if (cartItem == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/CartItems/Edit.cshtml", cartItem);
        }

        // POST: CartItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CartItemEdit(int id, [Bind("Id,Quantity,TotalPrice")] CartItem cartItem)
        {
            if (id != cartItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemExists(cartItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/CartItems/Edit.cshtml", cartItem);
        }

        // GET: CartItems/Delete/5
        public async Task<IActionResult> CartItemDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/CartItems/Delete.cshtml", cartItem);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("CartItemDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CartItemDeleteConfirmed(int id)
        {
            var cartItem = await _context.CartItem.FindAsync(id);
            _context.CartItem.Remove(cartItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }


        private bool CartItemExists(int id)
        {
            return _context.CartItem.Any(e => e.Id == id);
        }

        // GET: CartItems/Details/5
        public async Task<IActionResult> OrderItemDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/OrderItems/Details.cshtml", orderItem);
        }

        // GET: CartItems/Create
        public IActionResult OrderItemCreate()
        {
            ViewData["Accounts"] = new SelectList(_context.Account, "Id", "Name");
            ViewData["Products"] = new SelectList(_context.Product, "Id", "Name");
            return View("~/Views/Admin/OrderItems/Create.cshtml");
        }

        // POST: CartItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrderItemCreate([Bind("Id, Quantity, TotalPrice")] OrderItem orderItem, int productId, int accountId)
        {
            if (ModelState.IsValid)
            {
                orderItem.Order = await _context.Order.Include(a => a.Account).FirstOrDefaultAsync(p => p.Account.Id == accountId);
                orderItem.Product = await _context.Product.FirstOrDefaultAsync(p => p.Id == productId);
                orderItem.Price = orderItem.Product.Price * orderItem.Quantity;
                _context.Add(orderItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/OrderItems/Create.cshtml", orderItem);
        }

        // GET: orderItem/Edit/5
        public async Task<IActionResult> OrderItemEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/OrderItems/Edit.cshtml", orderItem);
        }

        // POST: CartItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrderItemEdit(int id, [Bind("Id,Quantity,TotalPrice")] OrderItem orderItem)
        {
            if (id != orderItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemExists(orderItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/OrderItems/Edit.cshtml", orderItem);
        }

        // GET: CartItems/Delete/5
        public async Task<IActionResult> OrderItemDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/OrderItems/Delete.cshtml", orderItem);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("OrderItemDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrderItemDeleteConfirmed(int id)
        {
            var orderItem = await _context.OrderItem.FindAsync(id);
            _context.OrderItem.Remove(orderItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }


        private bool OrderItemExists(int id)
        {
            return _context.CartItem.Any(e => e.Id == id);
        }

        // GET: Carts/Details/5
        public async Task<IActionResult> CartDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .Include(c => c.Account)
                .Include(i => i.CartItems).ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Carts/Details.cshtml", cart);
        }
        // GET: Carts/Create
        public IActionResult CartCreate()
        {
            ViewData["Accounts"] = new SelectList(_context.Account, "Id", "Name");
            return View("~/Views/Admin/Carts/Create.cshtml");
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CartCreate([Bind("Id,AccountId")] Cart cart)
        {
            if (!_context.Cart.Any(a => a.AccountId == cart.AccountId))
            {
                if (ModelState.IsValid)
                {
                    _context.Add(cart);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Tables));
                }
            }
            TempData["CartError"] = "Account has cart already";
            ViewData["Accounts"] = new SelectList(_context.Account, "Id", "Name", cart.AccountId);
            return View("~/Views/Admin/Carts/Create.cshtml", cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> CartEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", cart.AccountId);
            return View("~/Views/Admin/Carts/Edit.cshtml", cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CartEdit(int id, [Bind("Id,AccountId")] Cart cart)
        {
            if (id != cart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", cart.AccountId);
            return View("~/Views/Admin/Carts/Edit.cshtml", cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> CartDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .Include(c => c.Account)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Carts/Delete.cshtml", cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("CartDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CartDeleteConfirmed(int id)
        {
            var cart = await _context.Cart.Include(o => o.CartItems).FirstOrDefaultAsync(o => o.Id == id);
            foreach (CartItem ci in cart.CartItems)
            {
                _context.CartItem.Remove(ci);
            }
            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }

        private bool CartExists(int id)
        {
            return _context.Cart.Any(e => e.Id == id);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> OrderDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(p => p.OrderItems).ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Orders/Details.cshtml", order);
        }

        // GET: Orders/Create
        public IActionResult OrderCreate()
        {
            return View("~/Views/Admin/Orders/Create.cshtml");
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> OrderCreate([Bind("Id,Country,City,Address,PostalCode,PhoneNumber,TotalPrice,Delivery,OrderTime")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderTime = DateTime.Now;
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Orders/Create.cshtml", order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> OrderEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Orders/Edit.cshtml", order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrderEdit(int id, [Bind("Id,Country,City,Address,PostalCode,PhoneNumber,TotalPrice,Delivery,OrderTime")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Tables));
            }
            return View("~/Views/Admin/Orders/Edit.cshtml", order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> OrderDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View("~/Views/Admin/Orders/Delete.cshtml", order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("OrderDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrderDeleteConfirmed(int id)
        {
            var order = await _context.Order.Include(o => o.OrderItems).FirstOrDefaultAsync(o => o.Id == id);
            foreach (OrderItem ci in order.OrderItems)
            {
                _context.OrderItem.Remove(ci);
            }
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Tables));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}
