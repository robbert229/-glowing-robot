
// This file has been generated by the GUI designer. Do not modify.
namespace ShadowrunGui
{
	public partial class ImportWindow
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView Item_TreeView;
		private global::Gtk.Button TreeViewSelect_Button;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ShadowrunGui.ImportWindow
			this.Name = "ShadowrunGui.ImportWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("AbstractImportWindow2");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ShadowrunGui.ImportWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.Item_TreeView = new global::Gtk.TreeView ();
			this.Item_TreeView.CanFocus = true;
			this.Item_TreeView.Name = "Item_TreeView";
			this.GtkScrolledWindow.Add (this.Item_TreeView);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.TreeViewSelect_Button = new global::Gtk.Button ();
			this.TreeViewSelect_Button.CanFocus = true;
			this.TreeViewSelect_Button.Name = "TreeViewSelect_Button";
			this.TreeViewSelect_Button.UseUnderline = true;
			this.TreeViewSelect_Button.Label = global::Mono.Unix.Catalog.GetString ("Select");
			this.vbox1.Add (this.TreeViewSelect_Button);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.TreeViewSelect_Button]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.TreeViewSelect_Button.Clicked += new global::System.EventHandler (this.TreeViewSelect_Click);
		}
	}
}