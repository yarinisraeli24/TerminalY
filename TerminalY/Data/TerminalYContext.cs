using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TerminalY.Models;

namespace TerminalY.Data
{
    public class TerminalYContext : DbContext
    {
        public TerminalYContext (DbContextOptions<TerminalYContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<TerminalY.Models.Account> Account { get; set; }

        public DbSet<TerminalY.Models.Category> Category { get; set; }

        public DbSet<TerminalY.Models.Product> Product { get; set; }

        public DbSet<TerminalY.Models.Cart> Cart { get; set; }

        public DbSet<TerminalY.Models.CartItem> CartItem { get; set; }

        public DbSet<TerminalY.Models.Contact> Contact { get; set; }

        public DbSet<TerminalY.Models.Order> Order { get; set; }

        public DbSet<TerminalY.Models.OrderItem> OrderItem { get; set; }

        public DbSet<TerminalY.Models.Branches> Branches { get; set; }
    }
}
