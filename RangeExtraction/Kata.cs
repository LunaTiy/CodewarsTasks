using System;

namespace RangeExtraction
{
	public class Kata
	{
		public static string Extract(int[] args)
		{
			string stringNumbers = args[0].ToString();
			int startIndex = 0;

			for(int i = 1; i < args.Length; i++)
			{
				if(args[i - 1] != args[i] - 1)
				{
					if (i - startIndex < 3)
					{
						for (int j = startIndex + 1; j < i + 1; j++)
							stringNumbers += "," + args[j].ToString();
					}
					else
					{
						stringNumbers += "-" + args[i - 1].ToString();
						stringNumbers += "," + args[i].ToString();
					}

					startIndex = i;
				}
				else if(i == args.Length - 1)
				{
					if (i - startIndex < 2)
						stringNumbers += "," + args[i].ToString();
					else
						stringNumbers += "-" + args[i].ToString();
				}
			}

			return stringNumbers;
		}
	}
}
