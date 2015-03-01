using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class Beretta201T : IRangedWeapon
	{
		public int Damage() {
			return 6;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 6;
		}

		public int AP ()
		{
			return 0;
		} 

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.LightPistols;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			rfm.SemiAutomaticBurst = true;
			return rfm;
		}

		public int MagSize(){
			return 21;
		}

		public string Name(){
			return "Beretta201T";
		}

		public int Recoil(){
			return 1;
		}
	}
}

