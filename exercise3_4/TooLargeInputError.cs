using System;

namespace exercise3_4
{
    internal class TooLargeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a too large input. This fired an error!";
        }
    }
}