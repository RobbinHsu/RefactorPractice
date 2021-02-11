namespace RefactorPractice.Ch1Lab
{
    public class Rental
    {
        public Movie Movie { get; }

        public int DayRented { get; }

        public Rental(Movie movie, int dayRented)
        {
            Movie = movie;
            DayRented = dayRented;
        }

        public double GetCharge()
        {
            var thisAmount = 0.0;

            switch (Movie.PriceCode)
            {
                case Movie.Regular:
                    thisAmount += 2;
                    if (DayRented > 2)
                    {
                        thisAmount += (DayRented - 2) * 1.5;
                    }

                    break;

                case Movie.New_Release:
                    thisAmount += DayRented * 3;
                    break;

                case Movie.Childrens:
                    thisAmount += 1.5;
                    if (DayRented > 3)
                    {
                        thisAmount += (DayRented - 3) * 1.5;
                    }

                    break;
            }

            return thisAmount;
        }

        public int GetFrequentRenterPoints()
        {
            if (Movie.PriceCode == Movie.New_Release && DayRented > 1)
            {
                return 2;
            }

            return 1;
        }
    }
}