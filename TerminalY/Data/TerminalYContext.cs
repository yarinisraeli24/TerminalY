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

        public DbSet<TerminalY.Models.Account> Account { get; set; }

        public DbSet<TerminalY.Models.Category> Category { get; set; }

        public DbSet<TerminalY.Models.Product> Product { get; set; }
    }
}
