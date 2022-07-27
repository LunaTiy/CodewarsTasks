namespace SquareIntoSquaresProtectTrees
{
	public class Kata
	{
		public static string Decompose(long n)
		{
			List<long> numbers = new();

			if (!TryRecursionDecomposition(n, (long)Math.Pow(n, 2), ref numbers))
				return null;

			string result = string.Empty;

			for (int i = numbers.Count - 1; i >= 0; i--)
				result += i == 0 ? numbers[i].ToString() : numbers[i].ToString() + " ";
			

			return result;
		}

		private static bool TryRecursionDecomposition(long number, long squareNumber, ref List<long> numbers, long sumNumbers = 0)
		{
			if (number == 0)
				return false;

			for (long i = number - 1; i > 0; i--)
			{
				long squareCurrentNumber = (long)Math.Pow(i, 2);

				if (sumNumbers + squareCurrentNumber <= squareNumber)
				{
					numbers.Add(i);
					sumNumbers += squareCurrentNumber;

					if (sumNumbers == squareNumber)
						return true;

					if(TryRecursionDecomposition(i, squareNumber, ref numbers, sumNumbers))
						return true;

					numbers.Remove(i);
					sumNumbers -= squareCurrentNumber;
				}
			}

			return false;
		}
	}
}