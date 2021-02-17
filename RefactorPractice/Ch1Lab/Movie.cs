using System;
using System.Linq;

namespace RefactorPractice.Ch1Lab
{
    /// <summary>The movie.</summary>
    public class Movie
    {
        public const int Childrens = 2;

        public const int Regular = 0;

        public const int New_Release = 1;

        public string Title { get; }

        public int PriceCode { get; set; }

        public Movie(string title, int priceCode)
        {
            Title = title;
            SetPriceCode(priceCode);
        }

        public double GetCharge(int dayRented)
        {
            var thisAmount = 0.0;

            switch (PriceCode)
            {
                case Regular:
                    thisAmount += 2;
                    if (dayRented > 2)
                    {
                        thisAmount += (dayRented - 2) * 1.5;
                    }

                    break;

                case New_Release:
                    thisAmount += dayRented * 3;
                    break;

                case Childrens:
                    thisAmount += 1.5;
                    if (dayRented > 3)
                    {
                        thisAmount += (dayRented - 3) * 1.5;
                    }

                    break;
            }

            return thisAmount;
        }

        public int GetFrequentRenterPoints(int dayRented)
        {
            if (PriceCode == New_Release && dayRented > 1)
            {
                return 2;
            }

            return 1;
        }

        private void SetPriceCode(int priceCode)
        {
            switch (priceCode)
            {
                case Regular:
                    PriceCode = Regular;
                    break;

                case New_Release:
                    PriceCode = New_Release;
                    break;

                case Childrens:
                    PriceCode = Childrens;
                    break;
            }
        }
    }
}