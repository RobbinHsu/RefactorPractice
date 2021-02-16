using System.Collections.Generic;

namespace RefactorPractice.Ch1Lab
{
    public class TextStatement : Statement
    {
        protected override string FooterString(Customer customer)
        {
            return $"Amount owed is {customer.GetTotalAmount()} \n" +
                   $"You earned {customer.GetTotalFrequentRenterPoints()} frequent renter points";
        }

        protected override string EachRentalString(Rental item)
        {
            return $"{item.Movie.Title} {item.GetCharge()} \n";
        }

        protected override string HeaderString(Customer customer)
        {
            return $"Rental Record for {customer.Name} \n";
        }
    }
}