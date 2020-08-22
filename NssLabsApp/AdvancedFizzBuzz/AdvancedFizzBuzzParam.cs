using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedFizzBuzz
{
    public class AdvancedFizzBuzzParam
    {
        public ISet<int> Divisors { get; set; } = new HashSet<int>();
        public string Token { get; set; }

        public bool matches(int value)
        {
            return Divisors.Count(x => value % x == 0) == Divisors.Count;
        }
    }
}
