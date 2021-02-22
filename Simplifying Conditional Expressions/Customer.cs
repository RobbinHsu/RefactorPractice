namespace Simplifying_Conditional_Expressions
{
    public class Customer
    {
        public static Customer NewNull()
        {
            return new NullCustomer();
        }

        public virtual PaymentHistory GetHistory()
        {
            return new PaymentHistory();
        }

        public virtual string GetName()
        {
            return string.Empty;
        }

        public virtual BillingPlan GetPlan()
        {
            return new BillingPlan() {Type = "Special"};
        }
    }
}