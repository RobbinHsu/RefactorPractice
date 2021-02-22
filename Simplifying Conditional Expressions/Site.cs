using System;

namespace Simplifying_Conditional_Expressions
{
    public class Site
    {
        private readonly Customer _customer;

        public Customer Customer => _customer ?? Customer.NewNull();

        public Site(Customer customer)
        {
            _customer = customer;
        }
    }
}