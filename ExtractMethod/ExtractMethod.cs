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
            PrintBanner();

            var outstanding = GetOutstanding();

            PrintDetails(outstanding);
        }

        private double GetOutstanding()
        {
            var result = 0.0;
            foreach (var order in _orders)
            {
                result += order.GetAmount();
            }

            return result;
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