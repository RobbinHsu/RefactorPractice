using System.Collections.Generic;

namespace RefactorPractice.Ch1Lab
{
    public class TextStatement
    {
        public string Value(Customer customer)
        {
            var result = $"Rental Record for {customer.Name} \n";
            foreach (var item in customer.Rental)
            {
                result += $"{item.Movie.Title} {item.GetCharge()} \n";
            }

            result += $"Amount owed is {customer.GetTotalAmount()} \n";
            result += $"You earned {customer.GetTotalFrequentRenterPoints()} frequent renter points";

            return result;
        }
    }
}