using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class StreetlineSpecial : IRangedWeapon
	{
		public int Damage() {
			return 6;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 4;
		}

		public int AP ()
		{
			return 0;
		} 

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.Holdout;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public int MagSize(){
			return 6;
		}

		public string Name(){
			return "Streetline Special";
		}

		public int Recoil(){
			return 0;
		}
	}
}

