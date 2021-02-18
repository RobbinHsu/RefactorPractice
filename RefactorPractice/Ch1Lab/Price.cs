namespace RefactorPractice.Ch1Lab
{
    public abstract class Price
    {
        public abstract double GetCharge(int dayRented);

        public virtual int GetFrequentRenterPoints(int dayRented)
        {
            return 1;
        }
    }
}