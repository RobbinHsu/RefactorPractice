﻿namespace RefactorPractice.Ch1Lab
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
    }
}