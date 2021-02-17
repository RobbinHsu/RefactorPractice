namespace RefactorPractice.Ch1Lab
{
    public class NewChildrenPrice : Price
    {
        public NewChildrenPrice()
        {
        }

        public override int GetPriceCode()
        {
            return Movie.Childrens;
        }
    }
}