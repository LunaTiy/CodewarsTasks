using System;

namespace DontGiveMeFive
{
	public class Kata
	{
        public static int DontGiveMeFive(int start, int end)
        {
            int count = 0;

            for (int i = start; i <= end; i++)
                if (!i.ToString().Contains('5')) count++;

            return count;
        }
    }
}
