using System;
using System.Collections.Generic;
using System.Text;

namespace fizzBuzzLib
{
    public class AdvancedFizzBuzzConfig
    {
        public IList<AdvancedFizzBuzzParam> Params { get; set; } = new List<AdvancedFizzBuzzParam>();

        public void AddParam(int number, string token)
        {
            Params.Add(new AdvancedFizzBuzzParam
            {
                Number = number,
                Token = token
            });
        }
    }
}
