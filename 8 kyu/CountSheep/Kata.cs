namespace CountSheep
{
	public class Kata
	{
		public static string CountSheep(int n)
		{
			if (n <= 0)
				return "";

			return CountSheep(n - 1) + $"{n} sheep...";
		}
	}
}