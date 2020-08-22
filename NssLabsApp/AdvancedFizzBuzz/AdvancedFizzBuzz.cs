using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedFizzBuzz
{
    public class AdvancedFizzBuzz
    {
        public AdvancedFizzBuzzConfig Config { get; set; }


        AdvancedFizzBuzz(AdvancedFizzBuzzConfig Config)
        {
            this.Config = Config;
        }

        public IList<string> generateFizzBuzz( IList<int> numbers )
        {
            var result = new List<string>();
            numbers.ToList().ForEach(number => {
                var param = Config.Params.FirstOrDefault(x => x.matches(number));
                if ( param != null)
                {
                    result.Add(param.Token);
                }
                else
                {
                    result.Add(number.ToString());
                }
            });
            return result;
        }
    }
}
