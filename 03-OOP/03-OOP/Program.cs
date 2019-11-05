using System;
using System.Linq;

namespace _03_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // using the string extension method
            string sentence = "I am Gosho";
            int wordsCount = sentence.WordCount();
            Console.WriteLine($"The sentence {sentence} has {wordsCount} words");

            var numbers = new int[] {1,2,3,4,5};
            
            // using the odd number filter function
            var oddNUmbers = Utils.GetOddNumbers(numbers).ToList<int>();
            Console.WriteLine($"All odd numbers: {string.Join(',', oddNUmbers)}");

            var oddNUmbersDescending = Utils.GetOddNumbers(numbers, true).ToList<int>();
            Console.WriteLine($"All odd numbers in desc order: {string.Join(',', oddNUmbersDescending)}");

            // using the custom filter function
            Func<int,bool> greaterThan2Filter = (x) => x > 2;
            var numbersGreaterThanTwo = Utils.GetNumbersByCriteria(numbers, greaterThan2Filter);
            Console.WriteLine($"All numbers > 2: {string.Join(',', numbersGreaterThanTwo)}");
        }
    }
}
