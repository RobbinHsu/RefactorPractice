namespace Simplifying_Conditional_Expressions
{
    public class Customer
    {
        public string Name { get; set; }

        public BillingPlan Plan { get; set; }

        public PaymentHistory History { get; set; }

        public string GetName()
        {
            return string.Empty;
        }

        public virtual bool IsNull()
        {
            return false;
        }
    }
}