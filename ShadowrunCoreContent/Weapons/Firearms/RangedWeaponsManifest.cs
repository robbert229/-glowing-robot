using System;
using ShadowrunLogic;
using System.Collections.Generic;


namespace ShadowrunCoreContent
{
	public class RangedWeaponsManifest : IManifest<IRangedWeapon>
	{
		private List<IRangedWeapon> contents;
		public RangedWeaponsManifest ()
		{
			contents = new List<IRangedWeapon>();

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
			contents.Add (new TaurusOmni6());
		}

		public List<IRangedWeapon> GetContents(){
			return contents;
		}

		public string PackName(){
			return "Shadowrun Core";
		}
	}
}

