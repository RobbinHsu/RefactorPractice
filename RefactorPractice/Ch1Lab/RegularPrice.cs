namespace RefactorPractice.Ch1Lab
{
    public class RegularPrice : Price
    {
        public RegularPrice()
        {
        }

        public override double GetCharge(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += 2;
            if (dayRented > 2)
            {
                thisAmount += (dayRented - 2) * 1.5;
            }

            return thisAmount;
        }

        public override int GetPriceCode()
        {
            return Movie.Regular;
        }
    }
}