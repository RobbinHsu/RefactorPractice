using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactorPractice.Ch1Lab
{
    /// <summary>The movie.</summary>
    public class Movie
    {
        private readonly Dictionary<int, Price> _lookupPrice = new Dictionary<int, Price>()
        {
            {0, new RegularPrice()},
            {1, new NewReleasePrice()},
            {2, new NewChildrenPrice()},
        };

        private Price _price;
        public Price Price => _price;

        public string Title { get; }

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
            _lookupPrice.TryGetValue(priceCode, out _price);
        }
    }
}