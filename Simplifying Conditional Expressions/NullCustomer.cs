﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simplifying_Conditional_Expressions
{
    public class NullCustomer : Customer
    {
        public override string GetName()
        {
            return "occupant";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}