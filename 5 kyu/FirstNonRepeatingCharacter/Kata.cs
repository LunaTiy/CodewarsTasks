using System;
using System.Collections.Generic;

namespace FirstNonRepeatingCharacter
{
	public class Kata
	{
		public static string FirstNonRepeatingLetter(string s)
		{
			if (s == null || s == "")
				return "";

			return GetFirstNonRepeatingLetter(s);
		}

		public static string GetFirstNonRepeatingLetter(string s)
		{
			for(int i = 0; i < s.Length; i++)
			{
				bool isRepeating = false;

				for(int j = 0; j < s.Length; j++)
				{
					if (Char.ToLower(s[i]) == Char.ToLower(s[j]) && i != j)
					{
						isRepeating = true;
						break;
					}
				}

				if (!isRepeating) return s[i].ToString();
			}

			return "";
		}
	}
}
