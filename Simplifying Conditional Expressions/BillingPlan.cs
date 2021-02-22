using System;

namespace Simplifying_Conditional_Expressions
{
    public class BillingPlan
    {
        // 用來確認得到哪一種 BillingPlan
        public string Type { get; set; }

        public static BillingPlan Basic()
        {
            return new BillingPlan {Type = "Basic"};
        }
    }
}