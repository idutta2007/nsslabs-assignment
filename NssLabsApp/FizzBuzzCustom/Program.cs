using fizzBuzzLib;
using System;
using System.Linq;

namespace FizzBuzzCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new AdvancedFizzBuzzConfig();
            config.AddParam(3, "Fizz");
            config.AddParam(11, "Buzz");
            config.AddParam(42, "Bang");

            var fizzBuzz = new AdvancedFizzBuzz(config);

            var result = fizzBuzz.generateFizzBuzz(Enumerable.Range(-18, 235 + 19).ToArray());
            result.ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });
            Console.ReadLine(); 

        }
    }
}
