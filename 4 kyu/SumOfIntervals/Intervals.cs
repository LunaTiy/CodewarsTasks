using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfIntervals
{
	public class Intervals
	{
		public static int SumIntervals((int, int)[] intervals)
		{
			if (intervals.Length == 0)
				return 0;

			if (intervals.Length == 1)
				return intervals[0].Item2 - intervals[0].Item1;

			intervals = intervals.OrderBy(interval => interval.Item1).ToArray();

			List<(int, int)> stackedIntervals = new List<(int, int)>();
			stackedIntervals.Add(intervals[0]);


			for(int i = 1; i < intervals.Length; i++)
			{
				bool isStacked = false;

				for(int j = 0; j < stackedIntervals.Count; j++)
				{
					if(intervals[i].Item1 <= stackedIntervals[j].Item2)
					{
						if (intervals[i].Item2 > stackedIntervals[j].Item2)
						{
							int startInterval = stackedIntervals[j].Item1;
							int endInterval = intervals[i].Item2;

							stackedIntervals.RemoveAt(j);
							stackedIntervals.Add((startInterval, endInterval));
						}

						isStacked = true;						
						break;
					}
				}

				if (!isStacked)
					stackedIntervals.Add(intervals[i]);
			}

			int sum = 0;

			foreach(var interval in stackedIntervals)
				sum += interval.Item2 - interval.Item1;

			return sum;
		}
	}
}
