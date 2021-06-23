using System;

namespace exercise3_4
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to input a null value. This fired an error!";
        }
    }
}