﻿namespace RefactorPractice.Ch1Lab
{
    public abstract class Price
    {
        public abstract int GetPriceCode();
        public abstract double GetCharge(int dayRented);
    }
}