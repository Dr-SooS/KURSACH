using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH
{
	class Helper
	{
		public static void ValidateLetter(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!char.IsLetter(ch) && ch != 8)
				e.Handled = true;
		}

		internal static void ValidateDigit(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!char.IsDigit(ch) && ch != 8)
				e.Handled = true;
		}
	}
}
