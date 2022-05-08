using System;
using System.Linq;

namespace MiddlePermutation
{
	public class Kata
	{
		public string MiddlePermutation(string s)
		{
			s = string.Concat(s.OrderBy(x => x).ToArray());

			if (s.Length <= 2) return s;

			return Permutation(s);
		}

		private string Permutation(string str)
		{
			if (str.Length % 2 == 0)
			{
				int middleIndex = str.Length / 2 - 1;
				return str[middleIndex] + new string(str.Remove(middleIndex, 1).Reverse().ToArray());
			}
			else
			{
				int middleIndex = str.Length / 2;
				return str[middleIndex] + Permutation(str.Remove(middleIndex, 1));
			}
		}
	}
}
