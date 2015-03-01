using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class TaurusOmni6 : IRangedWeapon
	{
		public int Damage() {
			return 7;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 6;
		}

		public int AP ()
		{
			return -1;
		} 

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.LightPistols;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			rfm.SingleShot = true;
			return rfm;
		}

		public int MagSize(){
			return 6;
		}

		public string Name(){
			return "Taurus Omni-6";
		}
				
		public int Recoil(){
			return 0;
		}
	}
}

