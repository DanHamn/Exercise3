using System;

namespace exercise3_4
{
    internal class SymbolicInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a invalid symbol input. This fired an error!";
        }
    }
}