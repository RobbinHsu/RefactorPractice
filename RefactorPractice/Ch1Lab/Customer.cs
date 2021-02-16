using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace RefactorPractice.Ch1Lab
{
    public class Customer
    {
        public readonly List<Rental> Rental = new List<Rental>();
        public string Statement => new TextStatement().Value(this);
        public string HtmlStatement => new HtmlStatement().Value(this);

        public string Name { get; }


        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            Rental.Add(rental);
        }


        public int GetTotalFrequentRenterPoints()
        {
            // 常客積點
            var result = 0;
            foreach (var item in Rental)
            {
                result = item.GetFrequentRenterPoints();
            }

            return result;
        }

        public double GetTotalAmount()
        {
            // 總消費金額
            var totalAmount = 0.0;
            foreach (var item in Rental)
            {
                totalAmount += item.GetCharge();
            }

            return totalAmount;
        }
    }
}