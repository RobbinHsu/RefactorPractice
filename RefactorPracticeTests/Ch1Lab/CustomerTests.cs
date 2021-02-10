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
        [Test()]
        public void GetStatementTest()
        {
            var customer = new Customer("Bryan");
            var rental = new Rental(new Movie("Movie1", 0), 2);
            customer.AddRental(rental);
            var actual = customer.GetStatement();
            var expected =
                "Rental Record for Bryan \nMovie1 2 \nAmount owed is 2 \nYou earned 1 frequent renter points";
            Assert.AreEqual(expected, actual);
        }
    }
}