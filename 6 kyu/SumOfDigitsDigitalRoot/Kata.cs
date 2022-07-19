namespace SumOfDigitsDigitalRoot
{
	public class Kata
	{
		public static int DigitalRoot(long n)
		{
			int countOfDigits = (int)Math.Log10(n) + 1;

			if (countOfDigits == 1)
				return (int)n;

			int result = 0;

			while(countOfDigits > 1)
			{
				result = 0;

				for(int i = 0; i < countOfDigits; i++)
				{
					int digit = (int)(n % 10);
					result += digit;

					n /= 10;
				}

				n = result;
				countOfDigits = (int)Math.Log10(n) + 1;
			}

			return result;
		}
	}
}