using System;

namespace ShadowrunGui
{
	public partial class InputWindow : Gtk.Window
	{
		public string input;
		public InputWindow (string header,string message) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Title = header;
			this.Modal = true;
			this.Message_Label.Text = message;
		}

		protected void Submit_Click (object sender, EventArgs e)
		{
			this.input = Input_Textbox.Text;
			Destroy();
		}

	}
}

