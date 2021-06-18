﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalY.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Cart Cart { get; set; }
        [DefaultValue(1)]
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

    }
}
