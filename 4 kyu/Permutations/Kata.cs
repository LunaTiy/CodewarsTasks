using System;
using System.Collections.Generic;

namespace Permutations
{
	public class Kata
	{
		public static List<string> SinglePermutations(string s)
		{
			if (s == null || s.Length == 0)
				return null;

			List<string> result = new List<string>();
			Permute(result, s.ToCharArray(), 0, s.Length - 1);
			
			return result;
		}

        private static void Permute(List<string> result, char[] str, int minIndex, int maxIndex)
		{
			if(minIndex == maxIndex && !result.Contains(new string(str)))
			{
				result.Add(new string(str));
				return;
			}

			for(int i = minIndex; i <= maxIndex; i++)
			{
				Swap(ref str[minIndex], ref str[i]);
				Permute(result, str, minIndex + 1, maxIndex);
				Swap(ref str[minIndex], ref str[i]);
			}
		}

		private static void Swap(ref char character1, ref char character2)
		{
			if (character1 == character2) return;

			char temp = character1;
			character1 = character2;
			character2 = temp;
		}
    }
}
