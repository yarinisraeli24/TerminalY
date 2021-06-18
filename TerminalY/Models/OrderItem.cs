using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalY.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        [DefaultValue(1)]
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
    }
}
