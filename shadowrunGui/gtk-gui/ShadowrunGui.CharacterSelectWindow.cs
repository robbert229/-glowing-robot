
// This file has been generated by the GUI designer. Do not modify.
namespace ShadowrunGui
{
	public partial class CharacterSelectWindow
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView Characters_TreeView;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Button Select_Button;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ShadowrunGui.CharacterSelectWindow
			this.Name = "ShadowrunGui.CharacterSelectWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("CharacterSelectWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ShadowrunGui.CharacterSelectWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.Characters_TreeView = new global::Gtk.TreeView ();
			this.Characters_TreeView.CanFocus = true;
			this.Characters_TreeView.Name = "Characters_TreeView";
			this.GtkScrolledWindow.Add (this.Characters_TreeView);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.Select_Button = new global::Gtk.Button ();
			this.Select_Button.CanFocus = true;
			this.Select_Button.Name = "Select_Button";
			this.Select_Button.UseUnderline = true;
			this.Select_Button.Label = global::Mono.Unix.Catalog.GetString ("Select");
			this.vbox1.Add (this.Select_Button);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.Select_Button]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}