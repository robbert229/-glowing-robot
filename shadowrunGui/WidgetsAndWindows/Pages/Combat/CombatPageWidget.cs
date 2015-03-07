using System;
using ShadowrunLogic;
using System.Collections.Generic;

namespace ShadowrunGui
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class CombatPageWidget : Gtk.Bin
	{
		private List<Character> characters;
		private int selectedIndex = -1;

		public CombatPageWidget ()
		{
			this.Build ();

			this.Reload_Button.Clicked += Reload_Clicked;

			this.NewInitiative_Button.Clicked += NewInitiative_Clicked;
			this.NextCharacter_Button.Clicked+= NextCharacter_Clicked;
			this.PreviousCharacter_Button.Clicked += PreviousCharacter_Clicked;
			this.NextPass_Button.Clicked += NextPass_Clicked;
			this.SetCharacterInitiative_Button.Clicked += SetCharacterInitiative_Clicked;

			this.DefendRanged_Button.Clicked += DefendRanged_Clicked;
			this.DefendMelee_Button.Clicked += DefendMelee_Clicked;

			this.AttackRanged_Button.Clicked += AttackRanged_Clicked;
			this.AttackMelee_Button.Clicked += AttackMelee_Clicked;


		}

		public void SetCharacters (List<Character> characters)
		{
			this.characters = characters;
			this.RenderInitiativeTree();
			this.RenderStatusTree();
		}

		#region display
		protected void RenderStatusTree ()
		{
			Gtk.ListStore list = new Gtk.ListStore (typeof(string), typeof(string));
			if (CharacterStatus_TreeView.Columns.Length != 2) {
				CharacterStatus_TreeView.AppendColumn ("Name", new Gtk.CellRendererText (), "text", 0);
				CharacterStatus_TreeView.AppendColumn ("Value", new Gtk.CellRendererText (), "text", 1);


			}

			if (selectedIndex >= 0 && selectedIndex < characters.Count) {
				var character = characters [selectedIndex];
				var attributes = character.attributes;
				list.AppendValues ("Name", attributes.Name ());
				list.AppendValues ("Stun Boxes", attributes.MaxStunDamage().ToString());
				list.AppendValues ("Stun Damage Taken", attributes.StunDamageTaken.ToString());
				list.AppendValues ("Physical Boxes" , attributes.MaxPhysixalDamage().ToString());
				list.AppendValues ("Physical Damage Taken", attributes.PhysicalDamageTaken.ToString());
				list.AppendValues ("Injury Dice Pool Modifier", attributes.GetDamageModifier().ToString());
			}

			CharacterStatus_TreeView.Model = list;
		}

		public void RenderInitiativeTree ()
		{
			Gtk.ListStore list = new Gtk.ListStore (typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

			if (Initiative_TreeView.Columns.Length != 6) {
				Initiative_TreeView.AppendColumn ("IsTurn", new Gtk.CellRendererText(), "text", 0);
				Initiative_TreeView.AppendColumn ("AbleToAct", new Gtk.CellRendererText(), "text", 1);
				Initiative_TreeView.AppendColumn ("Initiative", new Gtk.CellRendererText(), "text", 2);
				Initiative_TreeView.AppendColumn ("Character Name", new Gtk.CellRendererText (), "text", 3);
				Initiative_TreeView.AppendColumn ("Ranged Weapon", new Gtk.CellRendererText (), "text", 4);
				Initiative_TreeView.AppendColumn ("Melee Weapon", new Gtk.CellRendererText (), "text", 5);
			}

			characters.Sort (new InitiativeComparer());

			for (int i = 0; i < characters.Count; i++) {
				var character = characters[i];
				list.AppendValues (
					(i == selectedIndex ? "*" : " "),
					(character.initiative > 0 ? "True" : "False"),
					character.initiative.ToString(),
					character.attributes.Name (), 
                    character.rangedWeapon.Name (), 
					character.meleeWeapon.Name (),
					i.ToString()
				);
			
			}
 
        	Initiative_TreeView.Model = list;
		}

		protected void Log (string message)
		{
			Log_Textview.Buffer.InsertAtCursor(message + "\n");
		}

		#endregion

		#region logic
		protected Character GetSelectedTreeCharacter ()
		{
			Gtk.TreeIter selected;
			Initiative_TreeView.Selection.GetSelected (out selected);
			string index = Initiative_TreeView.Model.GetValue (selected, 0).ToString();
			return characters[Int32.Parse(index)];
		}

		protected Character GetSelectedInitiativeCharacter ()
		{
			return characters[selectedIndex];
		}
		#endregion

		#region events
		protected void Reload_Clicked (object sender, EventArgs e)
		{
			RenderStatusTree();
			RenderInitiativeTree();
		}

		protected void SetCharacterInitiative_Clicked (object sender, EventArgs e)
		{
			try {
				var iw = new InputWindow("Set Character Initiative","Enter the rolled initiative");
				iw.Destroyed += delegate {
					int initiative = Int32.Parse(iw.input);

					if(initiative <= 0)
						throw new ArgumentException();

					characters[selectedIndex].initiative = initiative;

					RenderInitiativeTree();
					RenderStatusTree();
				};


			} catch (Exception ex) {
				new MessageWindow("Error","Error: " + ex.Message);
			}
		}

		protected void NewInitiative_Clicked (object sender, EventArgs e)
		{
			Log ("Rolling Initiatives");
			foreach (var character in characters) {
				character.initiative = Initiative.Roll (character.attributes);
				Log (character.attributes.Name() + " Rolled " + character.initiative.ToString());
			}
			selectedIndex = 0;
			RenderInitiativeTree();
			RenderStatusTree();
		}

		protected void NextCharacter_Clicked (object sender, EventArgs e)
		{
			NextCharacter();
		}

		private void NextPass(){
			selectedIndex = 0;
			foreach (var character in characters) {
				character.initiative -= 10;
				if(character.initiative < 0)
					character.initiative = 0;
			}

			RenderInitiativeTree();
			RenderStatusTree();
		}

		protected void PreviousCharacter_Clicked(object sender,EventArgs e){
			if(selectedIndex > 0)
				selectedIndex--;
			RenderInitiativeTree();
			RenderStatusTree();
		}

		protected void NextPass_Clicked (object sender, EventArgs e)
		{
			NextPass();
		}

		protected void DefendRanged_Clicked(object sender, EventArgs e){

		}

		protected void DefendMelee_Clicked(object sender, EventArgs e){

		}


		void NextCharacter ()
		{
			selectedIndex++;
			RenderInitiativeTree ();
			RenderStatusTree ();
			if (selectedIndex >= characters.Count)
				NextPass ();
		}

		protected void AttackRanged_Clicked (object sender, EventArgs e)
		{
			try {
				var f = new List<Character> (characters);
				f.Remove (GetSelectedInitiativeCharacter ());

				var csw = new CharacterSelectWindow (f);

				csw.Destroyed += delegate {
					new CombatSequence(GetSelectedInitiativeCharacter(),csw.character,new CallBack(AfterAttack));
				};
			} catch {
				new MessageWindow("Error","Make sure you have started the initiative");
			}
		}

		protected void AfterAttack ()
		{
			NextCharacter();
		}

		protected void AttackMelee_Clicked(object sender, EventArgs e){
			var csw = new CharacterSelectWindow(characters);
			csw.Destroyed += delegate {
				
			};
		}
		#endregion
	}
}

