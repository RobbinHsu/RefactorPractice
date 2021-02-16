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

        public string Name { get; }


        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            Rental.Add(rental);
        }

        public string GetHtmlStatement()
        {
            var result = $"<H1>Rental Record for <EM>{Name}</EM></H1><P>";
            foreach (var item in Rental)
            {
                result += $"{item.Movie.Title} : {item.GetCharge()}<BR>";
            }

            result += $"<P>You owe <EM>{GetTotalAmount()}</EM><P>";
            result +=
                $"on this rental you earned earned <EM>{GetTotalFrequentRenterPoints()}</EM> frequent renter points<P>";

            return result;
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