using System;
using System.Collections.Generic;

namespace ExtractMethod
{
    public class ExtractMethod
    {
        private string _name;
        private List<Order> _orders = new List<Order>();

        public void PrintOwing()
        {
            var outstanding = 0.0;

            // print banner
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes  *****");
            Console.WriteLine("**************************");

            foreach (var order in _orders)
            {
                outstanding += order.GetAmount();
            }

            // print detail
            Console.WriteLine($"name:{_name}");
            Console.WriteLine($"amount:{outstanding}");
        }
    }
}
