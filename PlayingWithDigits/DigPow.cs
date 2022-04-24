using System;
using System.Collections.Generic;

namespace PlayingWithDigits
{
	public class DigPow
	{
		public static long DigitPow(int n, int p)
		{
			if (n < 1 || p < 1)
				return -1;

			List<int> digits = SplitNumberIntoDigits(n);
			long sum = SumOfDigitsInPow(digits, p);

			return SearchMultiplier(n, sum);
		}

		public static List<int> SplitNumberIntoDigits(int number)
		{
			List<int> digits = new List<int>();

			while (number != 0)
			{
				digits.Add(number % 10);
				number /= 10;
			}

			digits.Reverse();

			return digits;
		}

		public static long SumOfDigitsInPow(List<int> digits, int p)
		{
			long sum = 0;

			foreach(int digit in digits)
			{
				sum += (long) Math.Pow(digit, p);
				p++;
			}

			return sum;
		}

		public static long SearchMultiplier(int number, long sum)
		{
			int multiplier = 1;

			while (true)
			{
				long resultMultiply = number * multiplier;

				if (resultMultiply == sum) return multiplier;
				else if (resultMultiply > sum) return -1;

				multiplier++;
			}
		}
	}
}
