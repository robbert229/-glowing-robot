
// This file has been generated by the GUI designer. Do not modify.
namespace ShadowrunGui
{
	public partial class CharacterPageWidget
	{
		private global::Gtk.VBox Character_Hbox;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView Characters_TreeView;
		private global::Gtk.HSeparator hseparator3;
		private global::Gtk.HBox CharacterImportButton_HBox;
		private global::Gtk.Button DeleteCharacter_Button;
		private global::Gtk.Button CharacterDuplicate_Button;
		private global::Gtk.Button ModifyCharacter_Button;
		private global::Gtk.Button NewCharacter_Button;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ShadowrunGui.CharacterPageWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "ShadowrunGui.CharacterPageWidget";
			// Container child ShadowrunGui.CharacterPageWidget.Gtk.Container+ContainerChild
			this.Character_Hbox = new global::Gtk.VBox ();
			this.Character_Hbox.Name = "Character_Hbox";
			this.Character_Hbox.Spacing = 6;
			// Container child Character_Hbox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.Characters_TreeView = new global::Gtk.TreeView ();
			this.Characters_TreeView.CanFocus = true;
			this.Characters_TreeView.Name = "Characters_TreeView";
			this.GtkScrolledWindow.Add (this.Characters_TreeView);
			this.Character_Hbox.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.Character_Hbox [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child Character_Hbox.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.Character_Hbox.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.Character_Hbox [this.hseparator3]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child Character_Hbox.Gtk.Box+BoxChild
			this.CharacterImportButton_HBox = new global::Gtk.HBox ();
			this.CharacterImportButton_HBox.Name = "CharacterImportButton_HBox";
			this.CharacterImportButton_HBox.Spacing = 6;
			// Container child CharacterImportButton_HBox.Gtk.Box+BoxChild
			this.DeleteCharacter_Button = new global::Gtk.Button ();
			this.DeleteCharacter_Button.CanFocus = true;
			this.DeleteCharacter_Button.Name = "DeleteCharacter_Button";
			this.DeleteCharacter_Button.UseUnderline = true;
			this.DeleteCharacter_Button.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.CharacterImportButton_HBox.Add (this.DeleteCharacter_Button);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.CharacterImportButton_HBox [this.DeleteCharacter_Button]));
			w4.Position = 0;
			// Container child CharacterImportButton_HBox.Gtk.Box+BoxChild
			this.CharacterDuplicate_Button = new global::Gtk.Button ();
			this.CharacterDuplicate_Button.CanFocus = true;
			this.CharacterDuplicate_Button.Name = "CharacterDuplicate_Button";
			this.CharacterDuplicate_Button.UseUnderline = true;
			this.CharacterDuplicate_Button.Label = global::Mono.Unix.Catalog.GetString ("Duplicate");
			this.CharacterImportButton_HBox.Add (this.CharacterDuplicate_Button);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.CharacterImportButton_HBox [this.CharacterDuplicate_Button]));
			w5.Position = 1;
			// Container child CharacterImportButton_HBox.Gtk.Box+BoxChild
			this.ModifyCharacter_Button = new global::Gtk.Button ();
			this.ModifyCharacter_Button.CanFocus = true;
			this.ModifyCharacter_Button.Name = "ModifyCharacter_Button";
			this.ModifyCharacter_Button.UseUnderline = true;
			this.ModifyCharacter_Button.Label = global::Mono.Unix.Catalog.GetString ("Modify");
			this.CharacterImportButton_HBox.Add (this.ModifyCharacter_Button);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.CharacterImportButton_HBox [this.ModifyCharacter_Button]));
			w6.Position = 2;
			// Container child CharacterImportButton_HBox.Gtk.Box+BoxChild
			this.NewCharacter_Button = new global::Gtk.Button ();
			this.NewCharacter_Button.CanFocus = true;
			this.NewCharacter_Button.Name = "NewCharacter_Button";
			this.NewCharacter_Button.UseUnderline = true;
			this.NewCharacter_Button.Label = global::Mono.Unix.Catalog.GetString ("New");
			this.CharacterImportButton_HBox.Add (this.NewCharacter_Button);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.CharacterImportButton_HBox [this.NewCharacter_Button]));
			w7.Position = 3;
			this.Character_Hbox.Add (this.CharacterImportButton_HBox);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.Character_Hbox [this.CharacterImportButton_HBox]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.Add (this.Character_Hbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.DeleteCharacter_Button.Clicked += new global::System.EventHandler (this.DeleteCharacter_Click);
			this.CharacterDuplicate_Button.Clicked += new global::System.EventHandler (this.CharacterDuplicate_Click);
			this.ModifyCharacter_Button.Clicked += new global::System.EventHandler (this.ModifyCharacter_Click);
			this.NewCharacter_Button.Clicked += new global::System.EventHandler (this.NewCharacter_Click);
		}
	}
}
