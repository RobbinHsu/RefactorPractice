namespace RefactorPractice.Ch1Lab
{
    public class RegularPrice : Price
    {
        public RegularPrice()
        {
        }

        public override int GetPriceCode()
        {
            return Movie.Regular;
        }
    }
}