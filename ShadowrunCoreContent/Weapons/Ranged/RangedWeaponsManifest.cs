using System;
using ShadowrunLogic;
using System.Collections.Generic;


namespace ShadowrunCoreContent
{
	public class RangedWeaponsManifest : IManifest<IManifestItem>
	{
		private List<IManifestItem> contents;
		public RangedWeaponsManifest ()
		{
			contents = new List<IManifestItem>();

			//tazers
			contents.Add (new DefianceEXShocker());
			contents.Add (new YamahaPulsar());

			//holdouts
			contents.Add (new FichettiTiffaniNeedler());
			contents.Add (new StreetlineSpecial());
			contents.Add (new WaltherPalmPistol());

			//light pistols
			contents.Add (new AresLightFire75());
			contents.Add (new AresLightFire70());
			contents.Add (new Beretta201T());
			contents.Add (new ColtAmericaL36());
			contents.Add (new FichettiSecurity600());
			contents.Add (new AresPredator());

			//machine pistols
			contents.Add (new AresCrusaderII());
			contents.Add (new CeskaBlackScorpion());
			contents.Add (new SteyrTMP());
		}

		public List<IManifestItem> GetContents(){
			return contents;
		}

		public string PackName(){
			return "Shadowrun Core";
		}
	}
}

