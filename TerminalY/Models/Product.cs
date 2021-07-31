using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
        [Required]
        public int Price { get; set; }
        public List<CartItem> CartItems { get; set; }
        public DateTime Created { get; set; }
        [DisplayName("Image File")]
        public String Image { get; set; }
        public List<Branches> Branches { get; set; }
    }
}
