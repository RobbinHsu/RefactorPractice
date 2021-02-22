using System;

namespace Simplifying_Conditional_Expressions
{
    public class IntroduceNullObject
    {
        private readonly Site _site;
        public string CustomerName;
        public int WeeksDelinquent;
        private Customer Customer;
        public BillingPlan Plan;

        public IntroduceNullObject(Site site)
        {
            _site = site;
        }

        public void Sample()
        {
            Customer = _site.Customer;

            if (Customer.IsNull())
            {
                Plan = BillingPlan.Basic();
            }
            else
            {
                Plan = Customer.GetPlan();
            }

            CustomerName = Customer.GetName();

            WeeksDelinquent = Customer.GetHistory().GetWeeksDelinquentInLastYear();
        }
    }
}