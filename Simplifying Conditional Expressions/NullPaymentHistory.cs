namespace Simplifying_Conditional_Expressions
{
    public class NullPaymentHistory : PaymentHistory
    {
        public override int GetWeeksDelinquentInLastYear()
        {
            return 0;
        }
    }
}