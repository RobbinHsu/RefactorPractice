using NUnit.Framework;
using RefactorPractice.Ch1Lab;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPractice.Ch1Lab.Tests
{
    [TestFixture()]
    public class CustomerTests
    {
        private string _actual;
        private Customer _customer;
        private Rental _rental;

        [Test()]
        public void GetChildrenMovieHtmlStatement()
        {
            GivenCustomerName("Tom");
            GivenRentalMovieInfo("Movie2", 2, 10);
            CustomerRentalMovie();
            GetHtmlStatement();
            ShouldBeEqualHtml("Tom", "Movie2", 12, 1);
        }

        [Test()]
        public void GetNewReleaseTextStatement()
        {
            GivenCustomerName("Bryan");
            GivenRentalMovieInfo("Movie1", 1, 5);
            CustomerRentalMovie();
            GetTextStatement();
            ShouldBeEqualText("Bryan", "Movie1", 15, 2);
        }

        [Test()]
        public void GetRegularMovieHtmlStatement()
        {
            GivenCustomerName("Bryan");
            GivenRentalMovieInfo("Movie1", 0, 2);
            CustomerRentalMovie();
            GetHtmlStatement();
            ShouldBeEqualHtml("Bryan", "Movie1", 2, 1);
        }

        private void ShouldBeEqualText(string name, string movie, int price, int frequentPoints)
        {
            var expected =
                $"Rental Record for {name} \n{movie} {price} \nAmount owed is {price} \nYou earned {frequentPoints} frequent renter points";
            Assert.AreEqual(expected, _actual);
        }

        private void GetTextStatement()
        {
            _actual = _customer.Statement;
        }

        private void ShouldBeEqualHtml(string name, string movie, int price, int frequentPoints)
        {
            var expected =
                $"<H1>Rental Record for <EM>{name}</EM></H1><P>{movie} : {price}<BR><P>You owe <EM>{price}</EM><P>on this rental you earned earned <EM>{frequentPoints}</EM> frequent renter points<P>";
            Assert.AreEqual(expected, _actual);
        }

        private void GetHtmlStatement()
        {
            _actual = _customer.HtmlStatement;
        }

        private void CustomerRentalMovie()
        {
            _customer.AddRental(_rental);
        }

        private void GivenRentalMovieInfo(string movie, int priceCode, int dayRented)
        {
            _rental = new Rental(new Movie(movie, priceCode), dayRented);
        }

        private void GivenCustomerName(string name)
        {
            _customer = new Customer(name);
        }
    }
}