using System;
using System.Collections.Generic;
using ShadowrunLogic;
using Gtk;

using ShadowrunCoreContent;

namespace ShadowrunGui
{
	public partial class ShadowrunWirelessTools : Gtk.Window
	{
		List<Character> characters; 
		public ShadowrunWirelessTools () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.characters = new List<Character>();

			this.characters.Add (new Character(new GangerAttributes(),new FichettiSecurity600(),new Katana()));

			RenderTree();
		}

		#region character-import-tab
		protected void DeleteCharacter_Click (object sender, EventArgs e)
		{
			if (characters.Count > 0) {
				try {
					var s = GetSelectedCharacter();
					characters.Remove(s);
					RenderTree();
				} catch (Exception ex){
					new MessageWindow(this,"Error","Error: " + ex.Message);
				}
			} else {
				new MessageWindow(this,"Error","Not a valid character");
			}
		}		

		protected void ModifyCharacter_Click (object sender, EventArgs e)
		{
			if (characters.Count > 0) {
				try {
					var cur = GetSelectedCharacter ();
					var ciw = new CharacterImportWindow (cur);
					ciw.Modal = true;
					ciw.TransientFor = this;
					ciw.Destroyed += delegate {
						int i = characters.IndexOf (cur);
						characters.RemoveAt (i);
						characters.Insert (i, ciw.character);
						RenderTree ();
					};
					return;
				} catch (Exception ex){
					new MessageWindow(this,"Error","Error:" + ex.Message);
				}
			} else {
				new MessageWindow(this,"Error","Please select a valid character");
			}


		}		

		protected void NewCharacter_Click (object sender, EventArgs e)
		{
			var ciw = new CharacterImportWindow();
			ciw.Modal = true;
			ciw.TransientFor = this;

			ciw.Destroyed += delegate {
				characters.Add (ciw.character);
				RenderTree();
			};

		}

		protected void RenderTree ()
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

		protected void Form_Destroy (object o, Gtk.DeleteEventArgs args)
		{
			Application.Quit();
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
					new MessageWindow(this,"Error","Error: " + ex.Message);
				}
			} else {
				new MessageWindow(this,"Error","No characters to duplicate");
			}
		}
		#endregion



	}
}

