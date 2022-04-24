using System;

namespace BitCounting
{
	public class Kata
	{
		public static int CountBits(int n)
		{
			if (n < 0) return -1;

			string binaryString = Convert.ToString(n, 2);
			int countOne = 0;

			foreach (char digit in binaryString)
				if (digit == '1')
					countOne++;

			return countOne;
		}
	}
}
