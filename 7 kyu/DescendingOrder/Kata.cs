using System;
using System.Collections.Generic;

namespace DescendingOrder
{
	public class Kata
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

            for (int i = 0; i < numbers.Count; i++)
            {
                number += numbers[i] * (int)Math.Pow(10, i);
            }

            return number;
        }
    }
}
