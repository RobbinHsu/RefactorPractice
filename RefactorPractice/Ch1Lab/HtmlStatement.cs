namespace RefactorPractice.Ch1Lab
{
    public class HtmlStatement
    {
        public string Value(Customer customer)
        {
            var result = $"<H1>Rental Record for <EM>{customer.Name}</EM></H1><P>";
            foreach (var item in customer.Rental)
            {
                result += $"{item.Movie.Title} : {item.GetCharge()}<BR>";
            }

            result += $"<P>You owe <EM>{customer.GetTotalAmount()}</EM><P>";
            result +=
                $"on this rental you earned earned <EM>{customer.GetTotalFrequentRenterPoints()}</EM> frequent renter points<P>";

            return result;
        }
    }
}