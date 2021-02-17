﻿using System;
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

        public int PriceCode { get; set; }

        public Movie(string title, int priceCode)
        {
            Title = title;
            SetPriceCode(priceCode);
        }

        public double GetCharge(int dayRented)
        {
            return _price.GetCharge(dayRented);
        }


        public int GetFrequentRenterPoints(int dayRented)
        {
            if (PriceCode == New_Release && dayRented > 1)
            {
                return 2;
            }

            return 1;
        }

        private int GetPriceCode()
        {
            return _price.GetPriceCode();
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