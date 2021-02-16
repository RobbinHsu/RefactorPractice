namespace RefactorPractice.Ch1Lab
{
    public class HtmlStatement : Statement
    {
        protected override string FooterString(Customer customer)
        {
            return $"<P>You owe <EM>{customer.GetTotalAmount()}</EM><P>" +
                   $"on this rental you earned earned <EM>{customer.GetTotalFrequentRenterPoints()}</EM> frequent renter points<P>";
        }

        protected override string EachRentalString(Rental item)
        {
            return $"{item.Movie.Title} : {item.GetCharge()}<BR>";
        }

        protected override string HeaderString(Customer customer)
        {
            return $"<H1>Rental Record for <EM>{customer.Name}</EM></H1><P>";
        }
    }
}