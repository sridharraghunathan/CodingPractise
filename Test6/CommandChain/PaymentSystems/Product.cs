using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string HandledBy { get; set; }
    }
}
