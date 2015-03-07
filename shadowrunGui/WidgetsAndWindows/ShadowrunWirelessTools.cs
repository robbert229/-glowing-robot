using System;
using System.Collections.Generic;
using ShadowrunLogic;
using Gtk;
using System.Xml.Serialization;
using ShadowrunCoreContent;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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

			this.characters.Add (new Character(new GangerAttributes(),new FichettiSecurity600(),new Katana(),true));
			this.characters.Add (new Character(new CorporateSecurityAttributes(),new FichettiSecurity600(),new Katana(),true));

			this.characterpagewidget1.SetCharacters(characters);
			this.combatpagewidget1.SetCharacters(characters);

			this.Destroyed += delegate {
				Application.Quit();
			};
		}
	}
}

