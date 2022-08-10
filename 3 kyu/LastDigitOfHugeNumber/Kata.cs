using System.Numerics;

namespace LastDigitOfHugeNumber
{
	public class Kata
	{
		public static int LastDigit(int[] array)
		{
			if (array == null || array.Length == 0)
				return 1;

			if(array.Length == 1)
				return array[0] % 10;

			BigInteger resultPower = 1;

			for (int i = array.Length - 1; i >= 0; i--)
				resultPower = Power(array[i], resultPower < 4 ? resultPower : resultPower % 4 + 4);

			return (int)(resultPower % 10);
		}

		private static BigInteger Power(int number, BigInteger degree)
		{
			BigInteger result = 1;

			for (int i = 0; i < degree; i++)
				result *= number;

			return result;
		}
	}
}