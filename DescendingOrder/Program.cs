using System;
using System.Collections.Generic;

/*
    Your task is to make a function that can take any non-negative integer as an argument and
    return it with its digits in descending order.
    Essentially, rearrange the digits to create the highest possible number.

    Examples:
    Input: 42145 Output: 54421
    Input: 145263 Output: 654321
    Input: 123456789 Output: 987654321
 */

namespace DescendingOrder
{
    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            if (num <= 0)
                return 0;

            List<int> numbers = Divide(num);
            numbers.Sort();

            return AssemblyToNumber(numbers);
        }

        private static List<int> Divide(int num)
        {
            List<int> numbers = new List<int>();

            while (num != 0)
            {
                numbers.Add(num % 10);
                num /= 10;
            }

            return numbers;
        }

        private static int AssemblyToNumber(List<int> numbers)
		{
            int number = 0;

            for(int i = 0; i < numbers.Count; i++)
			{
                number +=  numbers[i] * (int) Math.Pow(10, i);
            }

            return number;
		}
    }
    class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
