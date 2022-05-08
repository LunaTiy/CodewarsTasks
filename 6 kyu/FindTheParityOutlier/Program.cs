using System;

/*
	You are given an array (which will have a length of at least 3, but could be very large) containing integers.
	The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
	Write a method that takes the array as an argument and returns this "outlier" N.

	Examples
	[2, 4, 0, 100, 4, 11, 2602, 36]
	Should return: 11 (the only odd number)

	[160, 3, 1719, 19, 11, 13, -21]
	Should return: 160 (the only even number)
 */

namespace FindTheParityOutlier
{
	public class Kata
	{
		public static int Find(int[] integers)
		{
			int validationResult = ArrayValidation(integers);

			if (validationResult == -1) return -1;

			return FindNumber(integers, validationResult);
		}

		private static int ArrayValidation(int[] array)
		{
			int countEvenNumber = 0;
			int countOddNumber = 0;

			foreach (int num in array)
			{
				if (num % 2 == 0) countEvenNumber++;
				else countOddNumber++;

				if (countEvenNumber > 1 && countOddNumber > 1) return -1;
			}

			if (countEvenNumber == 1) return 0;

			return 1;
		}

		private static int FindNumber(int[] array, int remainder)
		{
			foreach(int num in array)
				if (Math.Abs(num % 2) == remainder) return num;

			return -1;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

		}
	}
}
