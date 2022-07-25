namespace TotalIncreasingOrDecreasingNumbersUpToPowerOf10
{
	public class Kata
	{
		public static BigInteger TotalIncDec(int x)
		{
			BigInteger n = new(1);

			for (int i = 1; i < 10; i++)
				n = n * (x + i) / i;

			return n * (20 + x) / 10 - 10 * x - 1;
		}
	}
}