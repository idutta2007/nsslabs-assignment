using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fizzBuzzLib
{
    public class AdvancedFizzBuzz
    {
        public AdvancedFizzBuzzConfig Config { get; set; }


        public AdvancedFizzBuzz(AdvancedFizzBuzzConfig Config)
        {
            this.Config = Config;
        }

        public IList<string> generateFizzBuzz(params int [] numbers )
        {
            var result = new List<string>();
            foreach( int number in numbers )
            {
                var matchedParams = from x in Config.Params where x.Matches(number) select x;
                result.Add(GenerateOutputToken(matchedParams, number));
            }
            return result;
        }

        private string GenerateOutputToken(IEnumerable<AdvancedFizzBuzzParam> matchedParams, int number )
        {
            if (matchedParams.Count() == 0) return number.ToString();

            var tokens = from x in matchedParams select x.Token;
            return String.Join( "", tokens.ToList<string>());
        }
    }
}
