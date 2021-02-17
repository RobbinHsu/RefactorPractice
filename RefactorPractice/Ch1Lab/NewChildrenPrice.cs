﻿namespace RefactorPractice.Ch1Lab
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

        public override double GetCharge(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += 1.5;
            if (dayRented > 3)
            {
                thisAmount += (dayRented - 3) * 1.5;
            }

            return thisAmount;
        }
    }
}