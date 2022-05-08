using System;

namespace Rot13
{
	public class Kata
	{
		public static string Rot13Encrypt(string message)
		{
			if (message == "" || message == null) return null;

			string encryptMessage = "";

			for(int i = 0; i < message.Length; i++)
			{
				if(Char.IsLetter(message, i))
					encryptMessage += GetEncryptedChar(message[i]);
				else
					encryptMessage += message[i];
			}

			return encryptMessage;
		}

		private static char GetEncryptedChar(char ch)
		{
			bool isLower = Char.IsLower(ch);

			char character = Convert.ToChar(ch + 13);

			if ((character >= 'a' && character <= 'z' && isLower) || (character >= 'A' && character <= 'Z' && !isLower))
				return character;
			else if (character > 'z')
				return Convert.ToChar(character % 'z' + 'a' - 1);
			else
				return Convert.ToChar(character % 'Z' + 'A' - 1);
		}
	}
}
