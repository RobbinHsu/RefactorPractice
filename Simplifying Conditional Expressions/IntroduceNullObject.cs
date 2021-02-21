using System;

namespace Simplifying_Conditional_Expressions
{
    public class IntroduceNullObject
    {
        public void Sample()
        {
            var customer = new Site().Customer;
            BillingPlan plan;
            string customerName;
            int weeksDelinquent;

            if (customer == null)
            {
                plan = new BillingPlan();
            }
            else
            {
                plan = customer.Plan;
            }

            if (customer == null)
            {
                customerName = "occupant";
            }
            else
            {
                customerName = customer.GetName();
            }

            if (customer == null)
            {
                weeksDelinquent = 0;
            }
            else
            {
                weeksDelinquent = customer.History.GetWeeksDelinquentInLastYear();
            }
        }
    }
}