/**
\author		Shestakov Mikhail aka MIKE
\date		20.9.2012 (c)Korotkov Andrey

This file is a part of DGLE2 project and is distributed
under the terms of the GNU Lesser General Public License.
See "DGLE2.h" for more details.
*/
using System;
using Gtk;

namespace Template
{
	internal static class About
	{
		internal static string[] Authors = new string[]
		{
			"Shestakov Mikhail aka MIKE"
		};
	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			Gui.ThemeHelper.ApplyCustomTheme (args);

			Application.Init ("Template", ref args);
			TemplateWindow win = new TemplateWindow();
			win.Show();
			Application.Run ();
		}
	}
}
