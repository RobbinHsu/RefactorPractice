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
        private IntroduceNullObject _introduceNullObject;

        [Test()]
        public void GetCustomerName()
        {
            GivenCustomerObject(null);
            WhenSampleExecute();
            CustomerNameShouldBeEqual("occupant");
        }

        [Test()]
        public void GetWeeksDelinquent()
        {
            GivenCustomerObject(null);
            WhenSampleExecute();
            WeeksDelinquentShouldBeEqual(0);
        }

        private void WeeksDelinquentShouldBeEqual(int expected)
        {
            Assert.AreEqual(expected, _introduceNullObject.WeeksDelinquent);
        }

        private void GivenCustomerObject(Customer customer)
        {
            _introduceNullObject = new IntroduceNullObject(new Site(customer));
        }

        private void CustomerNameShouldBeEqual(string occupant)
        {
            Assert.AreEqual(occupant, _introduceNullObject.CustomerName);
        }

        private void WhenSampleExecute()
        {
            _introduceNullObject.Sample();
        }
    }
}