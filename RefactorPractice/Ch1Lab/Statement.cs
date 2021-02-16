namespace RefactorPractice.Ch1Lab
{
    public abstract class Statement
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

        protected abstract string FooterString(Customer customer);
        protected abstract string EachRentalString(Rental item);
        protected abstract string HeaderString(Customer customer);
    }
}