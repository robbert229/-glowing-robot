using System;
using ShadowrunLogic;
using System.Collections.Generic;

namespace ShadowrunCoreContent
{
	public class MeleeWeaponsManifest : IManifest<IManifestItem>
	{
		private List<IManifestItem> contents;
		public MeleeWeaponsManifest ()
		{
			contents = new List<IManifestItem>();

			//blades
			contents.Add(new CombatAxe());
			contents.Add (new CombatKnife());
			contents.Add (new ForearmSnapBlades());
			contents.Add (new Katana());
			contents.Add (new Knife());
			contents.Add (new Polearm());
			contents.Add (new SurvivalKnife());
			contents.Add (new Sword());
		}

		public List<IManifestItem> GetContents(){
			return contents;
		}

		public string PackName(){
			return "Shadowrun Core";
		}
	}
}

