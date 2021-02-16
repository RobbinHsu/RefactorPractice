namespace RefactorPractice.Ch1Lab
{
    public class HtmlStatement
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
            return $"<P>You owe <EM>{customer.GetTotalAmount()}</EM><P>" +
                   $"on this rental you earned earned <EM>{customer.GetTotalFrequentRenterPoints()}</EM> frequent renter points<P>";
        }

        private static string EachRentalString(Rental item)
        {
            return $"{item.Movie.Title} : {item.GetCharge()}<BR>";
        }

        private static string HeaderString(Customer customer)
        {
            return $"<H1>Rental Record for <EM>{customer.Name}</EM></H1><P>";
        }
    }
}