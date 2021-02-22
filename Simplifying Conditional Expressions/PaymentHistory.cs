namespace Simplifying_Conditional_Expressions
{
    public class PaymentHistory
    {
        public static PaymentHistory NewNull()
        {
            return new NullPaymentHistory();
        }

        public virtual int GetWeeksDelinquentInLastYear()
        {
            return 1;
        }
    }
}