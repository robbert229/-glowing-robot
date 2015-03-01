using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class ColtAmericaL36 : IRangedWeapon
	{
		public int Damage() {
			return 7;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 7;
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
			return 6;
		}

		public string Name(){
			return "Colt America L36";
		}

		public int Recoil(){
			return 0;
		}
	}
}

