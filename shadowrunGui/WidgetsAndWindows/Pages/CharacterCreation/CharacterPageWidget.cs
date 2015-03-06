using System;
using ShadowrunLogic;
using System.Collections.Generic;
using Gtk;

namespace ShadowrunGui
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class CharacterPageWidget : Gtk.Bin
	{
		private List<Character> characters;

		public CharacterPageWidget ()
		{
			this.Build ();
		}

		public void SetCharacters (List<Character> characters)
		{
			this.characters = characters;
			RenderTree();
		}


		protected void DeleteCharacter_Click (object sender, EventArgs e)
		{
			if (characters.Count > 0) {
				try {
					var s = GetSelectedCharacter();
					characters.Remove(s);
					RenderTree();
				} catch (Exception ex){
					new MessageWindow("Error","Error: " + ex.Message);
				}
			} else {
				new MessageWindow("Error","Not a valid character");
			}
		}		

		protected void ModifyCharacter_Click (object sender, EventArgs e)
		{
			if (characters.Count > 0) {
				try {
					var cur = GetSelectedCharacter ();
					var ciw = new CharacterWindow (cur);
					ciw.Modal = true;
					ciw.Destroyed += delegate {
						if(ciw.character != null)
						{
							int i = characters.IndexOf (cur);
							characters.RemoveAt (i);
							characters.Insert (i, ciw.character);
							RenderTree ();
						}
					};
					return;
				} catch (Exception ex){
					new MessageWindow("Error","Error:" + ex.Message);
				}
			} else {
				new MessageWindow("Error","Please select a valid character");
			}


		}		

		protected void NewCharacter_Click (object sender, EventArgs e)
		{
			var ciw = new CharacterWindow();
			ciw.Modal = true;

			ciw.Destroyed += delegate {
				if(ciw.character != null){
					characters.Add (ciw.character);
					RenderTree();
				}
			};

		}

		public void RenderTree ()
		{
			Gtk.ListStore list = new Gtk.ListStore (typeof(string), typeof(string), typeof(string), typeof(string));

			if (Characters_TreeView.Columns.Length != 4) {
				Characters_TreeView.AppendColumn ("Id", new Gtk.CellRendererText (), "text", 0);
				Characters_TreeView.AppendColumn ("Character Name", new Gtk.CellRendererText (), "text", 1);
				Characters_TreeView.AppendColumn ("Ranged Weapon", new Gtk.CellRendererText (), "text", 2);
				Characters_TreeView.AppendColumn ("Melee Weapon", new Gtk.CellRendererText (), "text", 3);
			}

			for (int i=0; i<characters.Count; i++) {
				var character = characters[i];
				list.AppendValues (i.ToString(),character.attributes.Name (), character.rangedWeapon.Name (), character.meleeWeapon.Name ());
			
			}
 
        	Characters_TreeView.Model = list;
		}

		protected Character GetSelectedCharacter ()
		{
			Gtk.TreeIter selected;
			Characters_TreeView.Selection.GetSelected (out selected);
			string index = Characters_TreeView.Model.GetValue (selected, 0).ToString();
			return characters[Int32.Parse(index)];
		}

		protected void CharacterDuplicate_Click (object sender, EventArgs e)
		{
			if (characters.Count > 0) {
				try {
					var selected = GetSelectedCharacter();
					var other = new Character(
						selected.attributes.Clone(),
						selected.rangedWeapon.Clone(),
						selected.meleeWeapon.Clone()
					);

					characters.Add(other);
					RenderTree();

				} catch (Exception ex){
					new MessageWindow("Error","Error: " + ex.Message);
				}
			} else {
				new MessageWindow("Error","No characters to duplicate");
			}
		}
	}
}

