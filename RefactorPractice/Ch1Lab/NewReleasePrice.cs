namespace RefactorPractice.Ch1Lab
{
    public class NewReleasePrice : Price
    {
        public NewReleasePrice()
        {
        }

        public override int GetPriceCode()
        {
            return Movie.New_Release;
        }

        public override double GetCharge(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += dayRented * 3;
            return thisAmount;
        }
    }
}