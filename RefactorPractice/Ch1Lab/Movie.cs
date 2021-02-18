using System;
using System.Linq;

namespace RefactorPractice.Ch1Lab
{
    /// <summary>The movie.</summary>
    public class Movie
    {
        private Price _price;
        public const int Childrens = 2;

        public const int Regular = 0;

        public const int New_Release = 1;

        public string Title { get; }

        public Price Price
        {
            set { _price = value; }
            get { return _price; }
        }

        public Movie(string title, int priceCode)
        {
            Title = title;
            SetPriceCode(priceCode);
        }

        public double GetCharge(int dayRented)
        {
            return _price.GetCharge(dayRented);
        }

        private void SetPriceCode(int priceCode)
        {
            switch (priceCode)
            {
                case Regular:
                    _price = new RegularPrice();
                    break;

                case New_Release:
                    _price = new NewReleasePrice();
                    break;

                case Childrens:
                    _price = new NewChildrenPrice();
                    break;
            }
        }
    }
}