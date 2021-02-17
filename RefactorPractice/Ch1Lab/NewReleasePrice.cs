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
    }
}