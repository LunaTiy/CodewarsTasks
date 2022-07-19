namespace IPValidation
{
	public class Kata
	{
		public static bool IsValidIP(string ipAddres)
		{
			if (ipAddres.Contains(' '))
				return false;

			string[] stringOctets = ipAddres.Split('.');

			if(stringOctets.Length != 4)
				return false;

			foreach(string str in stringOctets)
				if (str.Length > 1 && str.IndexOf('0') == 0)
					return false;

			int[] octets = new int[stringOctets.Length];

			for (int i = 0; i < stringOctets.Length; i++)			
				if(!int.TryParse(stringOctets[i], out octets[i]))
					return false;
			

			foreach(int octet in octets)			
				if (octet < 0 || octet > 255)
					return false;
			

			return true;
		}
	}
}