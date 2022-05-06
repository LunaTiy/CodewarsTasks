using System;
using System.Collections.Generic;

namespace GreedIsGood
{
	public class Kata
	{
		public static int Score(int[] dice)
		{
			InitializeAwards(out Dictionary<int, int> scoreForThreeNumbers, out Dictionary<int, int> scoreForOneNumber);
			Dictionary<int, int> amountPoints = new Dictionary<int, int>();

			foreach(int point in dice)
			{
				if (amountPoints.ContainsKey(point)) amountPoints[point]++;
				else amountPoints.Add(point, 1);
			}

			int score = 0;

			foreach(var point in amountPoints)
			{
				int wholePart = Math.DivRem(point.Value, 3, out int remainder);

				score += wholePart * scoreForThreeNumbers[point.Key];

				if (scoreForOneNumber.ContainsKey(point.Key))
					score += remainder * scoreForOneNumber[point.Key];
			}

			return score;
		}

		private static void InitializeAwards(out Dictionary<int, int> scoreForThreeNumbers, out Dictionary<int, int> scoreForOneNumber)
		{
			scoreForThreeNumbers = new Dictionary<int, int>();
			scoreForThreeNumbers.Add(1, 1000);
			scoreForThreeNumbers.Add(2, 200);
			scoreForThreeNumbers.Add(3, 300);
			scoreForThreeNumbers.Add(4, 400);
			scoreForThreeNumbers.Add(5, 500);
			scoreForThreeNumbers.Add(6, 600);

			scoreForOneNumber = new Dictionary<int, int>();
			scoreForOneNumber.Add(1, 100);
			scoreForOneNumber.Add(5, 50);
		}
	}
}
