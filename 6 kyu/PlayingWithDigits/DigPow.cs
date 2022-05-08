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

		public static long SumOfDigitsInPow(IEnumerable<int> digits, int p)
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
			if (sum % number == 0)
				return sum / number;

			return -1;
		}
	}
}
