namespace Simplifying_Conditional_Expressions
{
    public class Customer
    {
        public string Name { get; set; }

        public BillingPlan Plan { get; set; }

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

        public virtual bool IsNull()
        {
            return false;
        }
    }
}