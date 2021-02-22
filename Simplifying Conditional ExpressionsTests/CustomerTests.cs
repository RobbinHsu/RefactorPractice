using NUnit.Framework;
using Simplifying_Conditional_Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simplifying_Conditional_Expressions.Tests
{
    [TestFixture()]
    public class CustomerTests
    {
        private IntroduceNullObject _customer;

        [Test()]
        public void GetCustomerName()
        {
            GivenCustomerObject(null);
            WhenSampleExecute();
            ShouldBeEqual("occupant");
        }

        [Test()]
        public void GetWeeksDelinquent()
        {
            _customer = new IntroduceNullObject(new Site(null));
            WhenSampleExecute();
            Assert.AreEqual(0, _customer.WeeksDelinquent);
        }

        private void GivenCustomerObject(Customer customer)
        {
            _customer = new IntroduceNullObject(new Site(customer));
        }

        private void ShouldBeEqual(string occupant)
        {
            Assert.AreEqual(occupant, _customer.CustomerName);
        }

        private void WhenSampleExecute()
        {
            _customer.Sample();
        }
    }
}