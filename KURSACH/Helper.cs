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

		internal static void ValidateMark(object sender, KeyPressEventArgs e)
		{
			var s = ((DataGridViewTextBoxEditingControl) sender).Text;
			char ch = e.KeyChar;

			try
			{
				if (!char.IsDigit(ch) && ch != 8)
					e.Handled = true;
				if (ch != 8)
				{
					int a = int.Parse(s + ch.ToString());
					if (a > 10)
						e.Handled = true;
				}
			}
			catch
			{
				e.Handled = true;
			}
		}

		internal static void ValidateInt(object sender, KeyPressEventArgs e)
		{
			var s = ((DataGridViewTextBoxEditingControl)sender).Text;
			try
			{
				int.Parse(s + e.KeyChar.ToString());
			}
			catch
			{
				e.Handled = true;
			}
		}
	}
}
