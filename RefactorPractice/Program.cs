using System;
using System.Collections.Generic;
using System.Linq;
using RefactorPractice.Ch1Lab;

namespace RefactorPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customer = new Customer("Bryan");
            var rental = new Rental(new Movie("Movie1", 0), 2);
            customer.AddRental(rental);
            var result = customer.Statement;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}