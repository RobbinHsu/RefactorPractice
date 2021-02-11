using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace RefactorPractice.Ch1Lab
{
    public class Customer
    {
        private List<Rental> _rental = new List<Rental>();

        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            _rental.Add(rental);
        }

        public string GetStatement()
        {
            var result = $"Rental Record for {Name} \n";
            foreach (var item in _rental)
            {
                result += $"{item.Movie.Title} {item.GetCharge()} \n";
            }

            result += $"Amount owed is {GetTotalAmount()} \n";
            result += $"You earned {GetTotalFrequentRenterPoints()} frequent renter points";

            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            // 常客積點
            var result = 0;
            foreach (var item in _rental)
            {
                result = item.GetFrequentRenterPoints();
            }

            return result;
        }

        private double GetTotalAmount()
        {
            // 總消費金額
            var totalAmount = 0.0;
            foreach (var item in _rental)
            {
                totalAmount += item.GetCharge();
            }

            return totalAmount;
        }
    }
}