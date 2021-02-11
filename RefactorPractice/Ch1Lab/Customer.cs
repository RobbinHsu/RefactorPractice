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
            // 總消費金額
            var totalAmount = 0.0;

            // 常客積點
            var frequentRenterPoints = 0;
            var result = $"Rental Record for {Name} \n";

            foreach (var item in _rental)
            {
                var thisAmount = AmountFor(item);

                frequentRenterPoints++;
                if (item.Movie.PriceCode == Movie.New_Release && item.DayRented > 1)
                {
                    frequentRenterPoints++;
                }

                result += $"{item.Movie.Title} {thisAmount} \n";
                totalAmount += thisAmount;
            }

            result += $"Amount owed is {totalAmount} \n";
            result += $"You earned {frequentRenterPoints} frequent renter points";

            return result;
        }

        private double AmountFor(Rental aRental)
        {
            var thisAmount = 0.0;

            switch (aRental.Movie.PriceCode)
            {
                case Movie.Regular:
                    thisAmount += 2;
                    if (aRental.DayRented > 2)
                    {
                        thisAmount += (aRental.DayRented - 2) * 1.5;
                    }

                    break;

                case Movie.New_Release:
                    thisAmount += aRental.DayRented * 3;
                    break;

                case Movie.Childrens:
                    thisAmount += 1.5;
                    if (aRental.DayRented > 3)
                    {
                        thisAmount += (aRental.DayRented - 3) * 1.5;
                    }

                    break;
            }

            return thisAmount;
        }
    }
}