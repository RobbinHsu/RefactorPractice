using System.Collections.Generic;

namespace RefactorPractice.Ch1Lab
{
    public class TextStatement
    {
        public string Value(Customer customer)
        {
            var result = HeaderString(customer);
            foreach (var item in customer.Rental)
            {
                result += EachRentalString(item);
            }

            result += FooterString(customer);

            return result;
        }

        private string FooterString(Customer customer)
        {
            return $"Amount owed is {customer.GetTotalAmount()} \n" +
                   $"You earned {customer.GetTotalFrequentRenterPoints()} frequent renter points";
        }

        private static string EachRentalString(Rental item)
        {
            return $"{item.Movie.Title} {item.GetCharge()} \n";
        }

        private static string HeaderString(Customer customer)
        {
            return $"Rental Record for {customer.Name} \n";
        }
    }
}