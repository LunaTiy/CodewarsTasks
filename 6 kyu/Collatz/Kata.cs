namespace Collatz
{
	public class Kata
	{
		public static string Collatz(int n)
		{
			string result = n.ToString();

			while(n != 1)
			{
				if (n % 2 == 0) n /= 2;
				else n = n * 3 + 1;

				result += $"->{n}";
			}

			return result;
		}
	}
}