namespace Simplifying_Conditional_Expressions
{
    public class Customer
    {
        public readonly PaymentHistory History = new PaymentHistory();
        public string Name { get; set; }

        public BillingPlan Plan { get; set; }

        public string GetName()
        {
            return string.Empty;
        }

        public virtual bool IsNull()
        {
            return false;
        }

        public static Customer NewNull()
        {
            return new NullCustomer();
        }
    }
}