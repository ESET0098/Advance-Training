using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemo
{
    internal class Person
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
    }
}
