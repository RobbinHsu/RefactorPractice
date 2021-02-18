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

            PrintBanner();

            foreach (var order in _orders)
            {
                outstanding += order.GetAmount();
            }

            PrintDetails(outstanding);
        }

        private void PrintDetails(double outstanding)
        {
            // print detail
            Console.WriteLine($"name:{_name}");
            Console.WriteLine($"amount:{outstanding}");
        }

        private void PrintBanner()
        {
            // print banner
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes  *****");
            Console.WriteLine("**************************");
        }
    }
}
