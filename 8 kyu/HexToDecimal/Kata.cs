namespace HexToDecimal
{
	public class Kata
	{
		public static int HexToDec(string hexString)
		{
			int dec = 0;

			for (int i = hexString.Length - 1, power = 0; i >= 0; i--, power++)
			{
				if (char.IsDigit(hexString[i]))
				{
					dec += int.Parse(hexString[i].ToString()) * (int)Math.Pow(16, power);
				}
				else if (hexString[i] == '-')
				{
					dec *= -1;
				}
				else
				{
					dec += char.IsLower(hexString[i])
						? (hexString[i] - 'a' + 10) * (int)Math.Pow(16, power)
						: (hexString[i] - 'A' + 10) * (int)Math.Pow(16, power);
				}
			}

			return dec;
		}
	}
}