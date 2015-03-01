using System;
using System.Collections.Generic;

namespace ShadowrunLogic
{
	public class RangedWeaponsCatalog
	{
		//singleton stuff
		private static RangedWeaponsCatalog instance;
		public static RangedWeaponsCatalog Instance(){
			if(instance == null)
				instance = new RangedWeaponsCatalog();

			return instance;
		}

		// different content packs register with this 
		private List<IRangedWeapon> rangedWeaponsCatalog;

		private RangedWeaponsCatalog ()
		{
			rangedWeaponsCatalog = new List<IRangedWeapon>();
		}



		public void RegisterRangedWeapon(IRangedWeapon weapon){
			rangedWeaponsCatalog.Add(weapon);
		}

		public List<IRangedWeapon> GetRangedWeaponCatalog(){
			return rangedWeaponsCatalog;
		}
	}
}

