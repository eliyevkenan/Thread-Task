using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp75
{
    internal class Order
    {
        public int No { get; set; }
        private static int _no;
        public Order()
        {
            _no++;
            No = _no;
        }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
