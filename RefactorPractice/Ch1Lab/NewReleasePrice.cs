namespace RefactorPractice.Ch1Lab
{
    public class NewReleasePrice : Price
    {
        public NewReleasePrice()
        {
        }

        public override double GetCharge(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += dayRented * 3;
            return thisAmount;
        }

        public override int GetFrequentRenterPoints(int dayRented)
        {
            return dayRented > 1 ? 2 : 1;
        }
    }
}