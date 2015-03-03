using System;

namespace ShadowrunGui
{
	public partial class AbstractImportWindow : Gtk.Window
	{
		public AbstractImportWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

