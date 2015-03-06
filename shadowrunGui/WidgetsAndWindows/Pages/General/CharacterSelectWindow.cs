using System;
using ShadowrunLogic;
using System.Collections.Generic;

namespace ShadowrunGui
{
	public partial class CharacterSelectWindow : Gtk.Window
	{
		private List<Character> characters;
		public Character character
			;
		public CharacterSelectWindow (List<Character> characters) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.Modal = true;
			this.characters = characters;

			RenderTree();

			this.Select_Button.Clicked += Select_Clicked;
		}

		private void RenderTree ()
		{
			Gtk.ListStore list = new Gtk.ListStore(typeof(string),typeof(string));

			Characters_TreeView.AppendColumn("Index", new Gtk.CellRendererText(),"text",0);
			Characters_TreeView.AppendColumn("Name", new Gtk.CellRendererText(),"text",1);

			for(int i=0;i< characters.Count;i++)
				list.AppendValues(i.ToString(),characters[i].attributes.Name());

			Characters_TreeView.Model = list;
		}

		private Character GetSelectedCharacter(){
			Gtk.TreeIter selected;
			Characters_TreeView.Selection.GetSelected (out selected);
			string index = Characters_TreeView.Model.GetValue (selected, 0).ToString();
			return characters[Int32.Parse(index)];
		}

		private void Select_Clicked (object sender, EventArgs e)
		{
			try {
				var c = GetSelectedCharacter();
				this.character = c;
				this.Destroy();
			} catch (Exception ex) {
				new MessageWindow("Error", "Error: " + ex.Message);
			}
		}
	}
}

