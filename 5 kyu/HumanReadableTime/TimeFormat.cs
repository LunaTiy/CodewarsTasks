using System;

namespace HumanReadableTime
{
	public class TimeFormat
	{
		public static string GetReadableTime(int seconds)
		{
			if (seconds < 0 || seconds > 359999) return null;

			int minutes = DivisionCheck(seconds, out int remainderSeconds);
			int hours = DivisionCheck(minutes, out int remainderMinutes);

			return $"{TranslateToString(hours)}:{TranslateToString(remainderMinutes)}:{TranslateToString(remainderSeconds)}";
		}

		public static int DivisionCheck(int value, out int remainder)
		{
			return Math.DivRem(value, 60, out remainder);
		}

		public static string TranslateToString(int value)
		{
			if (value < 10)
				return $"0{value}";

			return $"{value}";
		}
	}
}
