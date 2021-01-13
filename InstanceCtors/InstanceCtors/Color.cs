using System;
using System.Collections.Generic;
using System.Text;

namespace InstanceCtors
{
    public class Color
    {
		private Color(int hex)
		{
			this.Hex = hex;
		}

		public int Hex
		{
			get;
		}

		public static Color FromRGB(int red, int green, int blue)
		{
			string hexString = $"{Convert.ToString(red, 16).PadLeft(2, '0')}{Convert.ToString(green, 16).PadLeft(2, '0')}{Convert.ToString(blue, 16).PadLeft(2, '0')}";
			return Color.FromHexString(hexString);
		}

		public static Color FromHexString(string hexString)
		{
			if (string.IsNullOrWhiteSpace(hexString))
			{
				return null;
			}

			if (!int.TryParse(hexString, System.Globalization.NumberStyles.HexNumber, null, out int result))
			{
				return null;
			}

			return new Color(result);
		}
	}
}
