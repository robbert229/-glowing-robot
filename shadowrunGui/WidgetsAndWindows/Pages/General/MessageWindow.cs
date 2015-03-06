using System;

namespace ShadowrunGui
{
	public partial class MessageWindow : Gtk.Window
	{
		public MessageWindow (string header,string message) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Title = header;
			this.Modal = true;
			this.Message_Label.Text = message;
		}

		protected void Ok_Click (object sender, EventArgs e)
		{
			Destroy();
		}

	}
}

