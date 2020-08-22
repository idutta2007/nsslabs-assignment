using System;
using System.Collections.Generic;

namespace fizzBuzzLib
{
    public class AdvancedFizzBuzzParam
    {
        public int Number { get; set; }
        public string Token { get; set; }

        public bool Matches(int value)
        {
            return Number != 0 ? value % Number == 0 : false;
        }
    }
}
