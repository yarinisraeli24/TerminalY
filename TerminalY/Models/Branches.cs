using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalY.Models
{
    public class Branches
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public List<Product> products { get; set; }
    }
}
