using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class AresLightFire75 : IRangedWeapon
	{
		public int Damage() {
			return 6;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 8;
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
			return rfm;
		}

		public int MagSize(){
			return 16;
		}

		public string Name(){
			return "Ares Light Fire 75";
		}

		public int Recoil(){
			return 0;
		}

	}
}

