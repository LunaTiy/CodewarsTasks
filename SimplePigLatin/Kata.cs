using System;
using System.Text.RegularExpressions;

namespace SimplePigLatin
{
	public class Kata
	{
		public static string PigIt(string str)
		{
			char[] separators = { ' ', ',', '.', '!' };

			foreach (string word in str.Split(separators))
			{
				if (word != "")
				{
					string newWord = word.Insert(word.Length, word[0].ToString() + "ay").Remove(0, 1);

					str = Regex.Replace(str, $@"\b{word}\b", newWord);
				}
			}

			return str;
		}
	}
}
