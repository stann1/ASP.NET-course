using System;
using System.Collections.Generic;
using System.Linq;

public static class Utils 
{
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers, bool sortDescending = false)
    {
        if(numbers == null || numbers.Count() == 0)
        {
            throw new ArgumentNullException("Cannot process null or empty collection");
        }

        var result = new List<int>();
        foreach (var number in numbers)
        {
            if(number % 2 == 1)
            {
                result.Add(number);
            }
        }

        if (sortDescending)
        {
            result.Sort((x,y) => y - x);
        }
        return result;
    }

    public static IEnumerable<int> GetNumbersByCriteria(IEnumerable<int> numbers, Func<int,bool> filterDelegate)
    {
        var result = new List<int>();
        foreach (var number in numbers)
        {
            if(filterDelegate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }

}