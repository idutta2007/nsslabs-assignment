using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedFizzBuzz
{
    public class AdvancedFizzBuzzConfig
    {
        public ISet<AdvancedFizzBuzzParam> Params { get; set; } = new HashSet<AdvancedFizzBuzzParam>();

        public void AddParam( int [] numbers, string token)
        {
            Params.Add(new AdvancedFizzBuzzParam
            {
                Divisors = new HashSet<int>(numbers),
                Token = token
            });
        }
    }
}
