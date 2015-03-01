using System;
using Gtk;

namespace ShadowrunGui
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			var win = new ShadowrunToolMainWindow();
			win.Show ();
			Application.Run ();
		}
	}
}
