using fizzBuzzLib;
using System;
using System.Linq;

namespace FizzBuzzBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new AdvancedFizzBuzzConfig();
            config.AddParam(3, "Fizz");
            config.AddParam(5, "Buzz");

            var fizzBuzz = new AdvancedFizzBuzz(config);

            var result = fizzBuzz.generateFizzBuzz(Enumerable.Range(1, 100).ToArray());
            result.ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });
            Console.ReadLine();
        }
    }
}
