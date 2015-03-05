using System;

namespace ShadowrunGui
{
	public partial class MessageWindow : Gtk.Window
	{
		public MessageWindow (Gtk.Window parent, string header,string message) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Title = header;
			Message_Label.Text = message;
			this.Modal = true;
			this.TransientFor = parent;
		}
		protected void Ok_Click (object sender, EventArgs e)
		{
			Destroy();
		}

	}
}

