using System;

namespace Simplifying_Conditional_Expressions
{
    public class Site
    {
        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
        }

        public Site(Customer customer)
        {
            _customer = customer;
        }
    }
}