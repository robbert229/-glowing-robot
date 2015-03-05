using System;
using Gtk;

namespace ShadowrunGui
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			var win = new ShadowrunWirelessTools();
			win.Show ();
			Application.Run ();
		}
	}
}
