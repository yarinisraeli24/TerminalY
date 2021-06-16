using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TerminalY.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Category Category { get; set; }
        [Required]
        public string Description { get; set; }
        //public double InStock { get; set; }
        [Required]
        public int Price { get; set; }
        public DateTime Created { get; set; }
        [Required]
        public String Image { get; set; }
    }
}