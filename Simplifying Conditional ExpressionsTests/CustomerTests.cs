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
        public void GetBillingPlan()
        {
            GivenCustomerObject(new Customer());
            WhenSampleExecute();
            Assert.AreEqual("Special", _introduceNullObject.Plan.Type);
        }

        [Test()]
        public void GetCustomerName()
        {
            GivenCustomerObject(new Customer());
            WhenSampleExecute();
            CustomerNameShouldBeEqual(string.Empty);
        }

        [Test()]
        public void GetNullBillingPlan()
        {
            GivenCustomerObject(null);
            WhenSampleExecute();
            Assert.AreEqual("Basic", _introduceNullObject.Plan.Type);
        }

        [Test()]
        public void GetNullCustomerName()
        {
            GivenCustomerObject(null);
            WhenSampleExecute();
            CustomerNameShouldBeEqual("occupant");
        }

        [Test()]
        public void GetNullWeeksDelinquent()
        {
            GivenCustomerObject(null);
            WhenSampleExecute();
            WeeksDelinquentShouldBeEqual(0);
        }

        [Test()]
        public void GetWeeksDelinquent()
        {
            GivenCustomerObject(new Customer());
            WhenSampleExecute();
            WeeksDelinquentShouldBeEqual(1);
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